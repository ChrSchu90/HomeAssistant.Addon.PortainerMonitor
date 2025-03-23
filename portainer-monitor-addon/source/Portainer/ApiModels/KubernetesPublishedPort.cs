#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesPublishedPort {
    /// <summary>
    /// Gets or Sets IngressRules
    /// </summary>
    [JsonPropertyName("IngressRules")]
    public List<KubernetesIngressRule> IngressRules { get; set; }

    /// <summary>
    /// Gets or Sets Port
    /// </summary>
    [JsonPropertyName("Port")]
    public int? Port { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesPublishedPort {\n");
        sb.Append("  IngressRules: ").Append(IngressRules).Append("\n");
        sb.Append("  Port: ").Append(Port).Append("\n");
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