#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1LoadBalancerStatus {
    /// <summary>
    /// Ingress is a list containing ingress points for the load-balancer. Traffic intended for the service should be sent to these ingress points. +optional
    /// </summary>
    /// <value>Ingress is a list containing ingress points for the load-balancer. Traffic intended for the service should be sent to these ingress points. +optional</value>
    [JsonPropertyName("ingress")]
    public List<V1LoadBalancerIngress> Ingress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1LoadBalancerStatus {\n");
        sb.Append("  Ingress: ").Append(Ingress).Append("\n");
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