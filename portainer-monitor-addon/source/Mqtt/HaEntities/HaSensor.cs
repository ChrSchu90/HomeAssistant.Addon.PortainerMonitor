namespace HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// Home Assistant Sensor Entity
/// </summary>
/// <typeparam name="T">Value Type</typeparam>
internal class HaSensor<T> : HaEntityBase where T : IConvertible
{
    #region Private Static Fields

    private const string SensorStateTopic = "homeassistant/sensor/{0}/state";
    private const string SensorConfigTopic = "homeassistant/sensor/{0}/config";

    #endregion

    #region Private Fields

    private T? _value;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="HaSensor{T}" /> class.
    /// </summary>
    /// <param name="id">The full qualified entity id (e.g. abc_def_ghi_jkl).</param>
    /// <param name="displayName">The display name (e.g. Outdoor Temperature).</param>
    /// <param name="device">The root device.</param>
    /// <param name="mqttClient">The MQTT client.</param>
    /// <param name="valueConverter">The value converter.</param>
    internal HaSensor(string id, string displayName, HaDevice device, IMqttClient mqttClient, IValueConverter<T>? valueConverter)
        : base(id, displayName, device, mqttClient)
    {
        ConfigTopic = string.Format(SensorConfigTopic, ID);
        StateTopic = string.Format(SensorStateTopic, ID);
        ValueConverter = valueConverter ?? new ValueConverter<T>();
        StateClass = HaSensorStateClass.MEASUREMENT;
    }

    #endregion

    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the <see cref="HaSensorStateClass"/>.
    /// </summary>
    [JsonPropertyName("state_class"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StateClass { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="HaUnitOfMeasurement"/>.
    /// </summary>
    [JsonPropertyName("unit_of_measurement"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? UnitOfMeasurement { get; set; }

    /// <summary>
    /// Gets or sets the number of decimal places which should be used in the sensor's state when it's displayed.
    /// </summary>
    /// <remarks>Require <see cref="StateClass"/> to be defined</remarks>
    [JsonPropertyName("suggested_display_precision"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? SuggestedDisplayPrecision { get; set; }

    /// <summary>
    /// Gets or sets the sensor value.
    /// </summary>
    [JsonIgnore]
    internal T Value
    {
        get => _value ?? default!;
        set
        {
            if (value.Equals(_value)) return;
            _value = value;
            OnStateChanged();
        }
    }

    /// <summary>
    /// Gets the value formatter.
    /// </summary>
    /// <remarks>Defaults to <see cref="ValueConverter{T}"/></remarks>
    [JsonIgnore]
    internal IValueConverter<T> ValueConverter { get; }

    #endregion

    #region Public Methods

    /// <inheritdoc />
    protected override string GetConfigMqttPayload() => JsonSerializer.Serialize(this);

    /// <inheritdoc />
    protected override string? GetStateMqttPayload()
    {
        return _value == null ? null : ValueConverter.ValueToData(Value);
    }

    /// <inheritdoc />
    protected override void OnMqttConnectionStateChanged(object? sender, bool e)
    {
        base.OnMqttConnectionStateChanged(sender, e);
        if (!IsDisposed & e)
        {
            _value = default;
        }
    }

    /// <inheritdoc />
    protected override void OnHomeAssistantAvailabilityChanged(object? sender, bool e)
    {
        base.OnHomeAssistantAvailabilityChanged(sender, e);
        if (!IsDisposed && e)
        {
            _value = default;
        }
    }

    #endregion

    #region Private Methods

    #endregion
}