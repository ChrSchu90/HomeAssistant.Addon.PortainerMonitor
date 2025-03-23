#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sServiceIngress {
    /// <summary>
    /// Gets or Sets Host
    /// </summary>
    [JsonPropertyName("Host")]
    public string Host { get; set; }

    /// <summary>
    /// Gets or Sets IP
    /// </summary>
    [JsonPropertyName("IP")]
    public string IP { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sServiceIngress {\n");
        sb.Append("  Host: ").Append(Host).Append("\n");
        sb.Append("  IP: ").Append(IP).Append("\n");
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