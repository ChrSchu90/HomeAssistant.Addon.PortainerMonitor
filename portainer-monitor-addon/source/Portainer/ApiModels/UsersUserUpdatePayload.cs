#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class UsersUserUpdatePayload {
    /// <summary>
    /// Gets or Sets NewPassword
    /// </summary>
    [JsonPropertyName("newPassword")]
    public string NewPassword { get; set; }

    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [JsonPropertyName("password")]
    public string Password { get; set; }

    /// <summary>
    /// User role (1 for administrator account and 2 for regular account)
    /// </summary>
    /// <value>User role (1 for administrator account and 2 for regular account)</value>
    [JsonPropertyName("role")]
    public int? Role { get; set; }

    /// <summary>
    /// Gets or Sets Theme
    /// </summary>
    [JsonPropertyName("theme")]
    public UsersThemePayload Theme { get; set; }

    /// <summary>
    /// Gets or Sets UseCache
    /// </summary>
    [JsonPropertyName("useCache")]
    public bool? UseCache { get; set; }

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
        sb.Append("class UsersUserUpdatePayload {\n");
        sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  Role: ").Append(Role).Append("\n");
        sb.Append("  Theme: ").Append(Theme).Append("\n");
        sb.Append("  UseCache: ").Append(UseCache).Append("\n");
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