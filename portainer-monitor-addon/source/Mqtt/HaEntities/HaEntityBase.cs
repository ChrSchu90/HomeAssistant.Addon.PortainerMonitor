namespace HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;

using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/// <summary>
/// Home assistant MQTT Entity base
/// </summary>
internal abstract class HaEntityBase : IDisposable
{
    #region Private Static Fields

    private static readonly Regex _allowedEntityIdRegex = new("[^A-Za-z0-9_]");

    #endregion

    #region Private Fields

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="HaEntityBase" /> class.
    /// </summary>
    /// <param name="id">The full qualified entity id (e.g. abc_def_ghi_jkl).</param>
    /// <param name="displayName">The display name (e.g. Outdoor Temperature).</param>
    /// <param name="device">The root device.</param>
    /// <param name="mqttClient">The MQTT client.</param>
    protected HaEntityBase(string id, string displayName, HaDevice device, IMqttClient mqttClient)
    {
        Device = device;
        DisplayName = displayName;
        MqttClient = mqttClient;
        ID = id;

        MqttClient.ConnectionStateChanged += OnMqttConnectionStateChanged;
        AvailabilityTopic = device.AvailabilityTopic;
    }

    #endregion

    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the parent device.
    /// </summary>
    [JsonPropertyName("device")]
    public HaDevice Device { get; set; }

