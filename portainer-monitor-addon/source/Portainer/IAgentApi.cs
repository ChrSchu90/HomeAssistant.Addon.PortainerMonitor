namespace HomeAssistant.Addon.PortainerMonitor.Portainer;

using HomeAssistant.Addon.PortainerMonitor.AddonModels;
using HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Portainer Agent API Access see:
/// </summary>
internal interface IAgentApi
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
    /// Gets the agent version asynchronous.
    /// </summary>
    /// <returns>The version or <c>null</c> if request failed</returns>
    public Task<Version?> GetAgentVersionAsync();

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