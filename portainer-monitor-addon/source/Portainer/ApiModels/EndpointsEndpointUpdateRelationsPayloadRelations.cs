#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EndpointsEndpointUpdateRelationsPayloadRelations {
    /// <summary>
    /// Gets or Sets EdgeGroups
    /// </summary>
    [JsonPropertyName("edgeGroups")]
    public List<int?> EdgeGroups { get; set; }

    /// <summary>
    /// Environment(Endpoint) group identifier
    /// </summary>
    /// <value>Environment(Endpoint) group identifier</value>
    [JsonPropertyName("group")]
    public int? Group { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [JsonPropertyName("tags")]
    public List<int?> Tags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class EndpointsEndpointUpdateRelationsPayloadRelations {\n");
        sb.Append("  EdgeGroups: ").Append(EdgeGroups).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
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