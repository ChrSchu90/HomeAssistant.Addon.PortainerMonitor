#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerTeamResourceAccess {
    /// <summary>
    /// Gets or Sets AccessLevel
    /// </summary>
    [JsonPropertyName("AccessLevel")]
    public int? AccessLevel { get; set; }

    /// <summary>
    /// Gets or Sets TeamId
    /// </summary>
    [JsonPropertyName("TeamId")]
    public int? TeamId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerTeamResourceAccess {\n");
        sb.Append("  AccessLevel: ").Append(AccessLevel).Append("\n");
        sb.Append("  TeamId: ").Append(TeamId).Append("\n");
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