#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerAPIKey {
    /// <summary>
    /// Unix timestamp (UTC) when the API key was created
    /// </summary>
    /// <value>Unix timestamp (UTC) when the API key was created</value>
    [JsonPropertyName("dateCreated")]
    public int? DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Digest represents SHA256 hash of the raw API key
    /// </summary>
    /// <value>Digest represents SHA256 hash of the raw API key</value>
    [JsonPropertyName("digest")]
    public string Digest { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>
    /// Unix timestamp (UTC) when the API key was last used
    /// </summary>
    /// <value>Unix timestamp (UTC) when the API key was last used</value>
    [JsonPropertyName("lastUsed")]
    public int? LastUsed { get; set; }

    /// <summary>
    /// API key identifier (7 char prefix)
    /// </summary>
    /// <value>API key identifier (7 char prefix)</value>
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; }

    /// <summary>
    /// User Identifier
    /// </summary>
    /// <value>User Identifier</value>
    [JsonPropertyName("userId")]
    public int? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerAPIKey {\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Digest: ").Append(Digest).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  LastUsed: ").Append(LastUsed).Append("\n");
        sb.Append("  Prefix: ").Append(Prefix).Append("\n");
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