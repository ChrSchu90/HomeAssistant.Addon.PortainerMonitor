#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class ReleaseHookExecution {
    /// <summary>
    /// CompletedAt indicates the date/time this hook was completed.
    /// </summary>
    /// <value>CompletedAt indicates the date/time this hook was completed.</value>
    [JsonPropertyName("completed_at")]
    public string CompletedAt { get; set; }

    /// <summary>
    /// Phase indicates whether the hook completed successfully
    /// </summary>
    /// <value>Phase indicates whether the hook completed successfully</value>
    [JsonPropertyName("phase")]
    public string Phase { get; set; }

    /// <summary>
    /// StartedAt indicates the date/time this hook was started
    /// </summary>
    /// <value>StartedAt indicates the date/time this hook was started</value>
    [JsonPropertyName("started_at")]
    public string StartedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class ReleaseHookExecution {\n");
        sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
        sb.Append("  Phase: ").Append(Phase).Append("\n");
        sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
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