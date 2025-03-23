#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerAutoUpdateSettings {
    /// <summary>
    /// Pull latest image
    /// </summary>
    /// <value>Pull latest image</value>
    [JsonPropertyName("forcePullImage")]
    public bool? ForcePullImage { get; set; }

    /// <summary>
    /// Force update ignores repo changes
    /// </summary>
    /// <value>Force update ignores repo changes</value>
    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    /// <summary>
    /// Auto update interval
    /// </summary>
    /// <value>Auto update interval</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }

    /// <summary>
    /// Autoupdate job id
    /// </summary>
    /// <value>Autoupdate job id</value>
    [JsonPropertyName("jobID")]
    public string JobID { get; set; }

    /// <summary>
    /// A UUID generated from client
    /// </summary>
    /// <value>A UUID generated from client</value>
    [JsonPropertyName("webhook")]
    public string Webhook { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerAutoUpdateSettings {\n");
        sb.Append("  ForcePullImage: ").Append(ForcePullImage).Append("\n");
        sb.Append("  ForceUpdate: ").Append(ForceUpdate).Append("\n");
        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  JobID: ").Append(JobID).Append("\n");
        sb.Append("  Webhook: ").Append(Webhook).Append("\n");
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