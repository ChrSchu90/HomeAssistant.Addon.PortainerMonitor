namespace HomeAssistant.Addon.PortainerMonitor.Mqtt;

using System.Threading.Tasks;
using System;
using MQTTnet.Protocol;

/// <summary>
/// MQTT client access for Home Assistant communication see:
/// <see href="https://github.com/dotnet/MQTTnet/wiki/"/>
/// </summary>
internal interface IMqttClient
{
    #region Events

    /// <summary>
    /// Occurs when MQTT <see cref="IsConnected"/>e has changed.
    /// </summary>
    event Func<ConnectionStateChangedEventArgs, Task> ConnectionStateChangedAsync;

    /// <summary>
    /// Occurs when <seealso cref="IsHomeAssistantAvailable"/>changed.
    /// </summary>
    event Func<AvailabilityChangedEventArgs, Task> HomeAssistantAvailabilityChangedAsync;

    #endregion

    #region Properties

    /// <summary>
    /// Gets a value indicating whether the MQTT client is connected.
    /// </summary>
    bool IsConnected { get; }

    /// <summary>
    /// Gets a value indicating whether home assistant available by its availability state.
    /// </summary>
    bool IsHomeAssistantAvailable { get; }

    #endregion

    #region Methods

    /// <summary>
    /// Subscribes to a topic and invokes the callback if a message got send.
    /// </summary>
    /// <param name="topic">The MQTT topic.</param>
    /// <param name="callback">The message callback.</param>
    Task SubscribeAsync(string topic, Func<MqttMessageEventArgs, Task> callback);

    /// <summary>
    /// Unsubscribes from a topic.
    /// </summary>
    /// <param name="topic">The MQTT topic.</param>
    /// <param name="callback">The message callback.</param>
    Task UnsubscribeAsync(string topic, Func<MqttMessageEventArgs, Task> callback);

    /// <summary>
    /// Publishes the specified payload of the given topic.
    /// </summary>
    /// <param name="topic">The topic.</param>
    /// <param name="payload">The payload, if <c>null</c> topic gets deleted.</param>
    /// <param name="level">The MQTT quality of service level.</param>
    /// <param name="retain">if set to <c>true</c> MQTT Broker retains the value.</param>
    /// <returns><c>true</c> if send successfully</returns>
    public Task<bool> PublishAsync(string topic, string? payload, MqttQualityOfServiceLevel level = MqttQualityOfServiceLevel.AtMostOnce, bool retain = false);

    #endregion
}

/// <summary>
/// Envent Args for <see cref="IMqttClient.HomeAssistantAvailabilityChangedAsync"/>
/// </summary>
internal class AvailabilityChangedEventArgs(IMqttClient _mqttClient, bool _isAvailable) : EventArgs
{
    /// <summary>
    /// Gets a value indicating whether Home Assistant is available.
    /// </summary>
    internal bool IsAvailable => _isAvailable;

    /// <summary>
    /// Gets the MQTT client.
    /// </summary>
    internal IMqttClient MqttClient => _mqttClient;
}

/// <summary>
/// Event args for <see cref="IMqttClient.ConnectionStateChangedAsync"/>
/// </summary>
internal class ConnectionStateChangedEventArgs(IMqttClient _mqttClient, bool _isConnected) : EventArgs
{
    /// <summary>
    /// Gets a value indicating whether the MQTT client is connected.
    /// </summary>
    internal bool IsConnected => _isConnected;

    /// <summary>
    /// Gets the MQTT client.
    /// </summary>
    internal IMqttClient MqttClient => _mqttClient;
}