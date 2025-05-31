namespace HomeAssistant.Addon.PortainerMonitor.Portainer;

using HomeAssistant.Addon.PortainerMonitor.AddonModels;
using System;
using System.Threading.Tasks;

/// <summary>
/// Portainer Agent API Access see:
/// </summary>
internal interface IAgentApi : IEndpointApi
{
    #region Events

    #endregion

    #region Properties

    #endregion

    #region Methods

    /// <summary>
    /// Gets the agent version asynchronous.
    /// </summary>
    /// <returns>The version or <c>null</c> if request failed</returns>
    public Task<Version?> GetAgentVersionAsync();

    #endregion
}