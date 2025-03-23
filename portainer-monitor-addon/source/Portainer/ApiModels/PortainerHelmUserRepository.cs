#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerHelmUserRepository {
    /// <summary>
    /// Membership Identifier
    /// </summary>
    /// <value>Membership Identifier</value>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Helm repository URL
    /// </summary>
    /// <value>Helm repository URL</value>
    [JsonPropertyName("URL")]
    public string URL { get; set; }

    /// <summary>
    /// User identifier
    /// </summary>
    /// <value>User identifier</value>
    [JsonPropertyName("UserId")]
    public int? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerHelmUserRepository {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  URL: ").Append(URL).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
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