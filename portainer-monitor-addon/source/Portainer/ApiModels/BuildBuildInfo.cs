#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class BuildBuildInfo {
    /// <summary>
    /// Gets or Sets BuildNumber
    /// </summary>
    [JsonPropertyName("buildNumber")]
    public string BuildNumber { get; set; }

    /// <summary>
    /// Gets or Sets GitCommit
    /// </summary>
    [JsonPropertyName("gitCommit")]
    public string GitCommit { get; set; }

    /// <summary>
    /// Gets or Sets GoVersion
    /// </summary>
    [JsonPropertyName("goVersion")]
    public string GoVersion { get; set; }

    /// <summary>
    /// Gets or Sets ImageTag
    /// </summary>
    [JsonPropertyName("imageTag")]
    public string ImageTag { get; set; }

    /// <summary>
    /// Gets or Sets NodejsVersion
    /// </summary>
    [JsonPropertyName("nodejsVersion")]
    public string NodejsVersion { get; set; }

    /// <summary>
    /// Gets or Sets WebpackVersion
    /// </summary>
    [JsonPropertyName("webpackVersion")]
    public string WebpackVersion { get; set; }

    /// <summary>
    /// Gets or Sets YarnVersion
    /// </summary>
    [JsonPropertyName("yarnVersion")]
    public string YarnVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class BuildBuildInfo {\n");
        sb.Append("  BuildNumber: ").Append(BuildNumber).Append("\n");
        sb.Append("  GitCommit: ").Append(GitCommit).Append("\n");
        sb.Append("  GoVersion: ").Append(GoVersion).Append("\n");
        sb.Append("  ImageTag: ").Append(ImageTag).Append("\n");
        sb.Append("  NodejsVersion: ").Append(NodejsVersion).Append("\n");
        sb.Append("  WebpackVersion: ").Append(WebpackVersion).Append("\n");
        sb.Append("  YarnVersion: ").Append(YarnVersion).Append("\n");
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