#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerEndpointGroup {
    /// <summary>
    /// Gets or Sets AuthorizedTeams
    /// </summary>
    [JsonPropertyName("AuthorizedTeams")]
    public List<int?> AuthorizedTeams { get; set; }

    /// <summary>
    /// Deprecated in DBVersion == 18
    /// </summary>
    /// <value>Deprecated in DBVersion == 18</value>
    [JsonPropertyName("AuthorizedUsers")]
    public List<int?> AuthorizedUsers { get; set; }

    /// <summary>
    /// Description associated to the environment(endpoint) group
    /// </summary>
    /// <value>Description associated to the environment(endpoint) group</value>
    [JsonPropertyName("Description")]
    public string Description { get; set; }

    /// <summary>
    /// Environment(Endpoint) group Identifier
    /// </summary>
    /// <value>Environment(Endpoint) group Identifier</value>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Deprecated fields
    /// </summary>
    /// <value>Deprecated fields</value>
    [JsonPropertyName("Labels")]
    public List<PortainerPair> Labels { get; set; }

    /// <summary>
    /// Environment(Endpoint) group name
    /// </summary>
    /// <value>Environment(Endpoint) group name</value>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// List of tags associated to this environment(endpoint) group
    /// </summary>
    /// <value>List of tags associated to this environment(endpoint) group</value>
    [JsonPropertyName("TagIds")]
    public List<int?> TagIds { get; set; }

    /// <summary>
    /// Deprecated in DBVersion == 22
    /// </summary>
    /// <value>Deprecated in DBVersion == 22</value>
    [JsonPropertyName("Tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Gets or Sets TeamAccessPolicies
    /// </summary>
    [JsonPropertyName("TeamAccessPolicies")]
    public PortainerTeamAccessPolicies TeamAccessPolicies { get; set; }

    /// <summary>
    /// Gets or Sets UserAccessPolicies
    /// </summary>
    [JsonPropertyName("UserAccessPolicies")]
    public PortainerUserAccessPolicies UserAccessPolicies { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerEndpointGroup {\n");
        sb.Append("  AuthorizedTeams: ").Append(AuthorizedTeams).Append("\n");
        sb.Append("  AuthorizedUsers: ").Append(AuthorizedUsers).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Labels: ").Append(Labels).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  TagIds: ").Append(TagIds).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  TeamAccessPolicies: ").Append(TeamAccessPolicies).Append("\n");
        sb.Append("  UserAccessPolicies: ").Append(UserAccessPolicies).Append("\n");
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