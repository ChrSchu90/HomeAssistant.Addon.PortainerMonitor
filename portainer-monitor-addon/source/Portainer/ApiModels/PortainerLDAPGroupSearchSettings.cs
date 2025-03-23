#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerLDAPGroupSearchSettings {
    /// <summary>
    /// LDAP attribute which denotes the group membership
    /// </summary>
    /// <value>LDAP attribute which denotes the group membership</value>
    [JsonPropertyName("GroupAttribute")]
    public string GroupAttribute { get; set; }

    /// <summary>
    /// The distinguished name of the element from which the LDAP server will search for groups
    /// </summary>
    /// <value>The distinguished name of the element from which the LDAP server will search for groups</value>
    [JsonPropertyName("GroupBaseDN")]
    public string GroupBaseDN { get; set; }

    /// <summary>
    /// The LDAP search filter used to select group elements, optional
    /// </summary>
    /// <value>The LDAP search filter used to select group elements, optional</value>
    [JsonPropertyName("GroupFilter")]
    public string GroupFilter { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerLDAPGroupSearchSettings {\n");
        sb.Append("  GroupAttribute: ").Append(GroupAttribute).Append("\n");
        sb.Append("  GroupBaseDN: ").Append(GroupBaseDN).Append("\n");
        sb.Append("  GroupFilter: ").Append(GroupFilter).Append("\n");
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