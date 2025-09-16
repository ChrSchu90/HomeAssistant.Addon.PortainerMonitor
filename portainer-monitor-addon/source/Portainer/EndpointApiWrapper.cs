namespace HomeAssistant.Addon.PortainerMonitor.Portainer;

using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;

/// <summary>
/// Docker endpoint API wrapper to unify <see cref="IPortainerApi"/> and <see cref="IAgentApi"/>
/// </summary>
internal class EndpointApiWrapper : IEndpointApi
{
    #region Private Fields

    private readonly IPortainerApi? _portainerApi;
    private readonly IAgentApi? _agentApi;
    private readonly int _endpointId;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="EndpointApiWrapper"/> for <see cref="IPortainerApi"/>.
    /// </summary>
    internal EndpointApiWrapper(IPortainerApi portainerApi, int endpointId)
    {
        _portainerApi = portainerApi;
        _endpointId = endpointId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EndpointApiWrapper"/> for <see cref="IAgentApi"/>.
    /// </summary>
    internal EndpointApiWrapper(IAgentApi agentApi)
    {
        _agentApi = agentApi;
    }

    #endregion

    #region Events

    #endregion

    #region Properties

    /// <inheritdoc />
    public string ID => _portainerApi?.ID ?? _agentApi!.ID;
    
    /// <inheritdoc />
    public string DisplayName => _portainerApi?.DisplayName ?? _agentApi!.DisplayName;
    
    #endregion

    #region Public Methods

    /// <inheritdoc />
    public Task<DockerVersionInfo?> GetDockerVersionInfoAsync()
    {
        return _portainerApi?.GetDockerVersionInfoAsync(_endpointId) ?? 
               _agentApi!.GetDockerVersionInfoAsync();
    }

    /// <inheritdoc />
    public Task<DockerContainer[]?> GetAllContainersAsync(bool all = true)
    {
        return _portainerApi?.GetAllContainersAsync(_endpointId, all) ?? 
               _agentApi!.GetAllContainersAsync(all);
    }

    /// <inheritdoc />
    public Task<ContainerStats?> GetContainerStatsAsync(string containerId)
    {
        return _portainerApi?.GetContainerStatsAsync(_endpointId, containerId) ?? 
               _agentApi!.GetContainerStatsAsync(containerId);
    }

    /// <inheritdoc />
    public IAsyncEnumerable<ContainerStats> GetContainerStatsStreamAsync(string containerId, CancellationToken ct = default)
    {
        return _portainerApi?.GetContainerStatsStreamAsync(_endpointId, containerId, ct) ?? 
               _agentApi!.GetContainerStatsStreamAsync(containerId, ct);
    }

    /// <inheritdoc />
    public Task<bool> StartContainerAsync(string containerId)
    {
        return _portainerApi?.StartContainerAsync(_endpointId, containerId) ?? 
               _agentApi!.StartContainerAsync(containerId);
    }

    /// <inheritdoc />
    public Task<bool> StopContainerAsync(string containerId)
    {
        return _portainerApi?.StopContainerAsync(_endpointId, containerId) ?? 
               _agentApi!.StopContainerAsync(containerId);
    }

    /// <inheritdoc />
    public Task<bool> PauseContainerAsync(string containerId)
    {
        return _portainerApi?.PauseContainerAsync(_endpointId, containerId) ?? 
               _agentApi!.PauseContainerAsync(containerId);
    }

    /// <inheritdoc />
    public Task<bool> UnpauseContainerAsync(string containerId)
    {
        return _portainerApi?.UnpauseContainerAsync(_endpointId, containerId) ?? 
               _agentApi!.UnpauseContainerAsync(containerId);
    }

    /// <inheritdoc />
    public Task<bool> RestartContainerAsync(string containerId, ushort killTimeout = 30)
    {
        return _portainerApi?.RestartContainerAsync(_endpointId, containerId, killTimeout) ?? 
               _agentApi!.RestartContainerAsync(containerId, killTimeout);
    }

    #endregion

    #region Private Methods

    #endregion
}