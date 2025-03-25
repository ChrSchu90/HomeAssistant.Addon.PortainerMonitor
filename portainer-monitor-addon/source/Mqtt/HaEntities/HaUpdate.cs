namespace HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// Home Assistant Update Entity
/// </summary>
internal class HaUpdate : HaEntityBase
{
    #region Private Static Fields

    private const string UpdateConfigTopic = "homeassistant/update/{0}/config";
    private const string UpdateStateTopic = "homeassistant/update/{0}/state";

    #endregion

    #region Private Fields

    private bool? _isUpdateAvailable;
    private readonly UpdateState _updateState = new();

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="HaUpdate" /> class.
    /// </summary>
    /// <param name="id">The full qualified entity id (e.g. abc_def_ghi_jkl).</param>
    /// <param name="displayName">The display name (e.g. Outdoor Temperature).</param>
    /// <param name="device">The root device.</param>
    /// <param name="mqttClient">The MQTT client.</param>
    internal HaUpdate(string id, string displayName, HaDevice device, IMqttClient mqttClient)
        : base(id, displayName, device, mqttClient)
    {
        ConfigTopic = string.Format(UpdateConfigTopic, ID);
        StateTopic = string.Format(UpdateStateTopic, ID);
    }

    #endregion

    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the currently installed version.
    /// </summary>
    internal Version? CurrentVersion
    {
        get => _updateState.CurrentVersion;
        set
        {
            if(_updateState.CurrentVersion == value) return;
            _updateState.CurrentVersion = value;
            OnStateChanged();
        }
    }

    /// <summary>
    /// Gets or sets the latest available version.
    /// </summary>
    internal Version? LatestVersion
    {
        get => _updateState.LatestVersion;
        set
        {
            if(_updateState.LatestVersion == value) return;
            _updateState.LatestVersion = value;
            OnStateChanged();
        }
    }

    /// <summary>
    /// Gets or sets the release URL e.g. https://github.com/portainer/portainer/releases/tag/{LatestVersion}.
    /// </summary>
    internal string? ReleaseUrl
    {
        get => _updateState.ReleaseUrl;
        set
        {
            if(_updateState.ReleaseUrl == value) return;
            _updateState.ReleaseUrl = value;
            OnStateChanged();
        }
    }

    /// <summary>
    /// Gets or sets the Title of the software, or firmware update. This helps to differentiate between the device or entity name versus the title of the software installed.
    /// </summary>
    internal string? Title
    {
        get => _updateState.Title;
        set
        {
            if(_updateState.Title == value) return;
            _updateState.Title = value;
            OnStateChanged();
        }
    }

    /// <summary>
    /// Gets or sets the latest available version.
    /// </summary>
    [JsonIgnore]
    internal bool? IsUpdateAvailable
    {
        get => _isUpdateAvailable;
        set
        {
            if (_isUpdateAvailable == value) return;
            _isUpdateAvailable = value;
            OnStateChanged();
        }
    }

    #endregion

    #region Public Methods

    /// <inheritdoc />
    protected override string GetConfigMqttPayload() => JsonSerializer.Serialize(this);

    /// <inheritdoc />
    protected override string GetStateMqttPayload() => JsonSerializer.Serialize(_updateState);

    /// <inheritdoc />
    protected override void OnMqttConnectionStateChanged(object? sender, bool e)
    {
        base.OnMqttConnectionStateChanged(sender, e);
        if (!IsDisposed & e)
        {
            _updateState.CurrentVersion = null;
            _updateState.LatestVersion = null;
        }
    }

    /// <inheritdoc />
    protected override void OnHomeAssistantAvailabilityChanged(object? sender, bool e)
    {
        base.OnHomeAssistantAvailabilityChanged(sender, e);
        if (!IsDisposed && e)
        {
            _updateState.CurrentVersion = null;
            _updateState.LatestVersion = null;
        }
    }

    #endregion

    #region Private Methods

    #endregion
}

/// <summary>
/// <see cref="HaEntityBase.StateTopic"/> value for <see cref="HaUpdate"/> MQTT entity
/// </summary>
internal class UpdateState
{
    /// <summary>
    /// Gets or sets the currently installed version.
    /// </summary>
    [JsonPropertyName("installed_version"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Version? CurrentVersion { get; set; }

    /// <summary>
    /// Gets or sets the latest available version.
    /// </summary>
    [JsonPropertyName("latest_version"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Version? LatestVersion { get; set; }

    /// <summary>
    /// Gets or sets the release URL e.g. https://github.com/portainer/portainer/releases/tag/{LatestVersion}.
    /// </summary>
    [JsonPropertyName("release_url"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ReleaseUrl { get; set; }

    /// <summary>
    /// Gets or sets the Title of the software, or firmware update. This helps to differentiate between the device or entity name versus the title of the software installed.
    /// </summary>
    [JsonPropertyName("title"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Title { get; set; }
}