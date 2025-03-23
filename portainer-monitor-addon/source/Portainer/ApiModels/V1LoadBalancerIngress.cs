#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1LoadBalancerIngress {
    /// <summary>
    /// Hostname is set for load-balancer ingress points that are DNS based (typically AWS load-balancers) +optional
    /// </summary>
    /// <value>Hostname is set for load-balancer ingress points that are DNS based (typically AWS load-balancers) +optional</value>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>
    /// IP is set for load-balancer ingress points that are IP based (typically GCE or OpenStack load-balancers) +optional
    /// </summary>
    /// <value>IP is set for load-balancer ingress points that are IP based (typically GCE or OpenStack load-balancers) +optional</value>
    [JsonPropertyName("ip")]
    public string Ip { get; set; }

    /// <summary>
    /// IPMode specifies how the load-balancer IP behaves, and may only be specified when the ip field is specified. Setting this to \"VIP\" indicates that traffic is delivered to the node with the destination set to the load-balancer's IP and port. Setting this to \"Proxy\" indicates that traffic is delivered to the node or pod with the destination set to the node's IP and node port or the pod's IP and port. Service implementations may use this information to adjust traffic routing. +optional
    /// </summary>
    /// <value>IPMode specifies how the load-balancer IP behaves, and may only be specified when the ip field is specified. Setting this to \"VIP\" indicates that traffic is delivered to the node with the destination set to the load-balancer's IP and port. Setting this to \"Proxy\" indicates that traffic is delivered to the node or pod with the destination set to the node's IP and node port or the pod's IP and port. Service implementations may use this information to adjust traffic routing. +optional</value>
    [JsonPropertyName("ipMode")]
    public string IpMode { get; set; }

    /// <summary>
    /// Ports is a list of records of service ports If used, every port defined in the service should have an entry in it +listType=atomic +optional
    /// </summary>
    /// <value>Ports is a list of records of service ports If used, every port defined in the service should have an entry in it +listType=atomic +optional</value>
    [JsonPropertyName("ports")]
    public List<V1PortStatus> Ports { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1LoadBalancerIngress {\n");
        sb.Append("  Hostname: ").Append(Hostname).Append("\n");
        sb.Append("  Ip: ").Append(Ip).Append("\n");
        sb.Append("  IpMode: ").Append(IpMode).Append("\n");
        sb.Append("  Ports: ").Append(Ports).Append("\n");
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