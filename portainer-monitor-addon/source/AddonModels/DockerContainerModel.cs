namespace HomeAssistant.Addon.PortainerMonitor.AddonModels;

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAssistant.Addon.PortainerMonitor.Mqtt;
using HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;
using HomeAssistant.Addon.PortainerMonitor.Portainer;
using HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;
using Serilog;

internal class DockerContainerModel<T> : ModelBase<EndpointBase<T>> where T : ModelBase
{
    #region Private Static Fields

    /// <summary>
    /// The change state command timeout in milliseconds to start/stop/restart or pause the container
    /// </summary>
    // ReSharper disable once StaticMemberInGenericType
    private static readonly TimeSpan ChangeStateCommandTimeout = TimeSpan.FromSeconds(30);

    #endregion

    #region Private Fields

    private readonly CancellationTokenSource _disposeTokenSource;
    private readonly CancellationToken _disposeToken;
    private readonly SemaphoreSlim _sendCommandLock = new(1, 1);
    private readonly HaSensor<ContainerState>? _sensorState;
    private readonly HaSensor<float>? _sensorMemoryConsumption;
    private readonly HaSensor<float>? _sensorMemoryUsage;
    private readonly HaSensor<uint>? _sensorNetworkDownload;
    private readonly HaSensor<uint>? _sensorNetworkUpload;
    private readonly HaSensor<float>? _sensorCpuUsage;
    private readonly HaSwitch? _switchStartStop;
    private readonly HaButton? _buttonPause;
    private readonly HaButton? _buttonRestart;
    private readonly bool _monitorResources;
    private ContainerStats? _oldContainerStats;
    private ContainerStats? _latestContainerStats;
    private DockerContainer? _previousInfo;
    private DockerContainer _latestInfo;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="PortainerEndpointModel"/> class.
    /// </summary>
    internal DockerContainerModel(EndpointBase<T> endpoint, DockerContainer container, string name)
        : base(endpoint, name)
    {
        ID = container.Id;
        _latestInfo = container;

        _disposeTokenSource = new CancellationTokenSource();
        _disposeToken = _disposeTokenSource.Token;

        var containerAvailabilities = CreateAvailabilities(Endpoint.Host.Availability, Endpoint.Availability);

        if (endpoint.Config.ContainerCommands)
        {
            _switchStartStop = CreateSwitchEntity("startstop_switch", $"{Endpoint.Name} {Name}");
            _switchStartStop.Availabilities = containerAvailabilities;
            _switchStartStop.AvailabilityMode = HaAvailability.ModeAll;
            _switchStartStop.SwitchCommandReceived += OnSwitchCommandReceived;
            _switchStartStop.Icon = "mdi:docker";

            _buttonPause = CreateButtonEntity("pause_button", $"{Endpoint.Name} {Name}");
            _buttonPause.Availabilities = containerAvailabilities;
            _buttonPause.AvailabilityMode = HaAvailability.ModeAll;
            _buttonPause.ButtonCommandReceived += OnPauseCommandReceived;
            _buttonPause.Icon = "mdi:pause";

            _buttonRestart = CreateButtonEntity("restart_button", $"{Endpoint.Name} {Name}");
            _buttonRestart.Availabilities = containerAvailabilities;
            _buttonRestart.AvailabilityMode = HaAvailability.ModeAll;
            _buttonRestart.ButtonCommandReceived += OnRestartCommandReceived;
            _buttonRestart.Icon = "mdi:restart";
        }

        if (endpoint.Config.ContainerStateMonitoring)
        {
            _sensorState = CreateSensorEntity<ContainerState>("status_sensor", $"{Endpoint.Name} {Name}");
            _sensorState.Availabilities = containerAvailabilities;
            _sensorState.AvailabilityMode = HaAvailability.ModeAll;
            _sensorState.Icon = "mdi:state-machine";
            _sensorState.StateClass = null;
        }

        if (endpoint.Config.ContainerCpuMonitoring)
        {
            _monitorResources = true;
            _sensorCpuUsage = CreateSensorEntity<float>("cpuusage_sensor", $"{Endpoint.Name} {Name} CPU");
            _sensorCpuUsage.Availabilities = containerAvailabilities;
            _sensorCpuUsage.AvailabilityMode = HaAvailability.ModeAll;
            _sensorCpuUsage.Icon = "mdi:gauge";
            _sensorCpuUsage.StateClass = HaSensorStateClass.MEASUREMENT;
            _sensorCpuUsage.UnitOfMeasurement = HaUnitOfMeasurement.PERCENTAGE;
            _sensorCpuUsage.SuggestedDisplayPrecision = 2;
        }

        if (endpoint.Config.ContainerRamMonitoring)
        {
            _monitorResources = true;
            _sensorMemoryConsumption = CreateSensorEntity<float>("memconsumption_sensor", $"{Endpoint.Name} {Name} RAM");
            _sensorMemoryConsumption.Availabilities = containerAvailabilities;
            _sensorMemoryConsumption.AvailabilityMode = HaAvailability.ModeAll;
            _sensorMemoryConsumption.Icon = "mdi:memory";
            _sensorMemoryConsumption.StateClass = HaSensorStateClass.MEASUREMENT;
            _sensorMemoryConsumption.UnitOfMeasurement = HaUnitOfMeasurement.DATA_MEGABYTES;
            _sensorMemoryConsumption.SuggestedDisplayPrecision = 2;

            _sensorMemoryUsage = CreateSensorEntity<float>("memusage_sensor", $"{Endpoint.Name} {Name} RAM");
            _sensorMemoryUsage.Availabilities = containerAvailabilities;
            _sensorMemoryUsage.AvailabilityMode = HaAvailability.ModeAll;
            _sensorMemoryUsage.Icon = "mdi:memory";
            _sensorMemoryUsage.StateClass = HaSensorStateClass.MEASUREMENT;
            _sensorMemoryUsage.UnitOfMeasurement = HaUnitOfMeasurement.PERCENTAGE;
            _sensorMemoryUsage.SuggestedDisplayPrecision = 2;
        }

        if (endpoint.Config.ContainerNetworkMonitoring)
        {
            _monitorResources = true;
            _sensorNetworkDownload = CreateSensorEntity<uint>("download_sensor", $"{Endpoint.Name} {Name} Download");
            _sensorNetworkDownload.Availabilities = containerAvailabilities;
            _sensorNetworkDownload.AvailabilityMode = HaAvailability.ModeAll;
            _sensorNetworkDownload.Icon = "mdi:download";
            _sensorNetworkDownload.StateClass = HaSensorStateClass.MEASUREMENT;
            _sensorNetworkDownload.UnitOfMeasurement = HaUnitOfMeasurement.DATA_RATE_KILOBYTES_PER_SECOND;
            _sensorNetworkDownload.SuggestedDisplayPrecision = 0;

            _sensorNetworkUpload = CreateSensorEntity<uint>("upload_sensor", $"{Endpoint.Name} {Name} Upload");
            _sensorNetworkUpload.Availabilities = containerAvailabilities;
            _sensorNetworkUpload.AvailabilityMode = HaAvailability.ModeAll;
            _sensorNetworkUpload.Icon = "mdi:upload";
            _sensorNetworkUpload.StateClass = HaSensorStateClass.MEASUREMENT;
            _sensorNetworkUpload.UnitOfMeasurement = HaUnitOfMeasurement.DATA_RATE_KILOBYTES_PER_SECOND;
            _sensorNetworkUpload.SuggestedDisplayPrecision = 0;
        }

        InitAsyncResourceUsageCollection();
    }

