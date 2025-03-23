#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerKubernetesIngressClassConfig {
    /// <summary>
    /// Gets or Sets Blocked
    /// </summary>
    [JsonPropertyName("Blocked")]
    public bool? Blocked { get; set; }

    /// <summary>
    /// Gets or Sets BlockedNamespaces
    /// </summary>
    [JsonPropertyName("BlockedNamespaces")]
    public List<string> BlockedNamespaces { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("Type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerKubernetesIngressClassConfig {\n");
        sb.Append("  Blocked: ").Append(Blocked).Append("\n");
        sb.Append("  BlockedNamespaces: ").Append(BlockedNamespaces).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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