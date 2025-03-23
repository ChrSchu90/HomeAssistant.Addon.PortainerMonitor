#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class ReleaseChart {
    /// <summary>
    /// Files are miscellaneous files in a chart archive, e.g. README, LICENSE, etc.
    /// </summary>
    /// <value>Files are miscellaneous files in a chart archive, e.g. README, LICENSE, etc.</value>
    [JsonPropertyName("files")]
    public List<ReleaseFile> Files { get; set; }

    /// <summary>
    /// Lock is the contents of Chart.lock.
    /// </summary>
    /// <value>Lock is the contents of Chart.lock.</value>
    [JsonPropertyName("lock")]
    public ReleaseLock Lock { get; set; }

    /// <summary>
    /// Metadata is the contents of the Chartfile.
    /// </summary>
    /// <value>Metadata is the contents of the Chartfile.</value>
    [JsonPropertyName("metadata")]
    public ReleaseMetadata Metadata { get; set; }

    /// <summary>
    /// Schema is an optional JSON schema for imposing structure on Values
    /// </summary>
    /// <value>Schema is an optional JSON schema for imposing structure on Values</value>
    [JsonPropertyName("schema")]
    public List<int?> Schema { get; set; }

    /// <summary>
    /// Templates for this chart.
    /// </summary>
    /// <value>Templates for this chart.</value>
    [JsonPropertyName("templates")]
    public List<ReleaseFile> Templates { get; set; }

    /// <summary>
    /// Values are default config for this chart.
    /// </summary>
    /// <value>Values are default config for this chart.</value>
    [JsonPropertyName("values")]
    public Dictionary<string, Object> Values { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class ReleaseChart {\n");
        sb.Append("  Files: ").Append(Files).Append("\n");
        sb.Append("  Lock: ").Append(Lock).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
        sb.Append("  Schema: ").Append(Schema).Append("\n");
        sb.Append("  Templates: ").Append(Templates).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
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