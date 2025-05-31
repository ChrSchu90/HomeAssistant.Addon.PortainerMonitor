namespace HomeAssistant.Addon.PortainerMonitor.Mqtt;

using System;
using System.Collections.Concurrent;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;
using MQTTnet.Internal;
using MQTTnet.Protocol;
using Serilog;

/// <inheritdoc cref="IMqttClient" />
internal class MqttClient : IMqttClient, IDisposable
{
    #region Private Static Fields

    /// <summary>
    /// The online status of the <see cref="HomeAssistantAvailabilityTopic"/>
    /// </summary>
    internal const string OnlineAvailability = "online";

    /// <summary>
    /// The home assistant availability topic
    /// </summary>
    /// <remarks>Contains <c>online</c> or <c>offline</c></remarks>
    internal const string HomeAssistantAvailabilityTopic = "homeassistant/status";

    #endregion

    #region Private Fields

    private readonly ConcurrentDictionary<string, AsyncEvent<MqttMessageEventArgs>> _subs = new(StringComparer.OrdinalIgnoreCase);
    private readonly AsyncEvent<ConnectionStateChangedEventArgs> _connectionStateChanged = new();
    private readonly AsyncEvent<AvailabilityChangedEventArgs> _haAvailabilityChanged = new();
    private readonly SemaphoreSlim _subsSemaphore = new(1, 1);
    private readonly ManagedMqttClientOptions _mqttOptions;
    private readonly IManagedMqttClient _mqttClient;
    private readonly IMqttConfig _config;
    private readonly CancellationToken _ct;
    private TaskCompletionSource? _connectCompletionSrc;
    private bool? _homeAssistantAvailable; // Status is not retained and unknown after connect

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="MqttClient" /> class.
    /// </summary>
    /// <param name="config">The configuration.</param>
    /// <param name="clientId">The MQTT client ID.</param>
    /// <param name="ct">The shutdown cancellation token.</param>
    internal MqttClient(IMqttConfig config, string clientId, CancellationToken ct = default)
    {
        _config = config;
        _ct = ct;
        _mqttClient = new MqttFactory().CreateManagedMqttClient();
        _mqttClient.ConnectedAsync += MqttClient_ConnectedAsync;
        _mqttClient.DisconnectedAsync += MqttClient_DisconnectedAsync;
        _mqttClient.ConnectingFailedAsync += MqttClient_ConnectingFailedAsync;
        _mqttClient.ConnectionStateChangedAsync += MqttClient_ConnectionStateChangedAsync;
        _mqttClient.ApplicationMessageReceivedAsync += MqttClient_ApplicationMessageReceivedAsync;

        var mqttClientOptions = new MqttClientOptionsBuilder()
            .WithCleanSession()
            .WithClientId(clientId)
            .WithKeepAlivePeriod(TimeSpan.FromSeconds(5))
            .WithTcpServer(_config.MqttHost, _config.MqttPort)
            .WithCredentials(_config.MqttUser, _config.MqttPassword)
            .WithTlsOptions(builder => { builder.UseTls(_config.MqttTlsEnabled); builder.WithCertificateValidationHandler(CertificateValidationHandler); });

        _mqttOptions = new ManagedMqttClientOptionsBuilder()
            .WithAutoReconnectDelay(TimeSpan.FromSeconds(10))
            .WithClientOptions(mqttClientOptions.Build())
            //.WithStorage() // Is it required to store retain topics for delete?!?
            .Build();
    }

    #endregion

    #region Events

    /// <inheritdoc />
    public event Func<ConnectionStateChangedEventArgs, Task> ConnectionStateChangedAsync
    {
        add => _connectionStateChanged.AddHandler(value);
        remove => _connectionStateChanged.RemoveHandler(value);
    }

    /// <inheritdoc />
    public event Func<AvailabilityChangedEventArgs, Task> HomeAssistantAvailabilityChangedAsync
    {
        add => _haAvailabilityChanged.AddHandler(value);
        remove => _haAvailabilityChanged.RemoveHandler(value);
    }

    #endregion

    #region Properties

    /// <inheritdoc />
    public bool IsConnected => !_ct.IsCancellationRequested && _mqttClient.IsStarted && _mqttClient.IsConnected;

