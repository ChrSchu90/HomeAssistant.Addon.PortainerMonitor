namespace HomeAssistant.Addon.PortainerMonitor.AddonModels;

using System;
using System.Linq;
using System.Threading.Tasks;
using HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;
using HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;
using Serilog;

internal class DockerContainerModel : ModelBase<PortainerEndpointModel>
{
    #region Private Static Fields

    #endregion

    #region Private Fields

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
        _switchStartStop = CreateSwitchEntity("startstop_switch", Name);
        _switchStartStop.SwitchCommandReceived += OnSwitchCommandReceived;
        _switchStartStop.Icon = "mdi:docker";

        _buttonPause = CreateButtonEntity("pause_button", $"Pause {Name}");
        _buttonPause.ButtonCommandReceived += OnPauseCommandReceived;
        _buttonPause.Icon = "mdi:pause";

        _buttonRestart = CreateButtonEntity("restart_button", $"Restart {Name}");
        _buttonRestart.ButtonCommandReceived += OnRestartCommandReceived;
        _buttonRestart.Icon = "mdi:restart";

        _sensorState = CreateSensorEntity<ContainerState>(HaEntityBase.BuildID("status_sensor"), $"{Name} State");
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
    internal ContainerState ContainerState => _sensorState.Value;

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
    internal override Task OnUpdateStatesAsync(bool force, Version apiVersion)
    {
        // Update Status Sensor
        if (LatestInfo.State != _sensorState.Value)
            Log.Debug($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` changed state to `{LatestInfo.State}`");
        _sensorState.Value = LatestInfo.State;

        // Update On/Off Switch
        if (!_switchStartStop.IsCommandProcessingActive)
            _switchStartStop.IsChecked = LatestInfo.State is ContainerState.Restarting or ContainerState.Running;

        return Task.CompletedTask;
    }

    /// <summary>
    /// Getting called if the on/off switch receives a command from Home Assistant (toggle).
    /// </summary>
    /// <param name="e">The <see cref="SwitchCommandReceivedEventArgs" /> instance containing the event data.</param>
    protected virtual async Task OnSwitchCommandReceived(SwitchCommandReceivedEventArgs e)
    {
        if (!e.CommandValue && LatestInfo.State == ContainerState.Running)
        {
            Log.Debug($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending stop command...");
            var result = await PortainerApi.StopContainer(Endpoint.ID, ID).ConfigureAwait(false);
            Log.Debug($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending stop command {(result ? "successful" : "failed!")}");
            return;
        }

        if (e.CommandValue && LatestInfo.State == ContainerState.Exited)
        {
            Log.Debug($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending start command...");
            var result = await PortainerApi.StartContainer(Endpoint.ID, ID).ConfigureAwait(false);
            Log.Debug($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending start command {(result ? "successful" : "failed!")}");
            return;
        }

        if (e.CommandValue && LatestInfo.State == ContainerState.Paused)
        {
            Log.Debug($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending unpause command...");
            var result = await PortainerApi.UnpauseContainer(Endpoint.ID, ID).ConfigureAwait(false);
            Log.Debug($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending unpause command {(result ? "successful" : "failed!")}");
        }
    }

    /// <summary>
    /// Getting called if the restart button receives a command from Home Assistant (click).
    /// </summary>
    /// <param name="e">The <see cref="ButtonCommandReceivedEventArgs" /> instance containing the event data.</param>
    protected virtual async Task OnRestartCommandReceived(ButtonCommandReceivedEventArgs e)
    {
        if (LatestInfo.State == ContainerState.Running)
        {
            Log.Debug($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending restart command...");
            var result = await PortainerApi.RestartContainer(Endpoint.ID, ID).ConfigureAwait(false);
            Log.Debug($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending restart command {(result ? "successful" : "failed!")}");
        }
    }

    /// <summary>
    /// Getting called if the pause button receives a command from Home Assistant (click).
    /// </summary>
    /// <param name="e">The <see cref="ButtonCommandReceivedEventArgs" /> instance containing the event data.</param>
    protected virtual async Task OnPauseCommandReceived(ButtonCommandReceivedEventArgs e)
    {
        if (LatestInfo.State == ContainerState.Running)
        {
            Log.Debug($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending pause command...");
            var result = await PortainerApi.PauseContainer(Endpoint.ID, ID).ConfigureAwait(false);
            Log.Debug($"Container: `{Name}` of endpoint `{Endpoint.Name}` on host `{Endpoint.Host.Name}` sending pause command {(result ? "successful" : "failed!")}");
        }
    }

    /// <inheritdoc />
    protected override void OnDispose(bool disposing)
    {
        base.OnDispose(disposing);
        if (!disposing) return;
        _switchStartStop.SwitchCommandReceived -= OnSwitchCommandReceived;
        _buttonPause.ButtonCommandReceived -= OnPauseCommandReceived;
        _buttonRestart.ButtonCommandReceived -= OnRestartCommandReceived;
    }

    #endregion

    #region Private Methods

    #endregion
}