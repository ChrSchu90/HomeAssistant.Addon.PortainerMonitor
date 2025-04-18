#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1RoleRef {
    /// <summary>
    /// APIGroup is the group for the resource being referenced
    /// </summary>
    /// <value>APIGroup is the group for the resource being referenced</value>
    [JsonPropertyName("apiGroup")]
    public string ApiGroup { get; set; }

    /// <summary>
    /// Kind is the type of resource being referenced
    /// </summary>
    /// <value>Kind is the type of resource being referenced</value>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Name is the name of resource being referenced
    /// </summary>
    /// <value>Name is the name of resource being referenced</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1RoleRef {\n");
        sb.Append("  ApiGroup: ").Append(ApiGroup).Append("\n");
        sb.Append("  Kind: ").Append(Kind).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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