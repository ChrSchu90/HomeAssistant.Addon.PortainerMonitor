#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class ImagesImageResponse {
    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    [JsonPropertyName("created")]
    public int? Created { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets NodeName
    /// </summary>
    [JsonPropertyName("nodeName")]
    public string NodeName { get; set; }

    /// <summary>
    /// Gets or Sets Size
    /// </summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Used is true if the image is used by at least one container supplied only when withUsage is true
    /// </summary>
    /// <value>Used is true if the image is used by at least one container supplied only when withUsage is true</value>
    [JsonPropertyName("used")]
    public bool? Used { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class ImagesImageResponse {\n");
        sb.Append("  Created: ").Append(Created).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  NodeName: ").Append(NodeName).Append("\n");
        sb.Append("  Size: ").Append(Size).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  Used: ").Append(Used).Append("\n");
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