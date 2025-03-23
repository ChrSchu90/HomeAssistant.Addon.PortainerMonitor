#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class MotdMotdResponse {
    /// <summary>
    /// Gets or Sets ContentLayout
    /// </summary>
    [JsonPropertyName("ContentLayout")]
    public Dictionary<string, string> ContentLayout { get; set; }

    /// <summary>
    /// Gets or Sets Hash
    /// </summary>
    [JsonPropertyName("Hash")]
    public List<int?> Hash { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [JsonPropertyName("Message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Style
    /// </summary>
    [JsonPropertyName("Style")]
    public string Style { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [JsonPropertyName("Title")]
    public string Title { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class MotdMotdResponse {\n");
        sb.Append("  ContentLayout: ").Append(ContentLayout).Append("\n");
        sb.Append("  Hash: ").Append(Hash).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Style: ").Append(Style).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
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