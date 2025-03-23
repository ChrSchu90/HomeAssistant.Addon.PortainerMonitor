namespace HomeAssistant.Addon.PortainerMonitor.AddonModels;

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;
using Serilog;

/// <summary>
/// Endpoint model that represents an environment inside the Portainer instance
/// </summary>
internal class PortainerEndpointModel : ModelBase<PortainerHostModel>
{
    #region Private Static Fields

    #endregion

    #region Private Fields

    private readonly ConcurrentDictionary<string, DockerContainerModel> _containers = new();
    private readonly PortainerEndpoint _portainerEndpoint;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="PortainerEndpointModel"/> class.
    /// </summary>
    internal PortainerEndpointModel(PortainerHostModel host, PortainerEndpoint endpoint)
        : base(host, endpoint.Name)
    {
        _portainerEndpoint = endpoint;
    }

    #endregion

    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets the host of the endpoint.
    /// </summary>
    internal PortainerHostModel Host => Parent;

    /// <summary>
    /// Gets the endpoint name.
    /// </summary>
    internal string Name => _portainerEndpoint.Name;

    /// <summary>
    /// Gets the endpoint ID.
    /// </summary>
    internal int ID => _portainerEndpoint.Id!.Value;

    /// <summary>
    /// Gets the containers.
    /// </summary>
    internal IEnumerable<DockerContainerModel> Containers => _containers.Values;

    #endregion

    #region Public Methods

    /// <inheritdoc />
    internal override Task OnUpdateStatesAsync(bool force, Version apiVersion)
    {
        return UpdateContainersAsync(force, apiVersion);
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

    private async Task UpdateContainersAsync(bool force, Version apiVersion)
    {
        var containers = await PortainerApi.GetAllContainersAsync(ID).ConfigureAwait(false) ?? Array.Empty<DockerContainer>();
        foreach (var ct in containers)
        {
            if (_containers.TryGetValue(ct.Id, out var ctModel))
            {
                ctModel.LatestInfo = ct;
                await ctModel.UpdateAsync(true, apiVersion).ConfigureAwait(false);
                continue;
            }

            ctModel = new DockerContainerModel(this, ct);
            Log.Information($"Endpoint: Container `{ctModel.Name}` on Host `{Host.Name}` Endpoint `{Name}` became available and has been added");
            _containers.TryAdd(ctModel.ID, ctModel);
            await ctModel.UpdateAsync(force, apiVersion).ConfigureAwait(false);
        }

        var removeContainers = _containers.Keys.Where(k => containers.All(a => a.Id != k));
        foreach (var epKey in removeContainers)
        {
            if (!_containers.TryRemove(epKey, out var ct)) continue;
            Log.Information($"Endpoint: Container `{ct.Name}` on Host `{Host.Name}` at Endpoint `{Name}` became unavailable and has been removed");
            ct.Dispose();
        }
    }

    #endregion
}

