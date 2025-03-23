#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sJob {
    /// <summary>
    /// Gets or Sets BackoffLimit
    /// </summary>
    [JsonPropertyName("BackoffLimit")]
    public int? BackoffLimit { get; set; }

    /// <summary>
    /// Gets or Sets Command
    /// </summary>
    [JsonPropertyName("Command")]
    public string Command { get; set; }

    /// <summary>
    /// Gets or Sets Completions
    /// </summary>
    [JsonPropertyName("Completions")]
    public int? Completions { get; set; }

    /// <summary>
    /// Gets or Sets Container
    /// </summary>
    [JsonPropertyName("Container")]
    public V1Container Container { get; set; }

    /// <summary>
    /// Gets or Sets Duration
    /// </summary>
    [JsonPropertyName("Duration")]
    public string Duration { get; set; }

    /// <summary>
    /// Gets or Sets FailedReason
    /// </summary>
    [JsonPropertyName("FailedReason")]
    public string FailedReason { get; set; }

    /// <summary>
    /// Gets or Sets FinishTime
    /// </summary>
    [JsonPropertyName("FinishTime")]
    public string FinishTime { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("Id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets IsSystem
    /// </summary>
    [JsonPropertyName("IsSystem")]
    public bool? IsSystem { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    [JsonPropertyName("Namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Gets or Sets PodName
    /// </summary>
    [JsonPropertyName("PodName")]
    public string PodName { get; set; }

    /// <summary>
    /// Gets or Sets StartTime
    /// </summary>
    [JsonPropertyName("StartTime")]
    public string StartTime { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("Status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sJob {\n");
        sb.Append("  BackoffLimit: ").Append(BackoffLimit).Append("\n");
        sb.Append("  Command: ").Append(Command).Append("\n");
        sb.Append("  Completions: ").Append(Completions).Append("\n");
        sb.Append("  Container: ").Append(Container).Append("\n");
        sb.Append("  Duration: ").Append(Duration).Append("\n");
        sb.Append("  FailedReason: ").Append(FailedReason).Append("\n");
        sb.Append("  FinishTime: ").Append(FinishTime).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  PodName: ").Append(PodName).Append("\n");
        sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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