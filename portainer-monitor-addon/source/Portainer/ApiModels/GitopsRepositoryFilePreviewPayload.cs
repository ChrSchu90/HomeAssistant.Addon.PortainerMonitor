#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class GitopsRepositoryFilePreviewPayload {
    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [JsonPropertyName("password")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or Sets Reference
    /// </summary>
    [JsonPropertyName("reference")]
    public string Reference { get; set; }

    /// <summary>
    /// Gets or Sets Repository
    /// </summary>
    [JsonPropertyName("repository")]
    public string Repository { get; set; }

    /// <summary>
    /// Path to file whose content will be read
    /// </summary>
    /// <value>Path to file whose content will be read</value>
    [JsonPropertyName("targetFile")]
    public string TargetFile { get; set; }

    /// <summary>
    /// TLSSkipVerify skips SSL verification when cloning the Git repository
    /// </summary>
    /// <value>TLSSkipVerify skips SSL verification when cloning the Git repository</value>
    [JsonPropertyName("tlsskipVerify")]
    public bool? TlsskipVerify { get; set; }

    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class GitopsRepositoryFilePreviewPayload {\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  Reference: ").Append(Reference).Append("\n");
        sb.Append("  Repository: ").Append(Repository).Append("\n");
        sb.Append("  TargetFile: ").Append(TargetFile).Append("\n");
        sb.Append("  TlsskipVerify: ").Append(TlsskipVerify).Append("\n");
        sb.Append("  Username: ").Append(Username).Append("\n");
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