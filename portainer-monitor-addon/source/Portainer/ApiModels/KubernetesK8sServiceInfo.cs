#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sServiceInfo {
    /// <summary>
    /// Gets or Sets AllocateLoadBalancerNodePorts
    /// </summary>
    [JsonPropertyName("allocateLoadBalancerNodePorts")]
    public bool? AllocateLoadBalancerNodePorts { get; set; }

    /// <summary>
    /// Gets or Sets Annotations
    /// </summary>
    [JsonPropertyName("annotations")]
    public Dictionary<string, string> Annotations { get; set; }

    /// <summary>
    /// serviceList screen
    /// </summary>
    /// <value>serviceList screen</value>
    [JsonPropertyName("applications")]
    public List<KubernetesK8sApplication> Applications { get; set; }

    /// <summary>
    /// Gets or Sets ClusterIPs
    /// </summary>
    [JsonPropertyName("clusterIPs")]
    public List<string> ClusterIPs { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [JsonPropertyName("creationDate")]
    public string CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets ExternalIPs
    /// </summary>
    [JsonPropertyName("externalIPs")]
    public List<string> ExternalIPs { get; set; }

    /// <summary>
    /// Gets or Sets ExternalName
    /// </summary>
    [JsonPropertyName("externalName")]
    public string ExternalName { get; set; }

    /// <summary>
    /// Gets or Sets IngressStatus
    /// </summary>
    [JsonPropertyName("ingressStatus")]
    public List<KubernetesK8sServiceIngress> IngressStatus { get; set; }

    /// <summary>
    /// Gets or Sets Labels
    /// </summary>
    [JsonPropertyName("labels")]
    public Dictionary<string, string> Labels { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Gets or Sets Ports
    /// </summary>
    [JsonPropertyName("ports")]
    public List<KubernetesK8sServicePort> Ports { get; set; }

    /// <summary>
    /// Gets or Sets Selector
    /// </summary>
    [JsonPropertyName("selector")]
    public Dictionary<string, string> Selector { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Uid
    /// </summary>
    [JsonPropertyName("uid")]
    public string Uid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sServiceInfo {\n");
        sb.Append("  AllocateLoadBalancerNodePorts: ").Append(AllocateLoadBalancerNodePorts).Append("\n");
        sb.Append("  Annotations: ").Append(Annotations).Append("\n");
        sb.Append("  Applications: ").Append(Applications).Append("\n");
        sb.Append("  ClusterIPs: ").Append(ClusterIPs).Append("\n");
        sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
        sb.Append("  ExternalIPs: ").Append(ExternalIPs).Append("\n");
        sb.Append("  ExternalName: ").Append(ExternalName).Append("\n");
        sb.Append("  IngressStatus: ").Append(IngressStatus).Append("\n");
        sb.Append("  Labels: ").Append(Labels).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  Ports: ").Append(Ports).Append("\n");
        sb.Append("  Selector: ").Append(Selector).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Uid: ").Append(Uid).Append("\n");
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