namespace HomeAssistant.Addon.PortainerMonitor.Portainer;

using HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;
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
    /// Gets the system version information.
    /// </summary>
    /// <returns>The version info or <c>null</c></returns>
    Task<SystemVersionResponse?> GetVersionAsync();

    /// <summary>
    /// Gets the portainer endpoints.
    /// </summary>
    /// <returns>The Portainer endpoints or <c>null</c></returns>
    Task<PortainerEndpoint[]?> GetEndpointsAsync();

    /// <summary>
    /// Gets all containers from endpoint.
    /// </summary>
    /// <param name="endpointId">The endpoint identifier.</param>
    /// <param name="all">if set to <c>true</c> all containers, otherwise only running containers.</param>
    /// <returns> The containers or <c>null</c> </returns>
    Task<DockerContainer[]?> GetAllContainersAsync(int endpointId, bool all = true);

    /// <summary>
    /// Starts a container.
    /// </summary>
    /// <param name="endpointId">The endpoint ID.</param>
    /// <param name="containerId">The container ID.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> StartContainer(int endpointId, string containerId);

    /// <summary>
    /// Stops a container.
    /// </summary>
    /// <param name="endpointId">The endpoint ID.</param>
    /// <param name="containerId">The container ID.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> StopContainer(int endpointId, string containerId);

    /// <summary>
    /// Pauses a container.
    /// </summary>
    /// <param name="endpointId">The endpoint ID.</param>
    /// <param name="containerId">The container ID.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> PauseContainer(int endpointId, string containerId);

    /// <summary>
    /// Unpauses a container.
    /// </summary>
    /// <param name="endpointId">The endpoint ID.</param>
    /// <param name="containerId">The container ID.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> UnpauseContainer(int endpointId, string containerId);

    /// <summary>
    /// Restarts a container.
    /// </summary>
    /// <param name="endpointId">The endpoint ID.</param>
    /// <param name="containerId">The container ID.</param>
    /// <param name="killTimeout">The kill timeout after the container will be killed in seconds.</param>
    /// <returns>If the command was send successfully</returns>
    Task<bool> RestartContainer(int endpointId, string containerId, ushort killTimeout = 30);

    #endregion
}