    #endregion

    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets the container ID.
    /// </summary>
    internal string ID { get; }

    /// <summary>
    /// Gets the name of the container.
    /// </summary>
    internal string Name => NameID;

    /// <summary>
    /// Gets the endpoint API.
    /// </summary>
    internal IEndpointApi EndpointApi => Endpoint.EndpointApi;

    /// <summary>
    /// Gets the state of the container.
    /// </summary>
    internal ContainerState ContainerState => LatestInfo.State;

    /// <summary>
    /// Gets the endpoint of the container.
    /// </summary>
    internal EndpointBase<T> Endpoint => Parent;

    /// <summary>
    /// Gets or sets the latest known container information received from the <see cref="Endpoint"/>.
    /// </summary>
    internal DockerContainer LatestInfo
    {
        get => _latestInfo;
        set
        {
            _previousInfo = _latestInfo;
            _latestInfo = value;
        }
    }

    /// <summary>
    /// Gets or sets the previous known container information received from the <see cref="Endpoint"/>.
    /// </summary>
    internal DockerContainer? PreviousInfo => _previousInfo;

    #endregion

    #region Public Methods

    /// <inheritdoc />
    /// <remarks>Make sure to update <see cref="LatestInfo"/> before update.</remarks>
    internal override Task<bool> OnUpdateStatesAsync(bool force)
    {
        if (ContainerState != PreviousInfo?.State)
            Log.Debug($"Container: `{Endpoint.Config.Id}.{Endpoint.NameID}.{Name}` changed state to `{ContainerState}`");

        if (_sensorState != null)
            _sensorState.Value = ContainerState;

        if (_switchStartStop != null && !_switchStartStop.IsCommandProcessingActive)
            _switchStartStop.IsChecked = ContainerState is ContainerState.Restarting or ContainerState.Running;

        return UpdateResourceUsage();
    }

