#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerTag {
    /// <summary>
    /// A set of environment(endpoint) group ids that have this tag
    /// </summary>
    /// <value>A set of environment(endpoint) group ids that have this tag</value>
    [JsonPropertyName("EndpointGroups")]
    public Dictionary<string, bool?> EndpointGroups { get; set; }

    /// <summary>
    /// A set of environment(endpoint) ids that have this tag
    /// </summary>
    /// <value>A set of environment(endpoint) ids that have this tag</value>
    [JsonPropertyName("Endpoints")]
    public Dictionary<string, bool?> Endpoints { get; set; }

    /// <summary>
    /// Tag name
    /// </summary>
    /// <value>Tag name</value>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Tag identifier
    /// </summary>
    /// <value>Tag identifier</value>
    [JsonPropertyName("id")]
    public int? Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerTag {\n");
        sb.Append("  EndpointGroups: ").Append(EndpointGroups).Append("\n");
        sb.Append("  Endpoints: ").Append(Endpoints).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
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