#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sIngressTLS {
    /// <summary>
    /// Gets or Sets Hosts
    /// </summary>
    [JsonPropertyName("Hosts")]
    public List<string> Hosts { get; set; }

    /// <summary>
    /// Gets or Sets SecretName
    /// </summary>
    [JsonPropertyName("SecretName")]
    public string SecretName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sIngressTLS {\n");
        sb.Append("  Hosts: ").Append(Hosts).Append("\n");
        sb.Append("  SecretName: ").Append(SecretName).Append("\n");
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