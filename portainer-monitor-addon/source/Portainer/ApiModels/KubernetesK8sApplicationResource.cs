#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sApplicationResource {
    /// <summary>
    /// Gets or Sets CpuLimit
    /// </summary>
    [JsonPropertyName("CpuLimit")]
    public decimal? CpuLimit { get; set; }

    /// <summary>
    /// Gets or Sets CpuRequest
    /// </summary>
    [JsonPropertyName("CpuRequest")]
    public decimal? CpuRequest { get; set; }

    /// <summary>
    /// Gets or Sets MemoryLimit
    /// </summary>
    [JsonPropertyName("MemoryLimit")]
    public int? MemoryLimit { get; set; }

    /// <summary>
    /// Gets or Sets MemoryRequest
    /// </summary>
    [JsonPropertyName("MemoryRequest")]
    public int? MemoryRequest { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sApplicationResource {\n");
        sb.Append("  CpuLimit: ").Append(CpuLimit).Append("\n");
        sb.Append("  CpuRequest: ").Append(CpuRequest).Append("\n");
        sb.Append("  MemoryLimit: ").Append(MemoryLimit).Append("\n");
        sb.Append("  MemoryRequest: ").Append(MemoryRequest).Append("\n");
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