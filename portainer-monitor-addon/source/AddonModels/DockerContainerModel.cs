namespace HomeAssistant.Addon.PortainerMonitor.AddonModels;

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAssistant.Addon.PortainerMonitor.Mqtt;
using HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;
using HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;
using Serilog;

internal class DockerContainerModel : ModelBase<PortainerEndpointModel>
{
    #region Private Static Fields

    /// <summary>
    /// The change state command timeout in milliseconds to start/stop/restart or pause the container
    /// </summary>
    private static readonly TimeSpan ChangeStateCommandTimeout = TimeSpan.FromSeconds(30);

    #endregion

    #region Private Fields

    private readonly CancellationTokenSource _disposeTokenSource;
    private readonly CancellationToken _disposeToken;
    private readonly SemaphoreSlim _sendCommandLock = new(1, 1);
    private readonly HaSensor<ContainerState> _sensorState;
    private readonly HaSwitch _switchStartStop;
    private readonly HaButton _buttonPause;
    private readonly HaButton _buttonRestart;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="PortainerEndpointModel"/> class.
    /// </summary>
    internal DockerContainerModel(PortainerEndpointModel endpoint, DockerContainer container)
        : base(endpoint, container.Names.FirstOrDefault()?.Trim('/') ?? container.Id)
    {
        ID = container.Id;
        LatestInfo = container;

        _disposeTokenSource = new CancellationTokenSource();
        _disposeToken = _disposeTokenSource.Token;

        _switchStartStop = CreateSwitchEntity("startstop_switch", $"{Endpoint.Name} {Name}");
        _switchStartStop.Availabilities = [Endpoint.Host.Availability, Endpoint.Availability];
        _switchStartStop.AvailabilityMode = HaAvailability.ModeAll;
        _switchStartStop.SwitchCommandReceived += OnSwitchCommandReceived;
        _switchStartStop.Icon = "mdi:docker";

        _buttonPause = CreateButtonEntity("pause_button", $"{Endpoint.Name} {Name}");
        _buttonPause.Availabilities = [Endpoint.Host.Availability, Endpoint.Availability];
        _buttonPause.AvailabilityMode = HaAvailability.ModeAll;
        _buttonPause.ButtonCommandReceived += OnPauseCommandReceived;
        _buttonPause.Icon = "mdi:pause";

        _buttonRestart = CreateButtonEntity("restart_button", $"{Endpoint.Name} {Name}");
        _buttonRestart.Availabilities = [Endpoint.Host.Availability, Endpoint.Availability];
        _buttonRestart.AvailabilityMode = HaAvailability.ModeAll;
        _buttonRestart.ButtonCommandReceived += OnRestartCommandReceived;
        _buttonRestart.Icon = "mdi:restart";

        _sensorState = CreateSensorEntity<ContainerState>(HaEntityBase.BuildID("status_sensor"), $"{Endpoint.Name} {Name}");
        _sensorState.Availabilities = [Endpoint.Host.Availability, Endpoint.Availability];
        _sensorState.AvailabilityMode = HaAvailability.ModeAll;
        _sensorState.Icon = "mdi:state-machine";
        _sensorState.StateClass = null;
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
    /// Gets the state of the container.
    /// </summary>
    internal ContainerState ContainerState => LatestInfo.State;

    /// <summary>
    /// Gets the endpoint of the container.
    /// </summary>
    internal PortainerEndpointModel Endpoint => Parent;

    /// <summary>
    /// Gets or sets the latest known container information received from the <see cref="Endpoint"/>.
    /// </summary>
    internal DockerContainer LatestInfo { get; set; }

    #endregion

    #region Public Methods

    /// <inheritdoc />
    /// <remarks>Make sure to update <see cref="LatestInfo"/> before update.</remarks>
    internal override async Task<bool> OnUpdateStatesAsync(bool force)
    {
        //var containerStats = await PortainerApi.GetContainerStatsAsync(Endpoint.ID, ID).ConfigureAwait(false);
        //var a = containerStats?.Read?.ToLocalTime();


        // Update Status Sensor
        if (ContainerState != _sensorState.Value)
            Log.Debug($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` changed state to `{LatestInfo.State}`");
        _sensorState.Value = ContainerState;

        // Update On/Off Switch
        if (!_switchStartStop.IsCommandProcessingActive)
            _switchStartStop.IsChecked = ContainerState is ContainerState.Restarting or ContainerState.Running;

        return true;
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
                Log.Information($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending stop command...");
                var result = await PortainerApi.StopContainerAsync(Endpoint.ID, ID).ConfigureAwait(false);
                Log.Information($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending stop command {(result ? "successful" : "failed!")}");
                SpinWait.SpinUntil(() => !result || ContainerState is ContainerState.Exited, ChangeStateCommandTimeout);
                return;
            }

            if (e.CommandValue && ContainerState is ContainerState.Exited)
            {
                Log.Information($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending start command...");
                var result = await PortainerApi.StartContainerAsync(Endpoint.ID, ID).ConfigureAwait(false);
                Log.Information($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending start command {(result ? "successful" : "failed!")}");
                SpinWait.SpinUntil(() => !result || ContainerState is ContainerState.Running, ChangeStateCommandTimeout);
                return;
            }

            if (e.CommandValue && ContainerState is ContainerState.Paused)
            {
                Log.Information($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending unpause command...");
                var result = await PortainerApi.UnpauseContainerAsync(Endpoint.ID, ID).ConfigureAwait(false);
                Log.Information($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending unpause command {(result ? "successful" : "failed!")}");
                SpinWait.SpinUntil(() => !result || ContainerState is ContainerState.Running, ChangeStateCommandTimeout);
            }
        }
        catch (OperationCanceledException) { }
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
                Log.Information($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending restart command...");
                var result = await PortainerApi.RestartContainerAsync(Endpoint.ID, ID).ConfigureAwait(false);
                Log.Information($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending restart command {(result ? "successful" : "failed!")}");
                SpinWait.SpinUntil(() => !result || ContainerState is ContainerState.Running, ChangeStateCommandTimeout);
            }
        }
        catch (OperationCanceledException) { }
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
                Log.Information($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending pause command...");
                var result = await PortainerApi.PauseContainerAsync(Endpoint.ID, ID).ConfigureAwait(false);
                Log.Information($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending pause command {(result ? "successful" : "failed!")}");
                SpinWait.SpinUntil(() => !result || ContainerState is ContainerState.Paused, ChangeStateCommandTimeout);
            }
        }
        catch (OperationCanceledException) { }
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

        _switchStartStop.SwitchCommandReceived -= OnSwitchCommandReceived;
        _buttonPause.ButtonCommandReceived -= OnPauseCommandReceived;
        _buttonRestart.ButtonCommandReceived -= OnRestartCommandReceived;

        _sendCommandLock.Dispose();
    }

    #endregion

    #region Private Methods

    #endregion
}