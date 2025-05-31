namespace HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

internal class HaDevice
{
    #region Static Fields

    /// <summary>
    /// The default device version
    /// </summary>
    internal static readonly Version DefaultDeviceVersion = new(0, 0, 0);

    #endregion

    #region Private Fields

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="HaDevice" /> class.
    /// </summary>
    /// <param name="addonPrefix">The addon prefix.</param>
    /// <param name="id">The device identifier.</param>
    /// <param name="name">The device display name.</param>
    /// <param name="manufacturer">The device manufacturer.</param>
    /// <param name="model">The device model.</param>
    /// <param name="version">The device version.</param>
    internal HaDevice(string addonPrefix, string id, string? name, string? manufacturer = null, string? model = null, Version? version = null)
    {
        Name = name ?? string.Empty;
        Manufacturer = manufacturer ?? string.Empty;
        Model = model ?? string.Empty;
        Version = version ?? DefaultDeviceVersion;
        AddonPrefix = addonPrefix;
        Identifiers = [HaEntityBase.BuildID(AddonPrefix, id)];
    }

    #endregion

    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the device display name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the device manufacturer.
    /// </summary>
    [JsonPropertyName("manufacturer")]
    public string Manufacturer { get; set; }

    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    [JsonPropertyName("model")]
    public string Model { get; set; }

    /// <summary>
    /// Gets or sets the device software version.
    /// </summary>
    [JsonPropertyName("sw_version"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Version? Version { get; set; }

    /// <summary>
    /// Gets or sets the device identifiers.
    /// </summary>
    [JsonPropertyName("identifiers")]
    public string[] Identifiers { get; set; }

    /// <summary>
    /// Gets the addon entity ID prefix.
    /// </summary>
    [JsonIgnore]
    internal string AddonPrefix { get; }

    /// <summary>
    /// Gets the identifier.
    /// </summary>
    [JsonIgnore]
    internal string Identifier => Identifiers[0];

    #endregion

    #region Public Methods

    /// <summary>
    /// Converts the Home Assistant entity into a MQTT payload.
    /// </summary>
    /// <returns>The entity as json formatted payload</returns>
    internal virtual string ToMqttPayload()
    {
        return JsonSerializer.Serialize(this);
    }

    #endregion

    #region Private Methods

    #endregion
}