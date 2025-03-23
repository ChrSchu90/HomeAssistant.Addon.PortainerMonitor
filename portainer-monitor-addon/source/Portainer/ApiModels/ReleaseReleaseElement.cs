#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class ReleaseReleaseElement {
    /// <summary>
    /// Gets or Sets AppVersion
    /// </summary>
    [JsonPropertyName("app_version")]
    public string AppVersion { get; set; }

    /// <summary>
    /// Gets or Sets Chart
    /// </summary>
    [JsonPropertyName("chart")]
    public string Chart { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Gets or Sets Revision
    /// </summary>
    [JsonPropertyName("revision")]
    public string Revision { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets Updated
    /// </summary>
    [JsonPropertyName("updated")]
    public string Updated { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class ReleaseReleaseElement {\n");
        sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
        sb.Append("  Chart: ").Append(Chart).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  Revision: ").Append(Revision).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Updated: ").Append(Updated).Append("\n");
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