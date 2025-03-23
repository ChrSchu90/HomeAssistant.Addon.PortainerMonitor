#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class BuildDependenciesInfo {
    /// <summary>
    /// Gets or Sets ComposeVersion
    /// </summary>
    [JsonPropertyName("composeVersion")]
    public string ComposeVersion { get; set; }

    /// <summary>
    /// Gets or Sets DockerVersion
    /// </summary>
    [JsonPropertyName("dockerVersion")]
    public string DockerVersion { get; set; }

    /// <summary>
    /// Gets or Sets HelmVersion
    /// </summary>
    [JsonPropertyName("helmVersion")]
    public string HelmVersion { get; set; }

    /// <summary>
    /// Gets or Sets KubectlVersion
    /// </summary>
    [JsonPropertyName("kubectlVersion")]
    public string KubectlVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class BuildDependenciesInfo {\n");
        sb.Append("  ComposeVersion: ").Append(ComposeVersion).Append("\n");
        sb.Append("  DockerVersion: ").Append(DockerVersion).Append("\n");
        sb.Append("  HelmVersion: ").Append(HelmVersion).Append("\n");
        sb.Append("  KubectlVersion: ").Append(KubectlVersion).Append("\n");
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