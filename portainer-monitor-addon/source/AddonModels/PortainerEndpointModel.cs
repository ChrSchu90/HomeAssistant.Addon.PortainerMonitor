namespace HomeAssistant.Addon.PortainerMonitor.AddonModels;

using HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;
using HomeAssistant.Addon.PortainerMonitor.Portainer;

/// <summary>
/// Endpoint model that represents an environment inside the Portainer instance
/// </summary>
internal class PortainerEndpointModel : EndpointBase<PortainerHostModel>
{
    #region Private Static Fields

    #endregion

    #region Private Fields

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="PortainerEndpointModel"/> class.
    /// </summary>
    internal PortainerEndpointModel(PortainerHostModel host, PortainerEndpoint endpoint, IEndpointApi endpointApi)
        : base(host, endpoint.Name, endpoint.Name, endpointApi)
    {
        ID = endpoint.Id;
    }

    #endregion

    #region Events

    #endregion

    #region Properties
    
    /// <summary>
    /// Gets the portainer host of the endpoint.
    /// </summary>
    internal new PortainerHostModel Host => Parent;

    /// <inheritdoc />
    internal override IConnectionConfig Config => Host.Config;

    /// <inheritdoc />
    internal override string EndpointFullName => $"{Config.Id}.{NameID}";

    /// <summary>
    /// Gets the endpoint ID.
    /// </summary>
    internal int ID { get; }

    #endregion

    #region Public Methods

    #endregion

    #region Private Methods

    #endregion
}