    /// <summary>
    /// Getting called if the on/off switch receives a command from Home Assistant (toggle).
    /// </summary>
    /// <param name="e">The <see cref="SwitchCommandReceivedEventArgs" /> instance containing the event data.</param>
    protected virtual async Task OnSwitchCommandReceived(SwitchCommandReceivedEventArgs e)
    {
        try
        {
            if (_disposeToken.IsCancellationRequested)
                return;

            await _sendCommandLock.WaitAsync(_disposeToken).ConfigureAwait(false);
            if (!e.CommandValue && ContainerState is ContainerState.Running)
            {
                Log.Information($"Container: `{Endpoint.Config.Id}.{Endpoint.NameID}.{Name}` sending stop command...");
                var result = await EndpointApi.StopContainerAsync(ID).ConfigureAwait(false);
                Log.Information($"Container: `{Endpoint.Config.Id}.{Endpoint.NameID}.{Name}` send stop command {(result ? "successfully!" : "failed!")}");
                SpinWait.SpinUntil(() => !result || ContainerState is ContainerState.Exited, ChangeStateCommandTimeout);
                return;
            }

            if (e.CommandValue && ContainerState is ContainerState.Exited)
            {
                Log.Information($"Container: `{Endpoint.Config.Id}.{Endpoint.NameID}.{Name}` sending start command...");
                var result = await EndpointApi.StartContainerAsync(ID).ConfigureAwait(false);
                Log.Information($"Container: `{Endpoint.Config.Id}.{Endpoint.NameID}.{Name}` send start command {(result ? "successfully!" : "failed!")}");
                SpinWait.SpinUntil(() => !result || ContainerState is ContainerState.Running, ChangeStateCommandTimeout);
                return;
            }

            if (e.CommandValue && ContainerState is ContainerState.Paused)
            {
                Log.Information($"Container: `{Endpoint.Config.Id}.{Endpoint.NameID}.{Name}` sending unpause command...");
                var result = await EndpointApi.UnpauseContainerAsync(ID).ConfigureAwait(false);
                Log.Information($"Container: `{Endpoint.Config.Id}.{Endpoint.NameID}.{Name}` send unpause command {(result ? "successfully!" : "failed!")}");
                SpinWait.SpinUntil(() => !result || ContainerState is ContainerState.Running, ChangeStateCommandTimeout);
            }
        }
        catch (OperationCanceledException) { /* ignore */ }
        finally
        {
            if (!_disposeToken.IsCancellationRequested)
                _sendCommandLock.Release();
        }
    }

