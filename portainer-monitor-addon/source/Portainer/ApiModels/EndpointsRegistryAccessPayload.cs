#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EndpointsRegistryAccessPayload {
    /// <summary>
    /// Gets or Sets Namespaces
    /// </summary>
    [JsonPropertyName("namespaces")]
    public List<string> Namespaces { get; set; }

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
        sb.Append("class EndpointsRegistryAccessPayload {\n");
        sb.Append("  Namespaces: ").Append(Namespaces).Append("\n");
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