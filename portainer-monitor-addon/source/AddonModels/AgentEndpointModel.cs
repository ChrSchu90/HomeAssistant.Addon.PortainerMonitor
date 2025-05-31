namespace HomeAssistant.Addon.PortainerMonitor.AddonModels;

using System.Threading.Tasks;
using HomeAssistant.Addon.PortainerMonitor.Portainer;

/// <summary>
/// Endpoint model that represents an environment of a Portainer Agent
/// </summary>
internal class AgentEndpointModel : EndpointBase<AgentHostModel>
{
    #region Private Static Fields

    #endregion

    #region Private Fields

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="PortainerEndpointModel"/> class.
    /// </summary>
    internal AgentEndpointModel(AgentHostModel host, IEndpointApi endpointApi)
        : base(host, endpointApi.DisplayName, endpointApi.ID, endpointApi)
    {
    }

    #endregion

    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets the agent host of the endpoint.
    /// </summary>
    internal new AgentHostModel Host => Parent;

    /// <inheritdoc />
    internal override IConnectionConfig Config => Host.Config;

    #endregion

    #region Public Methods

    /// <inheritdoc />
    internal override async Task<bool> OnUpdateStatesAsync(bool force)
    {
        var agentVersion = await Host.AgentApi.GetAgentVersionAsync().ConfigureAwait(false);
        if (agentVersion == null) return false;

        Device.Version = agentVersion;
        Device.Model = "Portainer Agent";

        return await base.OnUpdateStatesAsync(force).ConfigureAwait(false);
    }

    #endregion

    #region Private Methods

    #endregion
}
