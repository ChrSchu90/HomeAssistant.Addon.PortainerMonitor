#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1ContainerPort {
    /// <summary>
    /// Number of port to expose on the pod's IP address. This must be a valid port number, 0 < x < 65536.
    /// </summary>
    /// <value>Number of port to expose on the pod's IP address. This must be a valid port number, 0 < x < 65536.</value>
    [JsonPropertyName("containerPort")]
    public int? ContainerPort { get; set; }

    /// <summary>
    /// What host IP to bind the external port to. +optional
    /// </summary>
    /// <value>What host IP to bind the external port to. +optional</value>
    [JsonPropertyName("hostIP")]
    public string HostIP { get; set; }

    /// <summary>
    /// Number of port to expose on the host. If specified, this must be a valid port number, 0 < x < 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this. +optional
    /// </summary>
    /// <value>Number of port to expose on the host. If specified, this must be a valid port number, 0 < x < 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this. +optional</value>
    [JsonPropertyName("hostPort")]
    public int? HostPort { get; set; }

    /// <summary>
    /// If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services. +optional
    /// </summary>
    /// <value>If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services. +optional</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Protocol for port. Must be UDP, TCP, or SCTP. Defaults to \"TCP\". +optional +default=\"TCP\"
    /// </summary>
    /// <value>Protocol for port. Must be UDP, TCP, or SCTP. Defaults to \"TCP\". +optional +default=\"TCP\"</value>
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1ContainerPort {\n");
        sb.Append("  ContainerPort: ").Append(ContainerPort).Append("\n");
        sb.Append("  HostIP: ").Append(HostIP).Append("\n");
        sb.Append("  HostPort: ").Append(HostPort).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Protocol: ").Append(Protocol).Append("\n");
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