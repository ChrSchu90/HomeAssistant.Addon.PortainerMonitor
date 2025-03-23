#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerResourceControl {
    /// <summary>
    /// Gets or Sets AccessLevel
    /// </summary>
    [JsonPropertyName("AccessLevel")]
    public int? AccessLevel { get; set; }

    /// <summary>
    /// Permit access to resource only to admins
    /// </summary>
    /// <value>Permit access to resource only to admins</value>
    [JsonPropertyName("AdministratorsOnly")]
    public bool? AdministratorsOnly { get; set; }

    /// <summary>
    /// ResourceControl Identifier
    /// </summary>
    /// <value>ResourceControl Identifier</value>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Deprecated fields Deprecated in DBVersion == 2
    /// </summary>
    /// <value>Deprecated fields Deprecated in DBVersion == 2</value>
    [JsonPropertyName("OwnerId")]
    public int? OwnerId { get; set; }

    /// <summary>
    /// Permit access to the associated resource to any user
    /// </summary>
    /// <value>Permit access to the associated resource to any user</value>
    [JsonPropertyName("Public")]
    public bool? Public { get; set; }

    /// <summary>
    /// Docker resource identifier on which access control will be applied.\\ In the case of a resource control applied to a stack, use the stack name as identifier
    /// </summary>
    /// <value>Docker resource identifier on which access control will be applied.\\ In the case of a resource control applied to a stack, use the stack name as identifier</value>
    [JsonPropertyName("ResourceId")]
    public string ResourceId { get; set; }

    /// <summary>
    /// List of Docker resources that will inherit this access control
    /// </summary>
    /// <value>List of Docker resources that will inherit this access control</value>
    [JsonPropertyName("SubResourceIds")]
    public List<string> SubResourceIds { get; set; }

    /// <summary>
    /// Gets or Sets System
    /// </summary>
    [JsonPropertyName("System")]
    public bool? System { get; set; }

    /// <summary>
    /// Gets or Sets TeamAccesses
    /// </summary>
    [JsonPropertyName("TeamAccesses")]
    public List<PortainerTeamResourceAccess> TeamAccesses { get; set; }

    /// <summary>
    /// Type of Docker resource. Valid values are: 1- container, 2 -service 3 - volume, 4 - secret, 5 - stack, 6 - config or 7 - custom template
    /// </summary>
    /// <value>Type of Docker resource. Valid values are: 1- container, 2 -service 3 - volume, 4 - secret, 5 - stack, 6 - config or 7 - custom template</value>
    [JsonPropertyName("Type")]
    public int? Type { get; set; }

    /// <summary>
    /// Gets or Sets UserAccesses
    /// </summary>
    [JsonPropertyName("UserAccesses")]
    public List<PortainerUserResourceAccess> UserAccesses { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerResourceControl {\n");
        sb.Append("  AccessLevel: ").Append(AccessLevel).Append("\n");
        sb.Append("  AdministratorsOnly: ").Append(AdministratorsOnly).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
        sb.Append("  Public: ").Append(Public).Append("\n");
        sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
        sb.Append("  SubResourceIds: ").Append(SubResourceIds).Append("\n");
        sb.Append("  System: ").Append(System).Append("\n");
        sb.Append("  TeamAccesses: ").Append(TeamAccesses).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  UserAccesses: ").Append(UserAccesses).Append("\n");
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