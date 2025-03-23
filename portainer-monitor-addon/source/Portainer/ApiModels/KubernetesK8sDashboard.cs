#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sDashboard {
    /// <summary>
    /// Gets or Sets ApplicationsCount
    /// </summary>
    [JsonPropertyName("applicationsCount")]
    public int? ApplicationsCount { get; set; }

    /// <summary>
    /// Gets or Sets ConfigMapsCount
    /// </summary>
    [JsonPropertyName("configMapsCount")]
    public int? ConfigMapsCount { get; set; }

    /// <summary>
    /// Gets or Sets IngressesCount
    /// </summary>
    [JsonPropertyName("ingressesCount")]
    public int? IngressesCount { get; set; }

    /// <summary>
    /// Gets or Sets NamespacesCount
    /// </summary>
    [JsonPropertyName("namespacesCount")]
    public int? NamespacesCount { get; set; }

    /// <summary>
    /// Gets or Sets SecretsCount
    /// </summary>
    [JsonPropertyName("secretsCount")]
    public int? SecretsCount { get; set; }

    /// <summary>
    /// Gets or Sets ServicesCount
    /// </summary>
    [JsonPropertyName("servicesCount")]
    public int? ServicesCount { get; set; }

    /// <summary>
    /// Gets or Sets VolumesCount
    /// </summary>
    [JsonPropertyName("volumesCount")]
    public int? VolumesCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sDashboard {\n");
        sb.Append("  ApplicationsCount: ").Append(ApplicationsCount).Append("\n");
        sb.Append("  ConfigMapsCount: ").Append(ConfigMapsCount).Append("\n");
        sb.Append("  IngressesCount: ").Append(IngressesCount).Append("\n");
        sb.Append("  NamespacesCount: ").Append(NamespacesCount).Append("\n");
        sb.Append("  SecretsCount: ").Append(SecretsCount).Append("\n");
        sb.Append("  ServicesCount: ").Append(ServicesCount).Append("\n");
        sb.Append("  VolumesCount: ").Append(VolumesCount).Append("\n");
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