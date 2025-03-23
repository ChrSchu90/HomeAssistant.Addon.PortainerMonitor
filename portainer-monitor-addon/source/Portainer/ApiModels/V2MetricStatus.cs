#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V2MetricStatus {
    /// <summary>
    /// container resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing a single container in each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the \"pods\" source. +optional
    /// </summary>
    /// <value>container resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing a single container in each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the \"pods\" source. +optional</value>
    [JsonPropertyName("containerResource")]
    public V2ContainerResourceMetricStatus ContainerResource { get; set; }

    /// <summary>
    /// external refers to a global metric that is not associated with any Kubernetes object. It allows autoscaling based on information coming from components running outside of cluster (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster). +optional
    /// </summary>
    /// <value>external refers to a global metric that is not associated with any Kubernetes object. It allows autoscaling based on information coming from components running outside of cluster (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster). +optional</value>
    [JsonPropertyName("external")]
    public V2ExternalMetricStatus External { get; set; }

    /// <summary>
    /// object refers to a metric describing a single kubernetes object (for example, hits-per-second on an Ingress object). +optional
    /// </summary>
    /// <value>object refers to a metric describing a single kubernetes object (for example, hits-per-second on an Ingress object). +optional</value>
    [JsonPropertyName("object")]
    public V2ObjectMetricStatus Object { get; set; }

    /// <summary>
    /// pods refers to a metric describing each pod in the current scale target (for example, transactions-processed-per-second).  The values will be averaged together before being compared to the target value. +optional
    /// </summary>
    /// <value>pods refers to a metric describing each pod in the current scale target (for example, transactions-processed-per-second).  The values will be averaged together before being compared to the target value. +optional</value>
    [JsonPropertyName("pods")]
    public V2PodsMetricStatus Pods { get; set; }

    /// <summary>
    /// resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the \"pods\" source. +optional
    /// </summary>
    /// <value>resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the \"pods\" source. +optional</value>
    [JsonPropertyName("resource")]
    public V2ResourceMetricStatus Resource { get; set; }

    /// <summary>
    /// type is the type of metric source.  It will be one of \"ContainerResource\", \"External\", \"Object\", \"Pods\" or \"Resource\", each corresponds to a matching field in the object. Note: \"ContainerResource\" type is available on when the feature-gate HPAContainerMetrics is enabled
    /// </summary>
    /// <value>type is the type of metric source.  It will be one of \"ContainerResource\", \"External\", \"Object\", \"Pods\" or \"Resource\", each corresponds to a matching field in the object. Note: \"ContainerResource\" type is available on when the feature-gate HPAContainerMetrics is enabled</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V2MetricStatus {\n");
        sb.Append("  ContainerResource: ").Append(ContainerResource).Append("\n");
        sb.Append("  External: ").Append(External).Append("\n");
        sb.Append("  Object: ").Append(Object).Append("\n");
        sb.Append("  Pods: ").Append(Pods).Append("\n");
        sb.Append("  Resource: ").Append(Resource).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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