#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerGitlabRegistryData {
    /// <summary>
    /// Gets or Sets InstanceURL
    /// </summary>
    [JsonPropertyName("InstanceURL")]
    public string InstanceURL { get; set; }

    /// <summary>
    /// Gets or Sets ProjectId
    /// </summary>
    [JsonPropertyName("ProjectId")]
    public int? ProjectId { get; set; }

    /// <summary>
    /// Gets or Sets ProjectPath
    /// </summary>
    [JsonPropertyName("ProjectPath")]
    public string ProjectPath { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerGitlabRegistryData {\n");
        sb.Append("  InstanceURL: ").Append(InstanceURL).Append("\n");
        sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
        sb.Append("  ProjectPath: ").Append(ProjectPath).Append("\n");
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