namespace HomeAssistant.Addon.PortainerMonitor.Portainer;

using HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Portainer API Access see:
/// <see href="https://app.swaggerhub.com/apis/portainer/portainer-ce/2.27.1#/system/systemVersion"/>
/// </summary>
internal interface IPortainerApi
{
    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets the display name of the portainer instance.
    /// </summary>
    string DisplayName { get; }

    /// <summary>
    /// Gets the portainer instance ID.
    /// </summary>
    string ID { get; }

    #endregion

    #region Methods
    
    /// <summary>
    /// Gets the portainer system version information.
    /// </summary>
    /// <returns>The version info or <c>null</c></returns>
    Task<SystemVersionResponse?> GetPortainerVersionInfoAsync();

    /// <summary>
    /// Gets the portainer endpoints.
    /// </summary>
    /// <returns>The Portainer endpoints or <c>null</c></returns>
    Task<PortainerEndpoint[]?> GetEndpointsAsync();

    /// <summary>
    /// Gets the docker version information.
    /// </summary>
    /// <param name="endpointId">The endpoint identifier.</param>
    /// <returns>The docker version information</returns>
    Task<DockerVersionInfo?> GetDockerVersionInfoAsync(int endpointId);

    /// <summary>
    /// Gets all containers from endpoint.
    /// </summary>
    /// <param name="endpointId">The endpoint identifier.</param>
    /// <param name="all">if set to <c>true</c> all containers, otherwise only running containers.</param>
    /// <returns> The containers or <c>null</c> </returns>
    Task<DockerContainer[]?> GetAllContainersAsync(int endpointId, bool all = true);

    /// <summary>
    /// Gets the container stats with resource usage information.
    /// </summary>
    /// <remarks>To receive continuous updates use <see cref="GetContainerStatsStreamAsync"/> due to its better performance</remarks>
    /// <param name="endpointId">The endpoint identifier.</param>
    /// <param name="containerId">The container identifier.</param>
    /// <returns>The container stats</returns>
    Task<ContainerStats?> GetContainerStatsAsync(int endpointId, string containerId);

    /// <summary>
    /// Gets the container stats with resource usage information as stream.
    /// </summary>
    /// <remarks>Make sure to handle thrown exceptions to trigger e.g. reconnects</remarks>
    /// <param name="endpointId">The endpoint identifier.</param>
    /// <param name="containerId">The container identifier.</param>
    /// <param name="ct">The ct.</param>
    /// <returns>IAsyncEnumerable with the container stats</returns>
    IAsyncEnumerable<ContainerStats> GetContainerStatsStreamAsync(int endpointId, string containerId, CancellationToken ct = default);

    /// <summary>
    /// Starts a container.
    /// </summary>
    /// <param name="endpointId">The endpoint ID.</param>
    /// <param name="containerId">The container ID.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> StartContainerAsync(int endpointId, string containerId);

    /// <summary>
    /// Stops a container.
    /// </summary>
    /// <param name="endpointId">The endpoint ID.</param>
    /// <param name="containerId">The container ID.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> StopContainerAsync(int endpointId, string containerId);

    /// <summary>
    /// Pauses a container.
    /// </summary>
    /// <param name="endpointId">The endpoint ID.</param>
    /// <param name="containerId">The container ID.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> PauseContainerAsync(int endpointId, string containerId);

    /// <summary>
    /// Unpauses a container.
    /// </summary>
    /// <param name="endpointId">The endpoint ID.</param>
    /// <param name="containerId">The container ID.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> UnpauseContainerAsync(int endpointId, string containerId);

    /// <summary>
    /// Restarts a container.
    /// </summary>
    /// <param name="endpointId">The endpoint ID.</param>
    /// <param name="containerId">The container ID.</param>
    /// <param name="killTimeout">The kill timeout after the container will be killed in seconds.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> RestartContainerAsync(int endpointId, string containerId, ushort killTimeout = 30);

    #endregion
}