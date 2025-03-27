namespace HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;

using System.Text.Json.Serialization;

/// <summary>
/// A list of MQTT topics subscribed to receive availability (online/offline) updates. Must not be used together with availability_topic.
/// </summary>
public class Availability
{
    /// <summary>
    /// The <c>REQUIRED</c> MQTT topic subscribed to receive availability (online/offline) updates.
    /// </summary>
    [JsonPropertyName("topic"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Topic { get; set; } = null!;

    /// <summary>
    /// The payload that represents the available state default: online
    /// </summary>
    [JsonPropertyName("payload_available "), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PayloadAvailable { get; set; } = HaAvailability.IsAvailable;

    /// <summary>
    /// The payload that represents the unavailable state default: offline
    /// </summary>
    [JsonPropertyName("payload_not_available "), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PayloadUnavailable { get; set; } = HaAvailability.IsUnavailable;

    /// <summary>
    /// Defines a template to extract device’s availability from the topic. To determine the device's availability result of this template will be compared to payload_available and payload_not_available.
    /// </summary>
    [JsonPropertyName("value_template "), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ValueTemplate { get; set; }
}