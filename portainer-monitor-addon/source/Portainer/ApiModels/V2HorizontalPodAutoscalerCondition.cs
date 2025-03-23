#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V2HorizontalPodAutoscalerCondition {
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another +optional
    /// </summary>
    /// <value>lastTransitionTime is the last time the condition transitioned from one status to another +optional</value>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human-readable explanation containing details about the transition +optional
    /// </summary>
    /// <value>message is a human-readable explanation containing details about the transition +optional</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>
    /// reason is the reason for the condition's last transition. +optional
    /// </summary>
    /// <value>reason is the reason for the condition's last transition. +optional</value>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>
    /// status is the status of the condition (True, False, Unknown)
    /// </summary>
    /// <value>status is the status of the condition (True, False, Unknown)</value>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>
    /// type describes the current condition
    /// </summary>
    /// <value>type describes the current condition</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V2HorizontalPodAutoscalerCondition {\n");
        sb.Append("  LastTransitionTime: ").Append(LastTransitionTime).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Reason: ").Append(Reason).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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