    /// <inheritdoc />
    public bool IsHomeAssistantAvailable => _homeAssistantAvailable.GetValueOrDefault(true);

    #endregion

    #region Public Methods

    /// <inheritdoc />
    public void Dispose()
    {
        _mqttClient.ConnectedAsync -= MqttClient_ConnectedAsync;
        _mqttClient.DisconnectedAsync -= MqttClient_DisconnectedAsync;
        _mqttClient.ConnectingFailedAsync -= MqttClient_ConnectingFailedAsync;
        _mqttClient.ConnectionStateChangedAsync -= MqttClient_ConnectionStateChangedAsync;
        _mqttClient.ApplicationMessageReceivedAsync -= MqttClient_ApplicationMessageReceivedAsync;
        UnsubscribeAsync(HomeAssistantAvailabilityTopic, HomeAssistantAvailability_Changed).Wait(CancellationToken.None);
        _mqttClient.Dispose();
        _subsSemaphore.Dispose();
    }

    /// <summary>
    /// Connects the MQTT client.
    /// </summary>
    public async Task ConnectAsync(bool waitForResult)
    {
        Log.Information($"MQTT: Connecting to {_config.MqttHost}:{_config.MqttPort}...");
        if (!waitForResult)
        {
            await _mqttClient.StartAsync(_mqttOptions).ConfigureAwait(false);
            await SubscribeAsync(HomeAssistantAvailabilityTopic, HomeAssistantAvailability_Changed).ConfigureAwait(false);
            return;
        }

        _connectCompletionSrc = new TaskCompletionSource();
        await _mqttClient.StartAsync(_mqttOptions).ConfigureAwait(false);
        await SubscribeAsync(HomeAssistantAvailabilityTopic, HomeAssistantAvailability_Changed).ConfigureAwait(false);
        await _connectCompletionSrc.Task.ConfigureAwait(false);
        _connectCompletionSrc = null;
    }

