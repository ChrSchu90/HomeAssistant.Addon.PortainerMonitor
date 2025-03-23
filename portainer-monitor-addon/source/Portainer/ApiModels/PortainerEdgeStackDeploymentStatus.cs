#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerEdgeStackDeploymentStatus {
    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [JsonPropertyName("Version")]
    public int? Version { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [JsonPropertyName("error")]
    public string Error { get; set; }

    /// <summary>
    /// EE only feature
    /// </summary>
    /// <value>EE only feature</value>
    [JsonPropertyName("rollbackTo")]
    public int? RollbackTo { get; set; }

    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [JsonPropertyName("time")]
    public int? Time { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerEdgeStackDeploymentStatus {\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  RollbackTo: ").Append(RollbackTo).Append("\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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