    /// <summary>
    /// Gets or sets the entity display name.
    /// </summary>
    [JsonPropertyName("name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets the identifier.
    /// </summary>
    [JsonPropertyName("unique_id")]
    public string ID { get; set; }

    /// <summary>
    /// Gets or sets the entity platform.
    /// </summary>
    [JsonPropertyName("platform")]
    public string Platform { get; set; } = "mqtt";

    /// <summary>
    /// Gets or sets the MQTT topic subscribed to receive availability (online/offline) updates. Must not be used together with <see cref="Availability"/>.
    /// </summary>
    [JsonPropertyName("availability_topic"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? AvailabilityTopic { get; set; }

    /// <summary>
    /// Defines a template to extract device’s availability from the availability_topic.
    /// To determine the devices availability result of this template will be compared to payload_available and payload_not_available.
    /// </summary>
    [JsonPropertyName("availability_template "), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? AvailabilityTemplate { get; set; }

    /// <summary>
    /// When availability is configured, this controls the conditions needed to set the entity to available.
    /// Valid entries are all, any, and latest. If set to all, payload_available must be received on all configured availability topics before the entity is marked as online.
    /// If set to any, payload_available must be received on at least one configured availability topic before the entity is marked as online. If set to latest,
    /// the last payload_available or payload_not_available received on any configured availability topic controls the availability.
    /// </summary>
    [JsonPropertyName("availability_mode "), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? AvailabilityMode { get; set; }

    /// <summary>
    /// Gets or sets the entity configuration topic to notify HA about the existence.
    /// </summary>
    [JsonIgnore]
    public string? ConfigTopic { get; set; }

    /// <summary>
    /// Gets or sets the state topic of the entity.
    /// </summary>
    [JsonPropertyName("state_topic"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StateTopic { get; set; }

    /// <summary>
    /// Gets or sets the command topic of the entity.
    /// </summary>
    [JsonPropertyName("command_topic"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CommandTopic { get; set; }

    /// <summary>
    /// Gets or sets the entity icon.
    /// </summary>
    /// <remarks>mdi:{icon name} <see href="https://pictogrammers.com/library/mdi/"/> (e.g. <c>mdi:air-conditioner</c>)</remarks>
    [JsonPropertyName("icon"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Icon { get; set; }

    /// <summary>
    /// Gets or sets the entity picture URL.
    /// </summary>
    [JsonPropertyName("entity_picture"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PictureUrl { get; set; }

    /// <summary>
    /// Gets or sets the entity device class.
    /// </summary>
    /// <remarks>See <see cref="HaDeviceClass"/></remarks>
    [JsonPropertyName("device_class"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DeviceClass { get; set; }
    
    /// <summary>
    /// Gets or sets the availability topic.
    /// </summary>
    [JsonPropertyName("availability"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Availability[]? Availability { get; set; }

    /// <summary>
    /// If the published message should have the retain flag on or not.
    /// </summary>
    [JsonPropertyName("retain"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Retain { get; set; }

    /// <summary>
    /// Gets a value indicating whether the <see cref="StateTopic"/> is outdated and an update needs to be sent to Home Assistant.
    /// </summary>
    /// <remarks>Automatically resets on <see cref="SendStateAsync"/></remarks>
    [JsonIgnore]
    public bool IsStateOutdated { get; protected set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether the entities <see cref="ConfigTopic"/> is published and known by HA.
    /// </summary>
    [JsonIgnore]
    public bool IsPublished { get; protected set; }

    /// <summary>
    /// Gets or sets a value indicating whether the entities <see cref="CommandTopic"/> is listening for command messages.
    /// </summary>
    [JsonIgnore]
    public bool IsListeningForCommandMessages { get; protected set; }

    /// <summary>
    /// Gets a value indicating whether the entity is disposed.
    /// </summary>
    [JsonIgnore]
    public bool IsDisposed { get; private set; }

    [JsonIgnore]
    public IMqttClient MqttClient { get; }

    #endregion

    #region Public Methods

    /// <inheritdoc />
    public void Dispose()
    {
        if (IsDisposed) return;
        IsDisposed = true;
        OnDispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Builds the identifier based on given parts joined by a <c>_</c> <br/>
    /// Also replaces illegal characters with a <c>_</c>, make sure you only add
    /// parts of the ID, since <c>/</c> is also considered as illegal!
    /// </summary>
    /// <param name="parts">The parts.</param>
    /// <returns>The formatted ID</returns>
    internal static string BuildID(params string[] parts)
    {
        return _allowedEntityIdRegex.Replace(string.Join("_", parts).Trim().ToLower(), "_");
    }

    /// <summary>
    /// Announces the entity to Home Assistant via <see cref="ConfigTopic"/> to make the entity available. <br/>
    /// Also subscribes to the <see cref="CommandTopic"/> if it is defined.
    /// </summary>
    /// <remarks>Use <see cref="RevokeAsync"/> to let HA know that the entity is not available anymore</remarks>
    internal async Task PublishAsync()
    {
        if (IsDisposed || ConfigTopic == null || !MqttClient.IsConnected) return;

        if (!IsPublished)
        {
            IsPublished = await MqttClient.PublishAsync(ConfigTopic, GetConfigMqttPayload()).ConfigureAwait(false);
        }

        if (CommandTopic != null && !IsListeningForCommandMessages)
        {
            await MqttClient.SubscribeAsync(CommandTopic, OnCommandMessageReceivedAsync).ConfigureAwait(false);
            IsListeningForCommandMessages = true;
        }
    }

    /// <summary>
    /// Revokes the entity to let Home Assistant know that the entity is not available anymore. <br/>
    /// It is usually called on <see cref="OnDispose"/> (automatically).
    /// </summary>
    /// <remarks>This includes <see cref="ConfigTopic"/>, <see cref="StateTopic"/> and <see cref="CommandTopic"/></remarks>
    internal async Task RevokeAsync()
    {
        if (ConfigTopic != null) await MqttClient.PublishAsync(ConfigTopic, null).ConfigureAwait(false);
        if (StateTopic != null) await MqttClient.PublishAsync(StateTopic, null).ConfigureAwait(false);
        if (CommandTopic != null)
        {
            await MqttClient.UnsubscribeAsync(CommandTopic, OnCommandMessageReceivedAsync).ConfigureAwait(false);
            await MqttClient.PublishAsync(CommandTopic, null).ConfigureAwait(false);
        }

        IsPublished = false;
        IsListeningForCommandMessages = false;
    }

    /// <summary>
    /// Sends the state of the entity to Home Assistant via <see cref="StateTopic"/>.
    /// </summary>
    /// <param name="force">if set to <c>true</c> [force update].</param>
    /// <remarks>The <see cref="HaEntityBase"/> calls the <see cref="PublishAsync"/> if required</remarks>
    internal virtual async Task SendStateAsync(bool force = false)
    {
        if (IsDisposed) return;
        if (!IsPublished || force) await PublishAsync().ConfigureAwait(false);
        if(StateTopic != null && (IsStateOutdated || force)) IsStateOutdated = !await MqttClient.PublishAsync(StateTopic, GetStateMqttPayload()).ConfigureAwait(false);
    }

    /// <summary>
    /// Sends the command of the entity to Home Assistant via <see cref="CommandTopic"/>.
    /// </summary>
    /// <param name="force">if set to <c>true</c> [force update].</param>
    /// <remarks>The <see cref="HaEntityBase"/> calls the <see cref="PublishAsync"/> if required</remarks>
    internal virtual async Task SendCommandAsync(bool force = false)
    {
        if (IsDisposed) return;
        if (!IsPublished || force) await PublishAsync().ConfigureAwait(false);
        if (CommandTopic != null) await MqttClient.PublishAsync(CommandTopic, GetCommandMqttPayload()).ConfigureAwait(false);
    }

    /// <summary>
    /// Converts the Home Assistant entity into a MQTT payload for the <see cref="ConfigTopic"/> via <see cref="PublishAsync"/>.
    /// </summary>
    /// <returns>The entity as json formatted payload</returns>
    /// <remarks>Needs type specific implementation because json does not serialize derived members</remarks>
    protected abstract string GetConfigMqttPayload();

    /// <summary>
    /// Gets the <see cref="StateTopic"/> MQTT payload when calling <see cref="SendStateAsync"/>.
    /// </summary>
    /// <returns>The state payload that will be sent with the <see cref="SendStateAsync"/></returns>
    protected virtual string? GetStateMqttPayload()
    {
        return null;
    }

    /// <summary>
    /// Gets the <see cref="CommandTopic"/> MQTT payload when calling <see cref="SendCommandAsync"/>.
    /// </summary>
    protected virtual string? GetCommandMqttPayload()
    {
        return null;
    }

    /// <summary>
    /// Called when the <see cref="CommandTopic"/> received a message.
    /// </summary>
    /// <param name="e">The received <see cref="MqttMessageEventArgs"/> from the <see cref="CommandTopic"/> subscription.</param>
    protected virtual Task OnCommandMessageReceivedAsync(MqttMessageEventArgs e)
    {
        return Task.CompletedTask;
    }

    /// <summary>
    /// Releases unmanaged and - optionally - managed resources.
    /// </summary>
    /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
    protected virtual void OnDispose(bool disposing)
    {
        if (!disposing) return;
        MqttClient.ConnectionStateChanged -= OnMqttConnectionStateChanged;
        RevokeAsync().Wait();
    }

    /// <summary>
    /// Called when MQTT connection state has changed.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">if set to <c>true</c> [e].</param>
    protected virtual void OnMqttConnectionStateChanged(object? sender, bool e)
    {
        if (!IsDisposed && !e)
        {
            IsPublished = false;
            // ToDo check if IsListeningForCommandMessages = false; is required!!!
        }
    }

    /// <summary>
    /// Called when a model state value has been changed to set <see cref="IsStateOutdated"/> to <c>true</c>.
    /// </summary>
    /// <param name="propertyName">Name of the property.</param>
    protected virtual void OnStateChanged([CallerMemberName] string propertyName = null!)
    {
        IsStateOutdated = true;
    }

    #endregion

    #region Private Methods

    #endregion
}