    /// <summary>
    /// Disconnects the MQTT client.
    /// </summary>
    public async Task DisconnectAsync()
    {
        await UnsubscribeAsync(HomeAssistantAvailabilityTopic, HomeAssistantAvailability_Changed).ConfigureAwait(false);
        await _mqttClient.StopAsync().ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task SubscribeAsync(string topic, Func<MqttMessageEventArgs, Task> callback)
    {
        try
        {
            await _subsSemaphore.WaitAsync(CancellationToken.None).ConfigureAwait(false);
            if (!_subs.TryGetValue(topic, out var ev))
            {
                ev = new AsyncEvent<MqttMessageEventArgs>();
                _subs.TryAdd(topic, ev);
                Log.Verbose($"MQTT: Subscribe to topic `{topic}`");
                await _mqttClient.SubscribeAsync(topic).ConfigureAwait(false);
            }

            ev.AddHandler(callback);
        }
        finally
        {
            _subsSemaphore.Release();
        }
    }

    /// <inheritdoc />
    public async Task UnsubscribeAsync(string topic, Func<MqttMessageEventArgs, Task> callback)
    {
        try
        {
            await _subsSemaphore.WaitAsync(CancellationToken.None).ConfigureAwait(false);
            if (_subs.TryGetValue(topic, out var ev))
            {
                ev.RemoveHandler(callback);
                if (!ev.HasHandlers && _subs.TryRemove(topic, out _))
                {
                    Log.Verbose($"MQTT: Unsubscribe from topic `{topic}`");
                    await _mqttClient.UnsubscribeAsync(topic).ConfigureAwait(false);
                }
            }
        }
        finally
        {
            _subsSemaphore.Release();
        }
    }

    /// <inheritdoc />
    public async Task<bool> PublishAsync(string topic, string? payload, MqttQualityOfServiceLevel level = MqttQualityOfServiceLevel.AtMostOnce, bool retain = false)
    {
        try
        {
            Log.Verbose($"MQTT: Publish topic `{topic}` with payload:\n{payload ?? "null"}");
            await _mqttClient.EnqueueAsync(topic, _ct.IsCancellationRequested ? null : payload, level, retain).ConfigureAwait(false);
            return true;
        }
        catch (Exception err)
        {
            Log.Error(err, $"MQTT: Error on publish topic `{topic}` with payload:\n{payload ?? "null"}");
            return false;
        }
    }

    /// <summary>
    /// Invokes the <seealso cref="ConnectionStateChangedAsync"/> event.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="isConnected">if set to <c>true</c> if MQTT client is connected.</param>
    protected virtual Task OnConnectionStateChangedAsync(IMqttClient sender, bool isConnected)
    {
        return _connectionStateChanged.HasHandlers ?
                   _connectionStateChanged.InvokeAsync(new ConnectionStateChangedEventArgs(sender, isConnected)) :
                   Task.CompletedTask;
    }

    /// <summary>
    /// Invokes the <seealso cref="HomeAssistantAvailabilityChangedAsync"/> event.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="isAvailable">if set to <c>true</c> if home assistant is available.</param>
    protected virtual Task OnHomeAssistantAvailabilityChangedAsync(IMqttClient sender, bool isAvailable)
    {
        return _haAvailabilityChanged.HasHandlers ?
                   _haAvailabilityChanged.InvokeAsync(new AvailabilityChangedEventArgs(sender, isAvailable)) :
                   Task.CompletedTask;
    }

    #endregion

    #region Private Methods

    private Task MqttClient_ConnectionStateChangedAsync(EventArgs arg)
    {
        Log.Information($"MQTT: Connection state changed to `{(_mqttClient.IsConnected ? "Connected" : "Disconnected")}`");
        return OnConnectionStateChangedAsync(this, _mqttClient.IsConnected);
    }

    private Task MqttClient_ConnectingFailedAsync(ConnectingFailedEventArgs e)
    {
        _connectCompletionSrc?.SetResult();
        Log.Error(e.Exception, "MQTT: failed to connect!");
        return Task.CompletedTask;
    }

    private Task MqttClient_ConnectedAsync(MqttClientConnectedEventArgs e)
    {
        _connectCompletionSrc?.SetResult();
        return Task.CompletedTask;
    }

    private Task MqttClient_DisconnectedAsync(MqttClientDisconnectedEventArgs arg)
    {
        return Task.CompletedTask;
    }

    private async Task MqttClient_ApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs e)
    {
        var message = e.ApplicationMessage;
        if (message == null) return;

        AsyncEvent<MqttMessageEventArgs>? ev;
        try
        {
            await _subsSemaphore.WaitAsync(CancellationToken.None).ConfigureAwait(false);
            if (!_subs.TryGetValue(message.Topic, out ev)) return;
        }
        finally
        {
            _subsSemaphore.Release();
        }

        if (ev.HasHandlers && !_ct.IsCancellationRequested)
        {
            var payload = message.ConvertPayloadToString();
            Log.Verbose($"MQTT: Received topic `{message.Topic}` with payload:\n`{payload}`");
            await ev.InvokeAsync(new MqttMessageEventArgs(message, payload)).ConfigureAwait(false);
        }
    }

    private bool CertificateValidationHandler(MqttClientCertificateValidationEventArgs e)
    {
        if (!_config.MqttTlsValidate || e.SslPolicyErrors == SslPolicyErrors.None) return true;

        if (e.Certificate == null || e.Chain == null) return false;
        using var cert = new X509Certificate2(e.Certificate);
        return e.Chain.Build(cert);
    }

    private Task HomeAssistantAvailability_Changed(MqttMessageEventArgs e)
    {
        Log.Information($"MQTT: Home Assistant availability changed to `{e.MessageContent}`");
        var haAvailable = string.Equals(e.MessageContent, OnlineAvailability, StringComparison.OrdinalIgnoreCase);
        if (IsHomeAssistantAvailable == haAvailable)
            return Task.CompletedTask;

        _homeAssistantAvailable = haAvailable;
        return OnHomeAssistantAvailabilityChangedAsync(this, haAvailable);
    }

    #endregion
}

/// <summary>
/// Event args wrapper for <see cref="MqttApplicationMessage"/>
/// </summary>
/// <seealso cref="EventArgs" />
internal class MqttMessageEventArgs(MqttApplicationMessage _message, string? _messageContent) : EventArgs
{
    /// <summary>
    /// Gets the message.
    /// </summary>
    internal MqttApplicationMessage Message => _message;

    /// <summary>
    /// Gets the content of the message.
    /// </summary>
    internal string? MessageContent => _messageContent;
}