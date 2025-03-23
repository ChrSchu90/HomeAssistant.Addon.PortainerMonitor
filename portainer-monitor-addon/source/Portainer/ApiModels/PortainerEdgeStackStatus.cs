#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerEdgeStackStatus {
    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [JsonPropertyName("Type")]
    public int? Type { get; set; }

    /// <summary>
    /// EE only feature
    /// </summary>
    /// <value>EE only feature</value>
    [JsonPropertyName("deploymentInfo")]
    public PortainerStackDeploymentInfo DeploymentInfo { get; set; }

    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [JsonPropertyName("details")]
    public PortainerEdgeStackStatusDetails Details { get; set; }

    /// <summary>
    /// Gets or Sets EndpointID
    /// </summary>
    [JsonPropertyName("endpointID")]
    public int? EndpointID { get; set; }

    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [JsonPropertyName("error")]
    public string Error { get; set; }

    /// <summary>
    /// ReadyRePullImage is a flag to indicate whether the auto update is trigger to re-pull image
    /// </summary>
    /// <value>ReadyRePullImage is a flag to indicate whether the auto update is trigger to re-pull image</value>
    [JsonPropertyName("readyRePullImage")]
    public bool? ReadyRePullImage { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public List<PortainerEdgeStackDeploymentStatus> Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerEdgeStackStatus {\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  DeploymentInfo: ").Append(DeploymentInfo).Append("\n");
        sb.Append("  Details: ").Append(Details).Append("\n");
        sb.Append("  EndpointID: ").Append(EndpointID).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  ReadyRePullImage: ").Append(ReadyRePullImage).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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