#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerEdgeJob {
    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    [JsonPropertyName("Created")]
    public int? Created { get; set; }

    /// <summary>
    /// Gets or Sets CronExpression
    /// </summary>
    [JsonPropertyName("CronExpression")]
    public string CronExpression { get; set; }

    /// <summary>
    /// Gets or Sets EdgeGroups
    /// </summary>
    [JsonPropertyName("EdgeGroups")]
    public List<int?> EdgeGroups { get; set; }

    /// <summary>
    /// Gets or Sets Endpoints
    /// </summary>
    [JsonPropertyName("Endpoints")]
    public Dictionary<string, PortainerEdgeJobEndpointMeta> Endpoints { get; set; }

    /// <summary>
    /// EdgeJob Identifier
    /// </summary>
    /// <value>EdgeJob Identifier</value>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Recurring
    /// </summary>
    [JsonPropertyName("Recurring")]
    public bool? Recurring { get; set; }

    /// <summary>
    /// Gets or Sets ScriptPath
    /// </summary>
    [JsonPropertyName("ScriptPath")]
    public string ScriptPath { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [JsonPropertyName("Version")]
    public int? Version { get; set; }

    /// <summary>
    /// Field used for log collection of Endpoints belonging to EdgeGroups
    /// </summary>
    /// <value>Field used for log collection of Endpoints belonging to EdgeGroups</value>
    [JsonPropertyName("groupLogsCollection")]
    public Dictionary<string, PortainerEdgeJobEndpointMeta> GroupLogsCollection { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerEdgeJob {\n");
        sb.Append("  Created: ").Append(Created).Append("\n");
        sb.Append("  CronExpression: ").Append(CronExpression).Append("\n");
        sb.Append("  EdgeGroups: ").Append(EdgeGroups).Append("\n");
        sb.Append("  Endpoints: ").Append(Endpoints).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Recurring: ").Append(Recurring).Append("\n");
        sb.Append("  ScriptPath: ").Append(ScriptPath).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  GroupLogsCollection: ").Append(GroupLogsCollection).Append("\n");
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