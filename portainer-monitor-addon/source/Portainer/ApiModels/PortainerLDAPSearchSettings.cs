#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerLDAPSearchSettings {
    /// <summary>
    /// The distinguished name of the element from which the LDAP server will search for users
    /// </summary>
    /// <value>The distinguished name of the element from which the LDAP server will search for users</value>
    [JsonPropertyName("BaseDN")]
    public string BaseDN { get; set; }

    /// <summary>
    /// Optional LDAP search filter used to select user elements
    /// </summary>
    /// <value>Optional LDAP search filter used to select user elements</value>
    [JsonPropertyName("Filter")]
    public string Filter { get; set; }

    /// <summary>
    /// LDAP attribute which denotes the username
    /// </summary>
    /// <value>LDAP attribute which denotes the username</value>
    [JsonPropertyName("UserNameAttribute")]
    public string UserNameAttribute { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerLDAPSearchSettings {\n");
        sb.Append("  BaseDN: ").Append(BaseDN).Append("\n");
        sb.Append("  Filter: ").Append(Filter).Append("\n");
        sb.Append("  UserNameAttribute: ").Append(UserNameAttribute).Append("\n");
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