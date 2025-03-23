#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerStackDeploymentInfo {
    /// <summary>
    /// ConfigHash is the commit hash of the git repository used for deploying the stack
    /// </summary>
    /// <value>ConfigHash is the commit hash of the git repository used for deploying the stack</value>
    [JsonPropertyName("ConfigHash")]
    public string ConfigHash { get; set; }

    /// <summary>
    /// FileVersion is the version of the stack file, used to detect changes
    /// </summary>
    /// <value>FileVersion is the version of the stack file, used to detect changes</value>
    [JsonPropertyName("FileVersion")]
    public int? FileVersion { get; set; }

    /// <summary>
    /// Version is the version of the stack and also is the deployed version in edge agent
    /// </summary>
    /// <value>Version is the version of the stack and also is the deployed version in edge agent</value>
    [JsonPropertyName("Version")]
    public int? Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerStackDeploymentInfo {\n");
        sb.Append("  ConfigHash: ").Append(ConfigHash).Append("\n");
        sb.Append("  FileVersion: ").Append(FileVersion).Append("\n");
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