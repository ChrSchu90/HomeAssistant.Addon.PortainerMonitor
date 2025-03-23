#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sIngressPath {
    /// <summary>
    /// Gets or Sets HasService
    /// </summary>
    [JsonPropertyName("HasService")]
    public bool? HasService { get; set; }

    /// <summary>
    /// Gets or Sets Host
    /// </summary>
    [JsonPropertyName("Host")]
    public string Host { get; set; }

    /// <summary>
    /// Gets or Sets IngressName
    /// </summary>
    [JsonPropertyName("IngressName")]
    public string IngressName { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [JsonPropertyName("Path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets PathType
    /// </summary>
    [JsonPropertyName("PathType")]
    public string PathType { get; set; }

    /// <summary>
    /// Gets or Sets Port
    /// </summary>
    [JsonPropertyName("Port")]
    public int? Port { get; set; }

    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>
    [JsonPropertyName("ServiceName")]
    public string ServiceName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sIngressPath {\n");
        sb.Append("  HasService: ").Append(HasService).Append("\n");
        sb.Append("  Host: ").Append(Host).Append("\n");
        sb.Append("  IngressName: ").Append(IngressName).Append("\n");
        sb.Append("  Path: ").Append(Path).Append("\n");
        sb.Append("  PathType: ").Append(PathType).Append("\n");
        sb.Append("  Port: ").Append(Port).Append("\n");
        sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
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