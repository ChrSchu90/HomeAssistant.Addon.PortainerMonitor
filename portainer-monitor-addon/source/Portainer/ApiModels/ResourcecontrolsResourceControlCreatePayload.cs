#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class ResourcecontrolsResourceControlCreatePayload {
    /// <summary>
    /// Permit access to resource only to admins
    /// </summary>
    /// <value>Permit access to resource only to admins</value>
    [JsonPropertyName("administratorsOnly")]
    public bool? AdministratorsOnly { get; set; }

    /// <summary>
    /// Permit access to the associated resource to any user
    /// </summary>
    /// <value>Permit access to the associated resource to any user</value>
    [JsonPropertyName("public")]
    public bool? Public { get; set; }

    /// <summary>
    /// Gets or Sets ResourceID
    /// </summary>
    [JsonPropertyName("resourceID")]
    public string ResourceID { get; set; }

    /// <summary>
    /// List of Docker resources that will inherit this access control
    /// </summary>
    /// <value>List of Docker resources that will inherit this access control</value>
    [JsonPropertyName("subResourceIDs")]
    public List<string> SubResourceIDs { get; set; }

    /// <summary>
    /// List of team identifiers with access to the associated resource
    /// </summary>
    /// <value>List of team identifiers with access to the associated resource</value>
    [JsonPropertyName("teams")]
    public List<int?> Teams { get; set; }

    /// <summary>
    /// Type of Resource. Valid values are: 1 - container, 2 - service 3 - volume, 4 - network, 5 - secret, 6 - stack, 7 - config, 8 - custom template, 9 - azure-container-group
    /// </summary>
    /// <value>Type of Resource. Valid values are: 1 - container, 2 - service 3 - volume, 4 - network, 5 - secret, 6 - stack, 7 - config, 8 - custom template, 9 - azure-container-group</value>
    [JsonPropertyName("type")]
    public int? Type { get; set; }

    /// <summary>
    /// List of user identifiers with access to the associated resource
    /// </summary>
    /// <value>List of user identifiers with access to the associated resource</value>
    [JsonPropertyName("users")]
    public List<int?> Users { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class ResourcecontrolsResourceControlCreatePayload {\n");
        sb.Append("  AdministratorsOnly: ").Append(AdministratorsOnly).Append("\n");
        sb.Append("  Public: ").Append(Public).Append("\n");
        sb.Append("  ResourceID: ").Append(ResourceID).Append("\n");
        sb.Append("  SubResourceIDs: ").Append(SubResourceIDs).Append("\n");
        sb.Append("  Teams: ").Append(Teams).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Users: ").Append(Users).Append("\n");
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