#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class UsersAccessTokenResponse {
    /// <summary>
    /// Gets or Sets ApiKey
    /// </summary>
    [JsonPropertyName("apiKey")]
    public PortainerAPIKey ApiKey { get; set; }

    /// <summary>
    /// Gets or Sets RawAPIKey
    /// </summary>
    [JsonPropertyName("rawAPIKey")]
    public string RawAPIKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class UsersAccessTokenResponse {\n");
        sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
        sb.Append("  RawAPIKey: ").Append(RawAPIKey).Append("\n");
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