    /// <summary>
    /// Getting called if the restart button receives a command from Home Assistant (click).
    /// </summary>
    /// <param name="e">The <see cref="ButtonCommandReceivedEventArgs" /> instance containing the event data.</param>
    protected virtual async Task OnRestartCommandReceived(ButtonCommandReceivedEventArgs e)
    {
        try
        {
            if (_disposeToken.IsCancellationRequested)
                return;

            await _sendCommandLock.WaitAsync(_disposeToken).ConfigureAwait(false);
            if (ContainerState is ContainerState.Running)
            {
                Log.Information($"Container: `{Endpoint.Config.Id}.{Endpoint.NameID}.{Name}` sending restart command...");
                var result = await EndpointApi.RestartContainerAsync(ID).ConfigureAwait(false);
                Log.Information($"Container: `{Endpoint.Config.Id}.{Endpoint.NameID}.{Name}` send restart command {(result ? "successfully!" : "failed!")}");
                SpinWait.SpinUntil(() => !result || ContainerState is ContainerState.Running, ChangeStateCommandTimeout);
            }
        }
        catch (OperationCanceledException) { /* ignore */ }
        finally
        {
            if (!_disposeToken.IsCancellationRequested)
                _sendCommandLock.Release();
        }
    }

    /// <summary>
    /// Getting called if the pause button receives a command from Home Assistant (click).
    /// </summary>
    /// <param name="e">The <see cref="ButtonCommandReceivedEventArgs" /> instance containing the event data.</param>
    protected virtual async Task OnPauseCommandReceived(ButtonCommandReceivedEventArgs e)
    {
        try
        {
            if (_disposeToken.IsCancellationRequested)
                return;

            await _sendCommandLock.WaitAsync(_disposeToken).ConfigureAwait(false);
            if (ContainerState is ContainerState.Running)
            {
                Log.Information($"Container: `{Endpoint.Config.Id}.{Endpoint.NameID}.{Name}` sending pause command...");
                var result = await EndpointApi.PauseContainerAsync(ID).ConfigureAwait(false);
                Log.Information($"Container: `{Endpoint.Config.Id}.{Endpoint.NameID}.{Name}` send pause command {(result ? "successfully!" : "failed!")}");
                SpinWait.SpinUntil(() => !result || ContainerState is ContainerState.Paused, ChangeStateCommandTimeout);
            }
        }
        catch (OperationCanceledException) { /* ignore */ }
        finally
        {
            if (!_disposeToken.IsCancellationRequested)
                _sendCommandLock.Release();
        }
    }

    /// <inheritdoc />
    protected override void OnDispose(bool disposing)
    {
        base.OnDispose(disposing);
        if (!disposing) return;

        _disposeTokenSource.Cancel();
        _disposeTokenSource.Dispose();

        if (_switchStartStop != null) 
            _switchStartStop.SwitchCommandReceived -= OnSwitchCommandReceived;

        if (_buttonPause != null) 
            _buttonPause.ButtonCommandReceived -= OnPauseCommandReceived;

        if (_buttonRestart != null)
            _buttonRestart.ButtonCommandReceived -= OnRestartCommandReceived;

        _sendCommandLock.Dispose();
        _oldContainerStats = null;
    }

    /// <inheritdoc />
    protected override Task OnHomeAssistantAvailabilityChangedAsync(AvailabilityChangedEventArgs e)
    {
        if (!IsDisposed && !e.IsAvailable)
            _oldContainerStats = null;

        return base.OnHomeAssistantAvailabilityChangedAsync(e);
    }

    /// <inheritdoc />
    protected override Task OnMqttConnectionStateChangeAsync(ConnectionStateChangedEventArgs e)
    {
        if (!IsDisposed && !e.IsConnected)
            _oldContainerStats = null;

        return base.OnMqttConnectionStateChangeAsync(e);
    }

    #endregion

    #region Private Methods

    private void InitAsyncResourceUsageCollection()
    {
        if (!_monitorResources) return;
        _ = Task.Run(
            async () =>
            {
                var logError = true;
                while (!_disposeToken.IsCancellationRequested)
                {
                    try
                    {
                        // It looks like polling of resource usage is more consistent for large environments,
                        // sometimes streaming data will not be received for up to 15s for whatever reason
                        var stats = await EndpointApi.GetContainerStatsAsync(ID).ConfigureAwait(false);
                        if (stats != null)
                        {
                            //Log.Debug($"Container: Received stats {stats.Read.ToLocalTime():T} of `{Endpoint.Config.Id}.{Endpoint.NameID}.{Name}`");
                            _oldContainerStats ??= stats;
                            _latestContainerStats = stats;
                            logError = true;
                        }
                    }
                    catch (OperationCanceledException) { /* ignore */ }
                    catch (Exception err)
                    {
                        _latestContainerStats = null;
                        if(logError) Log.Error(err, $"Container: Error on receiving `{Endpoint.Config.Id}.{Endpoint.NameID}.{Name}` resource stats");
                        logError = false;
                    }

                    await Task.Delay(1000, _disposeToken).ConfigureAwait(false);
                }
            }, _disposeToken);
    }

