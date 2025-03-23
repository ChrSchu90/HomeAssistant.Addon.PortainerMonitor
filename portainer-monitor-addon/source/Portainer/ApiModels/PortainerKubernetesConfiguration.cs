#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerKubernetesConfiguration {
    /// <summary>
    /// Gets or Sets AllowNoneIngressClass
    /// </summary>
    [JsonPropertyName("AllowNoneIngressClass")]
    public bool? AllowNoneIngressClass { get; set; }

    /// <summary>
    /// Gets or Sets EnableResourceOverCommit
    /// </summary>
    [JsonPropertyName("EnableResourceOverCommit")]
    public bool? EnableResourceOverCommit { get; set; }

    /// <summary>
    /// Gets or Sets IngressAvailabilityPerNamespace
    /// </summary>
    [JsonPropertyName("IngressAvailabilityPerNamespace")]
    public bool? IngressAvailabilityPerNamespace { get; set; }

    /// <summary>
    /// Gets or Sets IngressClasses
    /// </summary>
    [JsonPropertyName("IngressClasses")]
    public List<PortainerKubernetesIngressClassConfig> IngressClasses { get; set; }

    /// <summary>
    /// Gets or Sets ResourceOverCommitPercentage
    /// </summary>
    [JsonPropertyName("ResourceOverCommitPercentage")]
    public int? ResourceOverCommitPercentage { get; set; }

    /// <summary>
    /// Gets or Sets RestrictDefaultNamespace
    /// </summary>
    [JsonPropertyName("RestrictDefaultNamespace")]
    public bool? RestrictDefaultNamespace { get; set; }

    /// <summary>
    /// Gets or Sets StorageClasses
    /// </summary>
    [JsonPropertyName("StorageClasses")]
    public List<PortainerKubernetesStorageClassConfig> StorageClasses { get; set; }

    /// <summary>
    /// Gets or Sets UseLoadBalancer
    /// </summary>
    [JsonPropertyName("UseLoadBalancer")]
    public bool? UseLoadBalancer { get; set; }

    /// <summary>
    /// Gets or Sets UseServerMetrics
    /// </summary>
    [JsonPropertyName("UseServerMetrics")]
    public bool? UseServerMetrics { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerKubernetesConfiguration {\n");
        sb.Append("  AllowNoneIngressClass: ").Append(AllowNoneIngressClass).Append("\n");
        sb.Append("  EnableResourceOverCommit: ").Append(EnableResourceOverCommit).Append("\n");
        sb.Append("  IngressAvailabilityPerNamespace: ").Append(IngressAvailabilityPerNamespace).Append("\n");
        sb.Append("  IngressClasses: ").Append(IngressClasses).Append("\n");
        sb.Append("  ResourceOverCommitPercentage: ").Append(ResourceOverCommitPercentage).Append("\n");
        sb.Append("  RestrictDefaultNamespace: ").Append(RestrictDefaultNamespace).Append("\n");
        sb.Append("  StorageClasses: ").Append(StorageClasses).Append("\n");
        sb.Append("  UseLoadBalancer: ").Append(UseLoadBalancer).Append("\n");
        sb.Append("  UseServerMetrics: ").Append(UseServerMetrics).Append("\n");
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