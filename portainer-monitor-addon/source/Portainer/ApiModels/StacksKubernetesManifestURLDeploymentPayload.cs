#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class StacksKubernetesManifestURLDeploymentPayload {
    /// <summary>
    /// Gets or Sets ComposeFormat
    /// </summary>
    [JsonPropertyName("composeFormat")]
    public bool? ComposeFormat { get; set; }

    /// <summary>
    /// Gets or Sets ManifestURL
    /// </summary>
    [JsonPropertyName("manifestURL")]
    public string ManifestURL { get; set; }

    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Gets or Sets StackName
    /// </summary>
    [JsonPropertyName("stackName")]
    public string StackName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class StacksKubernetesManifestURLDeploymentPayload {\n");
        sb.Append("  ComposeFormat: ").Append(ComposeFormat).Append("\n");
        sb.Append("  ManifestURL: ").Append(ManifestURL).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  StackName: ").Append(StackName).Append("\n");
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