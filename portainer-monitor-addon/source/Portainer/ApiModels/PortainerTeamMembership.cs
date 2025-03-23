#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerTeamMembership {
    /// <summary>
    /// Membership Identifier
    /// </summary>
    /// <value>Membership Identifier</value>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Team role (1 for team leader and 2 for team member)
    /// </summary>
    /// <value>Team role (1 for team leader and 2 for team member)</value>
    [JsonPropertyName("Role")]
    public int? Role { get; set; }

    /// <summary>
    /// Team identifier
    /// </summary>
    /// <value>Team identifier</value>
    [JsonPropertyName("TeamID")]
    public int? TeamID { get; set; }

    /// <summary>
    /// User identifier
    /// </summary>
    /// <value>User identifier</value>
    [JsonPropertyName("UserID")]
    public int? UserID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerTeamMembership {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Role: ").Append(Role).Append("\n");
        sb.Append("  TeamID: ").Append(TeamID).Append("\n");
        sb.Append("  UserID: ").Append(UserID).Append("\n");
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