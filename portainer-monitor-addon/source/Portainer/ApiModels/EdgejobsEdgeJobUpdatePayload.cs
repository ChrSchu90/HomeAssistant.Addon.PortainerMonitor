#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EdgejobsEdgeJobUpdatePayload {
    /// <summary>
    /// Gets or Sets CronExpression
    /// </summary>
    [JsonPropertyName("cronExpression")]
    public string CronExpression { get; set; }

    /// <summary>
    /// Gets or Sets EdgeGroups
    /// </summary>
    [JsonPropertyName("edgeGroups")]
    public List<int?> EdgeGroups { get; set; }

    /// <summary>
    /// Gets or Sets Endpoints
    /// </summary>
    [JsonPropertyName("endpoints")]
    public List<int?> Endpoints { get; set; }

    /// <summary>
    /// Gets or Sets FileContent
    /// </summary>
    [JsonPropertyName("fileContent")]
    public string FileContent { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Recurring
    /// </summary>
    [JsonPropertyName("recurring")]
    public bool? Recurring { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class EdgejobsEdgeJobUpdatePayload {\n");
        sb.Append("  CronExpression: ").Append(CronExpression).Append("\n");
        sb.Append("  EdgeGroups: ").Append(EdgeGroups).Append("\n");
        sb.Append("  Endpoints: ").Append(Endpoints).Append("\n");
        sb.Append("  FileContent: ").Append(FileContent).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Recurring: ").Append(Recurring).Append("\n");
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