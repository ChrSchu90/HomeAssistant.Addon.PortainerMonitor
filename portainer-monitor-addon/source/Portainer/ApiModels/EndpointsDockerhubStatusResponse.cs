#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EndpointsDockerhubStatusResponse {
    /// <summary>
    /// Daily limit
    /// </summary>
    /// <value>Daily limit</value>
    [JsonPropertyName("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Remaiming images to pull
    /// </summary>
    /// <value>Remaiming images to pull</value>
    [JsonPropertyName("remaining")]
    public int? Remaining { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class EndpointsDockerhubStatusResponse {\n");
        sb.Append("  Limit: ").Append(Limit).Append("\n");
        sb.Append("  Remaining: ").Append(Remaining).Append("\n");
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