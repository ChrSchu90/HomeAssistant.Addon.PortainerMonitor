#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerRole {
    /// <summary>
    /// Authorizations associated to a role
    /// </summary>
    /// <value>Authorizations associated to a role</value>
    [JsonPropertyName("Authorizations")]
    public PortainerAuthorizations Authorizations { get; set; }

    /// <summary>
    /// Role description
    /// </summary>
    /// <value>Role description</value>
    [JsonPropertyName("Description")]
    public string Description { get; set; }

    /// <summary>
    /// Role Identifier
    /// </summary>
    /// <value>Role Identifier</value>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Role name
    /// </summary>
    /// <value>Role name</value>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [JsonPropertyName("Priority")]
    public int? Priority { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerRole {\n");
        sb.Append("  Authorizations: ").Append(Authorizations).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
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