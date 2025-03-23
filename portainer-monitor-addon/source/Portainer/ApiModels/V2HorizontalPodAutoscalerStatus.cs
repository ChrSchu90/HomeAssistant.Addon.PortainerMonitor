#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V2HorizontalPodAutoscalerStatus {
    /// <summary>
    /// conditions is the set of conditions required for this autoscaler to scale its target, and indicates whether or not those conditions are met. +patchMergeKey=type +patchStrategy=merge +listType=map +listMapKey=type +optional
    /// </summary>
    /// <value>conditions is the set of conditions required for this autoscaler to scale its target, and indicates whether or not those conditions are met. +patchMergeKey=type +patchStrategy=merge +listType=map +listMapKey=type +optional</value>
    [JsonPropertyName("conditions")]
    public List<V2HorizontalPodAutoscalerCondition> Conditions { get; set; }

    /// <summary>
    /// currentMetrics is the last read state of the metrics used by this autoscaler. +listType=atomic +optional
    /// </summary>
    /// <value>currentMetrics is the last read state of the metrics used by this autoscaler. +listType=atomic +optional</value>
    [JsonPropertyName("currentMetrics")]
    public List<V2MetricStatus> CurrentMetrics { get; set; }

    /// <summary>
    /// currentReplicas is current number of replicas of pods managed by this autoscaler, as last seen by the autoscaler. +optional
    /// </summary>
    /// <value>currentReplicas is current number of replicas of pods managed by this autoscaler, as last seen by the autoscaler. +optional</value>
    [JsonPropertyName("currentReplicas")]
    public int? CurrentReplicas { get; set; }

    /// <summary>
    /// desiredReplicas is the desired number of replicas of pods managed by this autoscaler, as last calculated by the autoscaler.
    /// </summary>
    /// <value>desiredReplicas is the desired number of replicas of pods managed by this autoscaler, as last calculated by the autoscaler.</value>
    [JsonPropertyName("desiredReplicas")]
    public int? DesiredReplicas { get; set; }

    /// <summary>
    /// lastScaleTime is the last time the HorizontalPodAutoscaler scaled the number of pods, used by the autoscaler to control how often the number of pods is changed. +optional
    /// </summary>
    /// <value>lastScaleTime is the last time the HorizontalPodAutoscaler scaled the number of pods, used by the autoscaler to control how often the number of pods is changed. +optional</value>
    [JsonPropertyName("lastScaleTime")]
    public string LastScaleTime { get; set; }

    /// <summary>
    /// observedGeneration is the most recent generation observed by this autoscaler. +optional
    /// </summary>
    /// <value>observedGeneration is the most recent generation observed by this autoscaler. +optional</value>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V2HorizontalPodAutoscalerStatus {\n");
        sb.Append("  Conditions: ").Append(Conditions).Append("\n");
        sb.Append("  CurrentMetrics: ").Append(CurrentMetrics).Append("\n");
        sb.Append("  CurrentReplicas: ").Append(CurrentReplicas).Append("\n");
        sb.Append("  DesiredReplicas: ").Append(DesiredReplicas).Append("\n");
        sb.Append("  LastScaleTime: ").Append(LastScaleTime).Append("\n");
        sb.Append("  ObservedGeneration: ").Append(ObservedGeneration).Append("\n");
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