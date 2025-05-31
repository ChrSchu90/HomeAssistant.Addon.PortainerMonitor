namespace HomeAssistant.Addon.PortainerMonitor.AddonModels;

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeAssistant.Addon.PortainerMonitor.Mqtt;
using HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;
using HomeAssistant.Addon.PortainerMonitor.Portainer;
using HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;
using Serilog;

/// <summary>
/// Root model of Portainer connection
/// </summary>
/// <seealso cref="ModelBase" />
internal class PortainerHostModel : ModelBase
{
    #region Private Static Fields

    #endregion

    #region Private Fields

    private readonly ConcurrentDictionary<string, PortainerEndpointModel> _endpoints = new();
    private readonly HaSensor<string> _sensorVersion;
    private readonly HaSensor<int> _sensorAmountContainers;
    private readonly HaSensor<int> _sensorRunningCnt;
    private readonly HaSensor<int> _sensorPausedCnt;
    private readonly HaSensor<int> _sensorStoppedCnt;
    private readonly HaUpdate _updateItem;
    private bool _deviceOutdated = true;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="PortainerHostModel" /> class.
    /// </summary>
    /// <param name="config">The configuration.</param>
    /// <param name="portainerApi">The Portainer API.</param>
    /// <param name="mqttClient">The MQTT client.</param>
    /// <param name="addonPrefix">The addon entity ID prefix.</param>
    /// <param name="addonManufacturer">The device manufacturer.</param>
    internal PortainerHostModel(IPortainerConfig config, IPortainerApi portainerApi, IMqttClient mqttClient, string addonPrefix, string addonManufacturer)
        : base(mqttClient, new HaDevice(addonPrefix, portainerApi.ID, portainerApi.DisplayName, addonManufacturer), portainerApi.ID, addonPrefix)
    {
        Config = config;
        PortainerApi = portainerApi;
        Availability = new() { Topic = string.Format(AvailabilityTopic, MqttIdPrefix) };

        _updateItem = CreateUpdateEntity("update", "Update");
        _updateItem.Availabilities = [Availability];
        _updateItem.AvailabilityMode = HaAvailability.ModeAll;
        _updateItem.PictureUrl = "https://portainer-io-assets.sfo2.cdn.digitaloceanspaces.com/logos/portainer.png";

        _sensorVersion = CreateSensorEntity<string>("version_sensor", "Version");
        _sensorVersion.Availabilities = [Availability];
        _sensorVersion.AvailabilityMode = HaAvailability.ModeAll;
        _sensorVersion.PictureUrl = "https://portainer-io-assets.sfo2.cdn.digitaloceanspaces.com/logos/portainer.png";
        _sensorVersion.StateClass = null;

        _sensorAmountContainers = CreateSensorEntity<int>("amntcontainers_sensor", "Containers");
        _sensorAmountContainers.Availabilities = [Availability];
        _sensorAmountContainers.AvailabilityMode = HaAvailability.ModeAll;
        _sensorAmountContainers.Icon = "mdi:docker";
        _sensorAmountContainers.SuggestedDisplayPrecision = 0;

        _sensorRunningCnt = CreateSensorEntity<int>("runningcnt_sensor", "Running");
        _sensorRunningCnt.Availabilities = [Availability];
        _sensorRunningCnt.AvailabilityMode = HaAvailability.ModeAll;
        _sensorRunningCnt.Icon = "mdi:play";
        _sensorRunningCnt.SuggestedDisplayPrecision = 0;

        _sensorPausedCnt = CreateSensorEntity<int>("pausedcnt_sensor", "Paused");
        _sensorPausedCnt.Availabilities = [Availability];
        _sensorPausedCnt.AvailabilityMode = HaAvailability.ModeAll;
        _sensorPausedCnt.Icon = "mdi:pause";
        _sensorPausedCnt.SuggestedDisplayPrecision = 0;

        _sensorStoppedCnt = CreateSensorEntity<int>("stoppedcnt_sensor", "Stopped");
        _sensorStoppedCnt.Availabilities = [Availability];
        _sensorStoppedCnt.AvailabilityMode = HaAvailability.ModeAll;
        _sensorStoppedCnt.Icon = "mdi:stop";
        _sensorStoppedCnt.SuggestedDisplayPrecision = 0;
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets the portainer API.
    /// </summary>
    internal IPortainerApi PortainerApi { get; }

    /// <summary>
    /// Gets the configuration.
    /// </summary>
    internal IPortainerConfig Config { get; }

    /// <summary>
    /// Gets the Portainer version.
    /// </summary>
    internal Version? Version
    {
        get => Device.Version;
        private set
        {
            if (Device.Version?.Equals(value) == true) return;
            Device.Version = value;
            if(value != null)
                _sensorVersion.Value = value.ToString(3);
            _deviceOutdated = true;
        }
    }

    /// <summary>
    /// Gets the Portainer edition.
    /// </summary>
    internal string Edition
    {
        get => Device.Model;
        private set
        {
            if (Device.Model == value) return;
            Device.Model = value;
            _deviceOutdated = true;
        }
    }

    #endregion

    #region Public Methods

    /// <inheritdoc />
    internal override async Task<bool> OnUpdateStatesAsync(bool force)
    {
        force = force || _deviceOutdated;

        var versionInfo = await PortainerApi.GetPortainerVersionInfoAsync().ConfigureAwait(false);
        if (versionInfo == null) return false;

        var successful = await UpdateVersionInfo(versionInfo).ConfigureAwait(false);
        if (!successful)return false;

        var endpoints = await PortainerApi.GetEndpointsAsync().ConfigureAwait(false);
        if (endpoints == null) return false;

        successful = await UpdateEndpoints(endpoints, force).ConfigureAwait(false);
        if (successful)
        {
            _sensorAmountContainers.Value = _endpoints.Values.Sum(ep => ep.Containers.Count());
            _sensorRunningCnt.Value = _endpoints.Values.Sum(ep => ep.Containers.Count(c => c.ContainerState is ContainerState.Running));
            _sensorPausedCnt.Value = _endpoints.Values.Sum(ep => ep.Containers.Count(c => c.ContainerState is ContainerState.Paused));
            _sensorStoppedCnt.Value = _endpoints.Values.Sum(ep => ep.Containers.Count(c => c.ContainerState is ContainerState.Exited));
        }

        _deviceOutdated = false;
        return true;
    }

    /// <inheritdoc />
    protected override void OnDispose(bool disposing)
    {
        base.OnDispose(disposing);
        if (!disposing) return;
        foreach (var endpointModel in _endpoints.Values) { endpointModel.Dispose(); }
        _endpoints.Clear();
    }

    #endregion

    #region Private Methods

    private Task<bool> UpdateVersionInfo(SystemVersionResponse versionInfo)
    {
        Version = versionInfo.ServerVersion;
        Edition = $"Portainer {versionInfo.ServerEdition}";

        // Update available check
        _updateItem.Title = Edition;
        _updateItem.CurrentVersion = Version;
        if(_updateItem.LatestVersion == null || _updateItem.LatestVersion < _updateItem.CurrentVersion || versionInfo.UpdateAvailable == true)
            _updateItem.LatestVersion = Version.TryParse(versionInfo.LatestVersion, out var latestVersion) ? latestVersion : _updateItem.CurrentVersion;
        _updateItem.ReleaseUrl = $"https://github.com/portainer/portainer/releases/tag/{_updateItem.LatestVersion}";

        return Task.FromResult(Version > HaDevice.DefaultDeviceVersion);
    }

    private async Task<bool> UpdateEndpoints(IReadOnlyCollection<PortainerEndpoint> endpoints, bool force)
    {
        var removedEndpoints = _endpoints.Where(p => endpoints.All(a => a.Id != p.Value.ID && a.Name != p.Value.Name)).Select(p => p.Key);
        var removed = false;
        foreach (var epKey in removedEndpoints)
        {
            if (!_endpoints.TryRemove(epKey, out var epModel)) continue;
            Log.Information($"Host: Endpoint `{Config.Id}.{epModel.Name}` became unavailable and has been removed");
            epModel.Dispose();
            removed = true;
        }

        foreach (var ep in endpoints)
        {
            var key = $"{ep.Name} ({ep.Id})";
            if (_endpoints.TryGetValue(key, out var epModel))
            {
                await epModel.UpdateAsync(force).ConfigureAwait(false);
                continue;
            }

            if (removed)
            {
                // Wait after removal due to too fast remove+add that could lead into dead HA entries
                removed = false;
                await Task.Delay(1000).ConfigureAwait(false);
            }

            epModel = new PortainerEndpointModel(this, ep, new EndpointApiWrapper(PortainerApi, ep.Id));
            Log.Information($"Host: Endpoint `{Config.Id}.{epModel.Name}` became available and has been added");
            _endpoints.TryAdd(key, epModel);
            await epModel.UpdateAsync(force).ConfigureAwait(false);
        }

        return true;
    }

    #endregion
}