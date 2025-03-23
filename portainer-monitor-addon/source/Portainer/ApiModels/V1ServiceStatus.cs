#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1ServiceStatus {
    /// <summary>
    /// Current service state +optional +patchMergeKey=type +patchStrategy=merge +listType=map +listMapKey=type
    /// </summary>
    /// <value>Current service state +optional +patchMergeKey=type +patchStrategy=merge +listType=map +listMapKey=type</value>
    [JsonPropertyName("conditions")]
    public List<V1Condition> Conditions { get; set; }

    /// <summary>
    /// LoadBalancer contains the current status of the load-balancer, if one is present. +optional
    /// </summary>
    /// <value>LoadBalancer contains the current status of the load-balancer, if one is present. +optional</value>
    [JsonPropertyName("loadBalancer")]
    public V1LoadBalancerStatus LoadBalancer { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1ServiceStatus {\n");
        sb.Append("  Conditions: ").Append(Conditions).Append("\n");
        sb.Append("  LoadBalancer: ").Append(LoadBalancer).Append("\n");
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