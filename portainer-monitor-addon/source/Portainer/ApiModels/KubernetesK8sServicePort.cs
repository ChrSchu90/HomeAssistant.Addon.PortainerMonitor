#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sServicePort {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets NodePort
    /// </summary>
    [JsonPropertyName("NodePort")]
    public int? NodePort { get; set; }

    /// <summary>
    /// Gets or Sets Port
    /// </summary>
    [JsonPropertyName("Port")]
    public int? Port { get; set; }

    /// <summary>
    /// Gets or Sets Protocol
    /// </summary>
    [JsonPropertyName("Protocol")]
    public string Protocol { get; set; }

    /// <summary>
    /// Gets or Sets TargetPort
    /// </summary>
    [JsonPropertyName("TargetPort")]
    public string TargetPort { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sServicePort {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  NodePort: ").Append(NodePort).Append("\n");
        sb.Append("  Port: ").Append(Port).Append("\n");
        sb.Append("  Protocol: ").Append(Protocol).Append("\n");
        sb.Append("  TargetPort: ").Append(TargetPort).Append("\n");
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