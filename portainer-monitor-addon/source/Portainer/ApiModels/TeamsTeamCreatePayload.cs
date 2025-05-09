#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class TeamsTeamCreatePayload {
    /// <summary>
    /// Name
    /// </summary>
    /// <value>Name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// TeamLeaders
    /// </summary>
    /// <value>TeamLeaders</value>
    [JsonPropertyName("teamLeaders")]
    public List<int?> TeamLeaders { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class TeamsTeamCreatePayload {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  TeamLeaders: ").Append(TeamLeaders).Append("\n");
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