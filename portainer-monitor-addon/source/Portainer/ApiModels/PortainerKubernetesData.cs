#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerKubernetesData {
    /// <summary>
    /// Gets or Sets Configuration
    /// </summary>
    [JsonPropertyName("Configuration")]
    public PortainerKubernetesConfiguration Configuration { get; set; }

    /// <summary>
    /// Gets or Sets Flags
    /// </summary>
    [JsonPropertyName("Flags")]
    public PortainerKubernetesFlags Flags { get; set; }

    /// <summary>
    /// Gets or Sets Snapshots
    /// </summary>
    [JsonPropertyName("Snapshots")]
    public List<PortainerKubernetesSnapshot> Snapshots { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerKubernetesData {\n");
        sb.Append("  Configuration: ").Append(Configuration).Append("\n");
        sb.Append("  Flags: ").Append(Flags).Append("\n");
        sb.Append("  Snapshots: ").Append(Snapshots).Append("\n");
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