namespace HomeAssistant.Addon.PortainerMonitor.AddonModels;

using System;
using System.Threading.Tasks;
using HomeAssistant.Addon.PortainerMonitor.Mqtt;
using HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;
using HomeAssistant.Addon.PortainerMonitor.Portainer;

/// <summary>
/// Root model of Agent connection
/// </summary>
/// <seealso cref="ModelBase" />
internal class AgentHostModel : ModelBase
{

    #region Private Static Fields

    #endregion

    #region Private Fields

    private bool _deviceOutdated;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentHostModel" /> class.
    /// </summary>
    /// <param name="config">The configuration.</param>
    /// <param name="agentApi">The Portainer API.</param>
    /// <param name="mqttClient">The MQTT client.</param>
    /// <param name="addonPrefix">The addon entity ID prefix.</param>
    /// <param name="addonManufacturer">The device manufacturer.</param>
    internal AgentHostModel(IAgentConfig config, IAgentApi agentApi, IMqttClient mqttClient, string addonPrefix, string addonManufacturer)
        : base(mqttClient, new HaDevice(addonPrefix, agentApi.ID, agentApi.DisplayName, addonManufacturer), HaEntityBase.BuildID(addonPrefix, "agent"), null)
    {
        Config = config;
        AgentApi = agentApi;
        EndpointModel = new AgentEndpointModel(this, new EndpointApiWrapper(AgentApi));
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets the portainer API.
    /// </summary>
    internal IAgentApi AgentApi { get; }

    /// <summary>
    /// Gets the configuration.
    /// </summary>
    internal IAgentConfig Config { get; }

    /// <summary>
    /// Gets the endpoint model related to the agent.
    /// </summary>
    internal AgentEndpointModel EndpointModel { get; }

    /// <summary>
    /// Gets the Portainer version.
    /// </summary>
    internal Version? Version
    {
        get => Device.Version;
        private set
        {
            if (Device.Version?.Equals(value) == true) return;
            Device.Version = value;
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
    internal override async Task<bool> OnUpdateStatesAsync(bool force)
    {
        force = force || _deviceOutdated;

        var agentVersion = await AgentApi.GetAgentVersionAsync().ConfigureAwait(false);
        if(agentVersion == null) return false;

        Version = agentVersion;
        Edition = "Portainer Agent";
        _ = await EndpointModel.UpdateAsync(force).ConfigureAwait(false);
        _deviceOutdated = false;
        return true;
    }

    /// <inheritdoc />
    protected override void OnDispose(bool disposing)
    {
        base.OnDispose(disposing);
        if (!disposing) return;
        EndpointModel.Dispose();
    }

    #endregion

    #region Private Methods

    #endregion
}