    private Task<bool> UpdateResourceUsage()
    {
        if (!_monitorResources) return Task.FromResult(true);
        var latestStats = _latestContainerStats;
        if (latestStats == null)
        {
            _oldContainerStats = null;
            return Task.FromResult(true);
        }

        var oldStats = _oldContainerStats;
        if (oldStats == null || oldStats.Read >= latestStats.Read)
        {
            _oldContainerStats = latestStats;
            return Task.FromResult(true);
        }

        Log.Debug($"Container: Update stats ({oldStats.Read.ToLocalTime():T}-{latestStats.Read.ToLocalTime():T}) of `{Endpoint.Config.Id}.{Endpoint.NameID}.{Name}`");
        var timeDiff = latestStats.Read - oldStats.Read;
        UpdateMemoryUsage(latestStats);
        UpdateCpuUsage(latestStats, oldStats);
        UpdateNetworkUsage(latestStats, oldStats, timeDiff);
        _oldContainerStats = latestStats;
        return Task.FromResult(true);
    }

    private void UpdateMemoryUsage(ContainerStats containerStats)
    {
        if (_sensorMemoryConsumption == null || _sensorMemoryUsage == null) return;
        _sensorMemoryConsumption.Value = containerStats.MemoryStats.UsedMemoryBytes / (1024.0f * 1024.0f);
        _sensorMemoryUsage.Value = containerStats.MemoryStats.MaxMemoryBytes >= containerStats.MemoryStats.UsedMemoryBytes && containerStats.MemoryStats.UsedMemoryBytes > 0 ?
                                        (float)(containerStats.MemoryStats.UsedMemoryBytes / (double)containerStats.MemoryStats.MaxMemoryBytes * 100.0) : _sensorMemoryUsage.Value;
    }

    private void UpdateCpuUsage(ContainerStats currentStats, ContainerStats oldStats)
    {
        if (_sensorCpuUsage == null) return;
        var diffSystemUsage = currentStats.CurrentCpuStats.SystemUsage - oldStats.CurrentCpuStats.SystemUsage;
        var diffContainerUsage = currentStats.CurrentCpuStats.CpuUsage.Total - oldStats.CurrentCpuStats.CpuUsage.Total;
        _sensorCpuUsage.Value = diffSystemUsage > 0 && diffContainerUsage > 0 ?
                                    Math.Max(Math.Min((float)(diffContainerUsage / (double)diffSystemUsage * 100.0), 100.00f), 0.00f) : _sensorCpuUsage.Value;
    }

    private void UpdateNetworkUsage(ContainerStats currentStats, ContainerStats oldStats, TimeSpan timeDiff)
    {
        if (_sensorNetworkDownload == null || _sensorNetworkUpload == null || timeDiff < TimeSpan.Zero) return;
        var bytesReceived = currentStats.NetworkStats.Select(s => s.Value).Sum(v => (double)v.RxBytes);
        var oldBytesReceived = oldStats.NetworkStats.Select(s => s.Value).Sum(v => (double)v.RxBytes);
        var bytesSend = currentStats.NetworkStats.Select(s => s.Value).Sum(v => (double)v.TxBytes);
        var oldBytesSend = oldStats.NetworkStats.Select(s => s.Value).Sum(v => (double)v.TxBytes);

        _sensorNetworkDownload.Value = bytesReceived >= oldBytesReceived ?
                                           (uint)((bytesReceived - oldBytesReceived) / timeDiff.TotalSeconds / 1024) : _sensorNetworkDownload.Value;
        _sensorNetworkUpload.Value = bytesSend >= oldBytesSend ?
                                         (uint)((bytesSend - oldBytesSend) / timeDiff.TotalSeconds / 1024) : _sensorNetworkUpload.Value;
    }

    #endregion
}