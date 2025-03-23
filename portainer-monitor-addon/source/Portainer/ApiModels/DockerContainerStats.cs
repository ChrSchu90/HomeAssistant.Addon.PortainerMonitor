#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class DockerContainerStats {
    /// <summary>
    /// Gets or Sets Healthy
    /// </summary>
    [JsonPropertyName("healthy")]
    public int? Healthy { get; set; }

    /// <summary>
    /// Gets or Sets Running
    /// </summary>
    [JsonPropertyName("running")]
    public int? Running { get; set; }

    /// <summary>
    /// Gets or Sets Stopped
    /// </summary>
    [JsonPropertyName("stopped")]
    public int? Stopped { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

    /// <summary>
    /// Gets or Sets Unhealthy
    /// </summary>
    [JsonPropertyName("unhealthy")]
    public int? Unhealthy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class DockerContainerStats {\n");
        sb.Append("  Healthy: ").Append(Healthy).Append("\n");
        sb.Append("  Running: ").Append(Running).Append("\n");
        sb.Append("  Stopped: ").Append(Stopped).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  Unhealthy: ").Append(Unhealthy).Append("\n");
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