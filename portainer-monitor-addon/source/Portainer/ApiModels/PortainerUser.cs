#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerUser {
    /// <summary>
    /// User Identifier
    /// </summary>
    /// <value>User Identifier</value>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>
    /// User role (1 for administrator account and 2 for regular account)
    /// </summary>
    /// <value>User role (1 for administrator account and 2 for regular account)</value>
    [JsonPropertyName("Role")]
    public int? Role { get; set; }

    /// <summary>
    /// Gets or Sets ThemeSettings
    /// </summary>
    [JsonPropertyName("ThemeSettings")]
    public PortainerUserThemeSettings ThemeSettings { get; set; }

    /// <summary>
    /// Gets or Sets TokenIssueAt
    /// </summary>
    [JsonPropertyName("TokenIssueAt")]
    public int? TokenIssueAt { get; set; }

    /// <summary>
    /// Gets or Sets UseCache
    /// </summary>
    [JsonPropertyName("UseCache")]
    public bool? UseCache { get; set; }

    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [JsonPropertyName("UserTheme")]
    public string UserTheme { get; set; }

    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [JsonPropertyName("Username")]
    public string Username { get; set; }

    /// <summary>
    /// Deprecated in DBVersion == 25
    /// </summary>
    /// <value>Deprecated in DBVersion == 25</value>
    [JsonPropertyName("endpointAuthorizations")]
    public PortainerEndpointAuthorizations EndpointAuthorizations { get; set; }

    /// <summary>
    /// Deprecated in DBVersion == 25
    /// </summary>
    /// <value>Deprecated in DBVersion == 25</value>
    [JsonPropertyName("portainerAuthorizations")]
    public PortainerAuthorizations PortainerAuthorizations { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerUser {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Role: ").Append(Role).Append("\n");
        sb.Append("  ThemeSettings: ").Append(ThemeSettings).Append("\n");
        sb.Append("  TokenIssueAt: ").Append(TokenIssueAt).Append("\n");
        sb.Append("  UseCache: ").Append(UseCache).Append("\n");
        sb.Append("  UserTheme: ").Append(UserTheme).Append("\n");
        sb.Append("  Username: ").Append(Username).Append("\n");
        sb.Append("  EndpointAuthorizations: ").Append(EndpointAuthorizations).Append("\n");
        sb.Append("  PortainerAuthorizations: ").Append(PortainerAuthorizations).Append("\n");
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