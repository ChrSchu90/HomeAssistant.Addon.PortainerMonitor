namespace HomeAssistant.Addon.PortainerMonitor.AddonModels;

using HomeAssistant.Addon.PortainerMonitor.Mqtt;
using HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;
using HomeAssistant.Addon.PortainerMonitor.Portainer;
using HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;
using Serilog;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Endpoint model base that represents an environment
/// </summary>
internal abstract class EndpointBase<T> : ModelBase<T> where T : ModelBase
{
    #region Private Static Fields

    #endregion

    #region Private Fields

    private readonly ConcurrentDictionary<string, DockerContainerModel<T>> _containers = new();
    private readonly HaSensor<string> _sensorDockerVersion;
    private readonly HaSensor<int> _sensorAmountContainers;
    private readonly HaSensor<int> _sensorRunningCnt;
    private readonly HaSensor<int> _sensorPausedCnt;
    private readonly HaSensor<int> _sensorStoppedCnt;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ModelBase{T}" /> class.
    /// </summary>
    /// <param name="parent">The parent.</param>
    /// <param name="displayName">The display name.</param>
    /// <param name="nameID">The MQTT identifier of this model without prefix.</param>
    /// <param name="endpointApi">The endpoint API.</param>
    protected EndpointBase(T parent, string displayName, string nameID, IEndpointApi endpointApi)
        : base(parent, nameID)
    {
        Name = displayName;
        EndpointApi = endpointApi;

        Availability = new() { Topic = string.Format(AvailabilityTopic, MqttIdPrefix) };

        var endpointAvailabilities = CreateAvailabilities(Parent.Availability, Availability);

        _sensorDockerVersion = CreateSensorEntity<string>("dockerversion_sensor", $"{Name} Docker Version");
        _sensorDockerVersion.Availabilities = endpointAvailabilities;
        _sensorDockerVersion.AvailabilityMode = HaAvailability.ModeAll;
        _sensorDockerVersion.Icon = "mdi:information-outline";
        _sensorDockerVersion.StateClass = null;

        _sensorAmountContainers = CreateSensorEntity<int>("amntcontainers_sensor", $"{Name} Containers");
        _sensorAmountContainers.Availabilities = endpointAvailabilities;
        _sensorAmountContainers.AvailabilityMode = HaAvailability.ModeAll;
        _sensorAmountContainers.Icon = "mdi:docker";

        _sensorRunningCnt = CreateSensorEntity<int>("runningcnt_sensor", $"{Name} Running");
        _sensorRunningCnt.Availabilities = endpointAvailabilities;
        _sensorRunningCnt.AvailabilityMode = HaAvailability.ModeAll;
        _sensorRunningCnt.Icon = "mdi:play";

        _sensorPausedCnt = CreateSensorEntity<int>("pausedcnt_sensor", $"{Name} Paused");
        _sensorPausedCnt.Availabilities = endpointAvailabilities;
        _sensorPausedCnt.AvailabilityMode = HaAvailability.ModeAll;
        _sensorPausedCnt.Icon = "mdi:pause";

        _sensorStoppedCnt = CreateSensorEntity<int>("stoppedcnt_sensor", $"{Name} Stopped");
        _sensorStoppedCnt.Availabilities = endpointAvailabilities;
        _sensorStoppedCnt.AvailabilityMode = HaAvailability.ModeAll;
        _sensorStoppedCnt.Icon = "mdi:stop";
    }

    #endregion

    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets the endpoint name.
    /// </summary>
    internal string Name { get; }

    /// <summary>
    /// Gets the endpoint API.
    /// </summary>
    internal IEndpointApi EndpointApi { get; }

    /// <summary>
    /// Gets the configuration.
    /// </summary>
    internal abstract IConnectionConfig Config { get; }

    /// <summary>
    /// Gets the endpoint host.
    /// </summary>
    internal ModelBase Host => Parent;

    /// <summary>
    /// Gets the containers.
    /// </summary>
    internal IEnumerable<DockerContainerModel<T>> Containers => _containers.Values;

    #endregion

    #region Public Methods

    /// <inheritdoc />
    internal override async Task<bool> OnUpdateStatesAsync(bool force)
    {
        var containers = await EndpointApi.GetAllContainersAsync().ConfigureAwait(false);
        var dockerVerInf = await EndpointApi.GetDockerVersionInfoAsync().ConfigureAwait(false);
        if (containers == null || dockerVerInf == null) return false;

        _sensorDockerVersion.Value = dockerVerInf.Version.ToString();

        var successful = await UpdateContainersAsync(containers, force).ConfigureAwait(false);
        if (successful)
        {
            _sensorAmountContainers.Value = _containers.Count;
            _sensorRunningCnt.Value = _containers.Values.Count(c => c.ContainerState is ContainerState.Running);
            _sensorPausedCnt.Value = _containers.Values.Count(c => c.ContainerState is ContainerState.Paused);
            _sensorStoppedCnt.Value = _containers.Values.Count(c => c.ContainerState is ContainerState.Exited);
        }

        return true;
    }

    /// <summary>
    /// Updates the containers asynchronous.
    /// </summary>
    /// <param name="containers">The containers.</param>
    /// <param name="force">if set to <c>true</c> [force].</param>
    /// <returns>If update was successful</returns>
    protected virtual async Task<bool> UpdateContainersAsync(IReadOnlyCollection<DockerContainer> containers, bool force)
    {
        var removeContainers = _containers.Keys.Where(k => containers.All(a => a.Id != k));
        foreach (var epKey in removeContainers)
        {
            if (!_containers.TryRemove(epKey, out var ctModel)) continue;
            Log.Information($"Endpoint: Container `{Config.Id}.{Name}.{ctModel.Name}` became unavailable and has been removed");
            ctModel.Dispose();
        }

        foreach (var ct in containers)
        {
            if (_containers.TryGetValue(ct.Id, out var ctModel))
            {
                ctModel.LatestInfo = ct;
                await ctModel.UpdateAsync(force).ConfigureAwait(false);
                continue;
            }

            // Check if CT with same name exists, in some edge cases the new container is deployed
            // before the old one has been removed, which can result in dead HA-entities
            var ctName = ct.Names.FirstOrDefault(n => !string.IsNullOrWhiteSpace(n))?.Trim('/') ?? ct.Id;
            if (_containers.Values.Any(c => string.Equals(c.Name, ctName, StringComparison.OrdinalIgnoreCase)))
            {
                Log.Information($"Endpoint: Skipped adding container `{Config.Id}.{Name}.{ctName}` because another container with same name already exists");
                continue;
            }

            ctModel = new DockerContainerModel<T>(this, ct, ctName);
            Log.Information($"Endpoint: Container `{Config.Id}.{Name}.{ctModel.Name}` became available and has been added");
            _containers.TryAdd(ctModel.ID, ctModel);
            await ctModel.UpdateAsync(force).ConfigureAwait(false);
        }

        return true;
    }

    /// <inheritdoc />
    protected override void OnDispose(bool disposing)
    {
        base.OnDispose(disposing);
        if (!disposing) return;
        foreach (var containerModel in _containers.Values) { containerModel.Dispose(); }
        _containers.Clear();
    }

    #endregion

    #region Private Methods

    #endregion
}