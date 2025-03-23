#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EndpointedgeEdgeJobResponse {
    /// <summary>
    /// Whether to collect logs
    /// </summary>
    /// <value>Whether to collect logs</value>
    [JsonPropertyName("CollectLogs")]
    public bool? CollectLogs { get; set; }

    /// <summary>
    /// A cron expression to schedule this job
    /// </summary>
    /// <value>A cron expression to schedule this job</value>
    [JsonPropertyName("CronExpression")]
    public string CronExpression { get; set; }

    /// <summary>
    /// EdgeJob Identifier
    /// </summary>
    /// <value>EdgeJob Identifier</value>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Script to run
    /// </summary>
    /// <value>Script to run</value>
    [JsonPropertyName("Script")]
    public string Script { get; set; }

    /// <summary>
    /// Version of this EdgeJob
    /// </summary>
    /// <value>Version of this EdgeJob</value>
    [JsonPropertyName("Version")]
    public int? Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class EndpointedgeEdgeJobResponse {\n");
        sb.Append("  CollectLogs: ").Append(CollectLogs).Append("\n");
        sb.Append("  CronExpression: ").Append(CronExpression).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Script: ").Append(Script).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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