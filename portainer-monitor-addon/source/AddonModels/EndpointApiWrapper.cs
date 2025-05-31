namespace HomeAssistant.Addon.PortainerMonitor.AddonModels;

using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeAssistant.Addon.PortainerMonitor.Portainer;
using HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;

/// <summary>
/// Docker endpoint API wrapper to unify <see cref="IPortainerApi"/> and <see cref="IAgentApi"/>
/// </summary>
internal class EndpointApiWrapper : IEndpointApi
{
    #region Private Fields

    private readonly IPortainerApi? _portainerApi;
    private readonly IAgentApi? _agentApi;
    private readonly int? _endpointId;

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
        return _portainerApi?.GetDockerVersionInfoAsync(_endpointId!.Value) ?? 
               _agentApi!.GetDockerVersionInfoAsync();
    }

    /// <inheritdoc />
    public Task<DockerContainer[]?> GetAllContainersAsync(bool all = true)
    {
        return _portainerApi?.GetAllContainersAsync(_endpointId!.Value, all) ?? 
               _agentApi!.GetAllContainersAsync(all);
    }

    /// <inheritdoc />
    public Task<ContainerStats?> GetContainerStatsAsync(string containerId)
    {
        return _portainerApi?.GetContainerStatsAsync(_endpointId!.Value, containerId) ?? 
               _agentApi!.GetContainerStatsAsync(containerId);
    }

    /// <inheritdoc />
    public IAsyncEnumerable<ContainerStats> GetContainerStatsStreamAsync(string containerId, CancellationToken ct = default)
    {
        return _portainerApi?.GetContainerStatsStreamAsync(_endpointId!.Value, containerId, ct) ?? 
               _agentApi!.GetContainerStatsStreamAsync(containerId, ct);
    }

    /// <inheritdoc />
    public Task<bool> StartContainerAsync(string containerId)
    {
        return _portainerApi?.StartContainerAsync(_endpointId!.Value, containerId) ?? 
               _agentApi!.StartContainerAsync(containerId);
    }

    /// <inheritdoc />
    public Task<bool> StopContainerAsync(string containerId)
    {
        return _portainerApi?.StopContainerAsync(_endpointId!.Value, containerId) ?? 
               _agentApi!.StopContainerAsync(containerId);
    }

    /// <inheritdoc />
    public Task<bool> PauseContainerAsync(string containerId)
    {
        return _portainerApi?.PauseContainerAsync(_endpointId!.Value, containerId) ?? 
               _agentApi!.PauseContainerAsync(containerId);
    }

    /// <inheritdoc />
    public Task<bool> UnpauseContainerAsync(string containerId)
    {
        return _portainerApi?.UnpauseContainerAsync(_endpointId!.Value, containerId) ?? 
               _agentApi!.UnpauseContainerAsync(containerId);
    }

    /// <inheritdoc />
    public Task<bool> RestartContainerAsync(string containerId, ushort killTimeout = 30)
    {
        return _portainerApi?.RestartContainerAsync(_endpointId!.Value, containerId, killTimeout) ?? 
               _agentApi!.RestartContainerAsync(containerId, killTimeout);
    }

    #endregion

    #region Private Methods

    #endregion
}

/// <summary>
/// Unified Docker endpoint API wrapper for <see cref="IPortainerApi"/> and <see cref="IAgentApi"/>
/// </summary>
internal interface IEndpointApi
{
    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets the display name of the portainer endpoint.
    /// </summary>
    string DisplayName { get; }

    /// <summary>
    /// Gets the portainer endpoint ID.
    /// </summary>
    string ID { get; }

    #endregion

    #region Methods

    /// <summary>
    /// Gets the docker version information.
    /// </summary>
    /// <returns>The docker version information</returns>
    Task<DockerVersionInfo?> GetDockerVersionInfoAsync();

    /// <summary>
    /// Gets all containers.
    /// </summary>
    /// <param name="all">if set to <c>true</c> all containers, otherwise only running containers.</param>
    /// <returns> The containers or <c>null</c> </returns>
    Task<DockerContainer[]?> GetAllContainersAsync(bool all = true);

    /// <summary>
    /// Gets the container stats with resource usage information asynchronous.
    /// </summary>
    /// <param name="containerId">The container identifier.</param>
    /// <returns></returns>
    Task<ContainerStats?> GetContainerStatsAsync(string containerId);

    /// <summary>
    /// Gets the container stats with resource usage information as stream.
    /// </summary>
    /// <remarks>Make sure to handle thrown exceptions to trigger e.g. reconnects</remarks>
    /// <param name="containerId">The container identifier.</param>
    /// <param name="ct">The ct.</param>
    /// <returns>IAsyncEnumerable with the container stats</returns>
    IAsyncEnumerable<ContainerStats> GetContainerStatsStreamAsync(string containerId, CancellationToken ct = default);

    /// <summary>
    /// Starts a container.
    /// </summary>
    /// <param name="containerId">The container ID.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> StartContainerAsync(string containerId);

    /// <summary>
    /// Stops a container.
    /// </summary>
    /// <param name="containerId">The container ID.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> StopContainerAsync(string containerId);

    /// <summary>
    /// Pauses a container.
    /// </summary>
    /// <param name="containerId">The container ID.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> PauseContainerAsync(string containerId);

    /// <summary>
    /// Unpauses a container.
    /// </summary>
    /// <param name="containerId">The container ID.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> UnpauseContainerAsync(string containerId);

    /// <summary>
    /// Restarts a container.
    /// </summary>
    /// <param name="containerId">The container ID.</param>
    /// <param name="killTimeout">The kill timeout after the container will be killed in seconds.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> RestartContainerAsync(string containerId, ushort killTimeout = 30);

    #endregion
}