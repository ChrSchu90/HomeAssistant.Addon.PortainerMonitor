#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EndpointgroupsEndpointGroupUpdatePayload {
    /// <summary>
    /// Environment(Endpoint) group description
    /// </summary>
    /// <value>Environment(Endpoint) group description</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Environment(Endpoint) group name
    /// </summary>
    /// <value>Environment(Endpoint) group name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// List of tag identifiers associated to the environment(endpoint) group
    /// </summary>
    /// <value>List of tag identifiers associated to the environment(endpoint) group</value>
    [JsonPropertyName("tagIDs")]
    public List<int?> TagIDs { get; set; }

    /// <summary>
    /// Gets or Sets TeamAccessPolicies
    /// </summary>
    [JsonPropertyName("teamAccessPolicies")]
    public PortainerTeamAccessPolicies TeamAccessPolicies { get; set; }

    /// <summary>
    /// Gets or Sets UserAccessPolicies
    /// </summary>
    [JsonPropertyName("userAccessPolicies")]
    public PortainerUserAccessPolicies UserAccessPolicies { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class EndpointgroupsEndpointGroupUpdatePayload {\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  TagIDs: ").Append(TagIDs).Append("\n");
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