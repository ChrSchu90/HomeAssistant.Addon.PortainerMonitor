#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class ReleaseMaintainer {
    /// <summary>
    /// Email is an optional email address to contact the named maintainer
    /// </summary>
    /// <value>Email is an optional email address to contact the named maintainer</value>
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// Name is a user name or organization name
    /// </summary>
    /// <value>Name is a user name or organization name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// URL is an optional URL to an address for the named maintainer
    /// </summary>
    /// <value>URL is an optional URL to an address for the named maintainer</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class ReleaseMaintainer {\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
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