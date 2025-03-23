#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class FilesystemDirEntry {
    /// <summary>
    /// Gets or Sets Content
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; }

    /// <summary>
    /// Gets or Sets IsFile
    /// </summary>
    [JsonPropertyName("isFile")]
    public bool? IsFile { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    [JsonPropertyName("permissions")]
    public int? Permissions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class FilesystemDirEntry {\n");
        sb.Append("  Content: ").Append(Content).Append("\n");
        sb.Append("  IsFile: ").Append(IsFile).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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