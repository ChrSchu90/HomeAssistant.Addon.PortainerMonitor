#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerKubernetesFlags {
    /// <summary>
    /// Gets or Sets IsServerIngressClassDetected
    /// </summary>
    [JsonPropertyName("IsServerIngressClassDetected")]
    public bool? IsServerIngressClassDetected { get; set; }

    /// <summary>
    /// Gets or Sets IsServerMetricsDetected
    /// </summary>
    [JsonPropertyName("IsServerMetricsDetected")]
    public bool? IsServerMetricsDetected { get; set; }

    /// <summary>
    /// Gets or Sets IsServerStorageDetected
    /// </summary>
    [JsonPropertyName("IsServerStorageDetected")]
    public bool? IsServerStorageDetected { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerKubernetesFlags {\n");
        sb.Append("  IsServerIngressClassDetected: ").Append(IsServerIngressClassDetected).Append("\n");
        sb.Append("  IsServerMetricsDetected: ").Append(IsServerMetricsDetected).Append("\n");
        sb.Append("  IsServerStorageDetected: ").Append(IsServerStorageDetected).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}