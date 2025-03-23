#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerEdgeStack {
    /// <summary>
    /// StatusArray    map[EndpointID][]EdgeStackStatus `json:\"StatusArray\"`
    /// </summary>
    /// <value>StatusArray    map[EndpointID][]EdgeStackStatus `json:\"StatusArray\"`</value>
    [JsonPropertyName("CreationDate")]
    public int? CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets DeploymentType
    /// </summary>
    [JsonPropertyName("DeploymentType")]
    public int? DeploymentType { get; set; }

    /// <summary>
    /// Gets or Sets EdgeGroups
    /// </summary>
    [JsonPropertyName("EdgeGroups")]
    public List<int?> EdgeGroups { get; set; }

    /// <summary>
    /// Gets or Sets EntryPoint
    /// </summary>
    [JsonPropertyName("EntryPoint")]
    public string EntryPoint { get; set; }

    /// <summary>
    /// EdgeStack Identifier
    /// </summary>
    /// <value>EdgeStack Identifier</value>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets ManifestPath
    /// </summary>
    [JsonPropertyName("ManifestPath")]
    public string ManifestPath { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets NumDeployments
    /// </summary>
    [JsonPropertyName("NumDeployments")]
    public int? NumDeployments { get; set; }

    /// <summary>
    /// Gets or Sets ProjectPath
    /// </summary>
    [JsonPropertyName("ProjectPath")]
    public string ProjectPath { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("Status")]
    public Dictionary<string, PortainerEdgeStackStatus> Status { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [JsonPropertyName("Version")]
    public int? Version { get; set; }

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
        sb.Append("class PortainerEdgeStack {\n");
        sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
        sb.Append("  DeploymentType: ").Append(DeploymentType).Append("\n");
        sb.Append("  EdgeGroups: ").Append(EdgeGroups).Append("\n");
        sb.Append("  EntryPoint: ").Append(EntryPoint).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ManifestPath: ").Append(ManifestPath).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  NumDeployments: ").Append(NumDeployments).Append("\n");
        sb.Append("  ProjectPath: ").Append(ProjectPath).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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