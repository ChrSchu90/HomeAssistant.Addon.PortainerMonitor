namespace HomeAssistant.Addon.PortainerMonitor.AddonModels;

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeAssistant.Addon.PortainerMonitor.Mqtt;
using HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;
using HomeAssistant.Addon.PortainerMonitor.Portainer;
using HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;
using Serilog;

/// <summary>
/// Root model Portainer Host
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
    /// <param name="portainerApi">The Portainer API.</param>
    /// <param name="mqttClient">The MQTT client.</param>
    /// <param name="device">The root device.</param>
    internal PortainerHostModel(IPortainerApi portainerApi, IMqttClient mqttClient, HaDevice device)
        : base(portainerApi, mqttClient, device, device.Identifier, null)
    {
        _updateItem = CreateUpdateEntity("update", "Update");
        _updateItem.PictureUrl = "https://portainer-io-assets.sfo2.cdn.digitaloceanspaces.com/logos/portainer.png";

        _sensorVersion = CreateSensorEntity<string>("version_sensor", "Version");
        _sensorVersion.PictureUrl = "https://portainer-io-assets.sfo2.cdn.digitaloceanspaces.com/logos/portainer.png";
        _sensorVersion.StateClass = null;

        _sensorAmountContainers = CreateSensorEntity<int>("amntcontainers_sensor", "Containers");
        _sensorAmountContainers.Icon = "mdi:docker";

        _sensorRunningCnt = CreateSensorEntity<int>("runningcnt_sensor", "Running");
        _sensorRunningCnt.Icon = "mdi:play";

        _sensorPausedCnt = CreateSensorEntity<int>("pausedcnt_sensor", "Paused");
        _sensorPausedCnt.Icon = "mdi:pause";

        _sensorStoppedCnt = CreateSensorEntity<int>("stoppedcnt_sensor", "Stopped");
        _sensorStoppedCnt.Icon = "mdi:stop";
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets the display name of the Host.
    /// </summary>
    internal string Name => PortainerApi.DisplayName;

    /// <summary>
    /// Gets the Portainer version.
    /// </summary>
    internal Version Version
    {
        get => Device.Version;
        private set
        {
            if (Device.Version.Equals(value)) return;
            Device.Version = value;
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
    internal override async Task<bool> OnUpdateStatesAsync(bool force, Version apiVersion)
    {
        // Do not use the apiVersion! We get this info inside the UpdateVersionInfo
        force = force || _deviceOutdated;

        var versionInfo = await PortainerApi.GetVersionAsync().ConfigureAwait(false);
        if (versionInfo == null)
            return false;

        var successful = await UpdateVersionInfo(versionInfo).ConfigureAwait(false);
        if (!successful) 
            return false;

        var endpoints = await PortainerApi.GetEndpointsAsync().ConfigureAwait(false);
        if (endpoints == null)
            return false;

        successful = await UpdateEndpoints(endpoints, force, Version).ConfigureAwait(false);
        if (!successful)
            return false;

        _sensorAmountContainers.Value = _endpoints.Values.Sum(ep => ep.Containers.Count());
        _sensorRunningCnt.Value = _endpoints.Values.Sum(ep => ep.Containers.Count(c => c.ContainerState is ContainerState.Running));
        _sensorPausedCnt.Value = _endpoints.Values.Sum(ep => ep.Containers.Count(c => c.ContainerState is ContainerState.Paused));
        _sensorStoppedCnt.Value = _endpoints.Values.Sum(ep => ep.Containers.Count(c => c.ContainerState is ContainerState.Exited));

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
        _updateItem.LatestVersion = Version.TryParse(versionInfo.LatestVersion, out var latestVersion) ? latestVersion : Version;
        _updateItem.ReleaseUrl = $"https://github.com/portainer/portainer/releases/tag/{_updateItem.LatestVersion}";
        _updateItem.IsUpdateAvailable = versionInfo.UpdateAvailable;

        return Task.FromResult(Version > HaDevice.DefaultDeviceVersion);
    }

    private async Task<bool> UpdateEndpoints(IReadOnlyCollection<PortainerEndpoint> endpoints, bool force, Version apiVersion)
    {
        var successful = true;
        foreach (var ep in endpoints)
        {
            if (ep.Id == null) continue;

            var key = $"{ep.Name} ({ep.Id})";
            if (_endpoints.TryGetValue(key, out var epModel))
            {
                epModel.LatestInfo = ep;
                successful &= await epModel.UpdateAsync(force, apiVersion).ConfigureAwait(false);
                continue;
            }

            epModel = new PortainerEndpointModel(this, ep);
            Log.Information($"Host: Endpoint `{epModel.Name}` on Host `{Name}` became available and has been added");
            _endpoints.TryAdd(key, epModel);
            successful &= await epModel.UpdateAsync(true, apiVersion).ConfigureAwait(false);
        }

        var removedEndpoints = _endpoints.Where(p => endpoints.All(a => a.Id != p.Value.ID && a.Name != p.Value.Name)).Select(p => p.Key);
        foreach (var epKey in removedEndpoints)
        {
            if (!_endpoints.TryRemove(epKey, out var epm)) continue;
            Log.Information($"Host: Endpoint `{epm.Name}` Host `{Name}` became unavailable and has been removed");
            epm.Dispose();
        }

        return successful;
    }

    #endregion
}