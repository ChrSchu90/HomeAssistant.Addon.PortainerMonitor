#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerK8sNodeLimits {
    /// <summary>
    /// Gets or Sets CPU
    /// </summary>
    [JsonPropertyName("CPU")]
    public int? CPU { get; set; }

    /// <summary>
    /// Gets or Sets Memory
    /// </summary>
    [JsonPropertyName("Memory")]
    public int? Memory { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerK8sNodeLimits {\n");
        sb.Append("  CPU: ").Append(CPU).Append("\n");
        sb.Append("  Memory: ").Append(Memory).Append("\n");
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