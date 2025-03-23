#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class GittypesGitAuthentication {
    /// <summary>
    /// Git credentials identifier when the value is not 0 When the value is 0, Username and Password are set without using saved credential This is introduced since 2.15.0
    /// </summary>
    /// <value>Git credentials identifier when the value is not 0 When the value is 0, Username and Password are set without using saved credential This is introduced since 2.15.0</value>
    [JsonPropertyName("gitCredentialID")]
    public int? GitCredentialID { get; set; }

    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [JsonPropertyName("password")]
    public string Password { get; set; }

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
        sb.Append("class GittypesGitAuthentication {\n");
        sb.Append("  GitCredentialID: ").Append(GitCredentialID).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
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