#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class GittypesRepoConfig {
    /// <summary>
    /// Git credentials
    /// </summary>
    /// <value>Git credentials</value>
    [JsonPropertyName("authentication")]
    public GittypesGitAuthentication Authentication { get; set; }

    /// <summary>
    /// Path to where the config file is in this url/refName
    /// </summary>
    /// <value>Path to where the config file is in this url/refName</value>
    [JsonPropertyName("configFilePath")]
    public string ConfigFilePath { get; set; }

    /// <summary>
    /// Repository hash
    /// </summary>
    /// <value>Repository hash</value>
    [JsonPropertyName("configHash")]
    public string ConfigHash { get; set; }

    /// <summary>
    /// The reference name
    /// </summary>
    /// <value>The reference name</value>
    [JsonPropertyName("referenceName")]
    public string ReferenceName { get; set; }

    /// <summary>
    /// TLSSkipVerify skips SSL verification when cloning the Git repository
    /// </summary>
    /// <value>TLSSkipVerify skips SSL verification when cloning the Git repository</value>
    [JsonPropertyName("tlsskipVerify")]
    public bool? TlsskipVerify { get; set; }

    /// <summary>
    /// The repo url
    /// </summary>
    /// <value>The repo url</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class GittypesRepoConfig {\n");
        sb.Append("  Authentication: ").Append(Authentication).Append("\n");
        sb.Append("  ConfigFilePath: ").Append(ConfigFilePath).Append("\n");
        sb.Append("  ConfigHash: ").Append(ConfigHash).Append("\n");
        sb.Append("  ReferenceName: ").Append(ReferenceName).Append("\n");
        sb.Append("  TlsskipVerify: ").Append(TlsskipVerify).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
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