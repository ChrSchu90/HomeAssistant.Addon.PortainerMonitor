#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sNamespaceDetails {
    /// <summary>
    /// Gets or Sets Annotations
    /// </summary>
    [JsonPropertyName("Annotations")]
    public Dictionary<string, string> Annotations { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Owner
    /// </summary>
    [JsonPropertyName("Owner")]
    public string Owner { get; set; }

    /// <summary>
    /// Gets or Sets ResourceQuota
    /// </summary>
    [JsonPropertyName("ResourceQuota")]
    public KubernetesK8sResourceQuota ResourceQuota { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sNamespaceDetails {\n");
        sb.Append("  Annotations: ").Append(Annotations).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Owner: ").Append(Owner).Append("\n");
        sb.Append("  ResourceQuota: ").Append(ResourceQuota).Append("\n");
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