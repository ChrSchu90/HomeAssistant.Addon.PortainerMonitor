#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class BackupRestorePayload {
    /// <summary>
    /// Gets or Sets FileContent
    /// </summary>
    [JsonPropertyName("fileContent")]
    public List<int?> FileContent { get; set; }

    /// <summary>
    /// Gets or Sets FileName
    /// </summary>
    [JsonPropertyName("fileName")]
    public string FileName { get; set; }

    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [JsonPropertyName("password")]
    public string Password { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class BackupRestorePayload {\n");
        sb.Append("  FileContent: ").Append(FileContent).Append("\n");
        sb.Append("  FileName: ").Append(FileName).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
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