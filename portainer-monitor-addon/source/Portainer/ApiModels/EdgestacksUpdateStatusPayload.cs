#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EdgestacksUpdateStatusPayload {
    /// <summary>
    /// Gets or Sets EndpointID
    /// </summary>
    [JsonPropertyName("endpointID")]
    public int? EndpointID { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [JsonPropertyName("error")]
    public string Error { get; set; }

    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [JsonPropertyName("time")]
    public int? Time { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class EdgestacksUpdateStatusPayload {\n");
        sb.Append("  EndpointID: ").Append(EndpointID).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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