#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EdgestacksUpdateEdgeStackPayload {
    /// <summary>
    /// Deployment type to deploy this stack Valid values are: 0 - 'compose', 1 - 'kubernetes' compose is enabled only for docker environments kubernetes is enabled only for kubernetes environments
    /// </summary>
    /// <value>Deployment type to deploy this stack Valid values are: 0 - 'compose', 1 - 'kubernetes' compose is enabled only for docker environments kubernetes is enabled only for kubernetes environments</value>
    [JsonPropertyName("deploymentType")]
    public int? DeploymentType { get; set; }

    /// <summary>
    /// Gets or Sets EdgeGroups
    /// </summary>
    [JsonPropertyName("edgeGroups")]
    public List<int?> EdgeGroups { get; set; }

    /// <summary>
    /// Gets or Sets StackFileContent
    /// </summary>
    [JsonPropertyName("stackFileContent")]
    public string StackFileContent { get; set; }

    /// <summary>
    /// Gets or Sets UpdateVersion
    /// </summary>
    [JsonPropertyName("updateVersion")]
    public bool? UpdateVersion { get; set; }

    /// <summary>
    /// Uses the manifest's namespaces instead of the default one
    /// </summary>
    /// <value>Uses the manifest's namespaces instead of the default one</value>
    [JsonPropertyName("useManifestNamespaces")]
    public bool? UseManifestNamespaces { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class EdgestacksUpdateEdgeStackPayload {\n");
        sb.Append("  DeploymentType: ").Append(DeploymentType).Append("\n");
        sb.Append("  EdgeGroups: ").Append(EdgeGroups).Append("\n");
        sb.Append("  StackFileContent: ").Append(StackFileContent).Append("\n");
        sb.Append("  UpdateVersion: ").Append(UpdateVersion).Append("\n");
        sb.Append("  UseManifestNamespaces: ").Append(UseManifestNamespaces).Append("\n");
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