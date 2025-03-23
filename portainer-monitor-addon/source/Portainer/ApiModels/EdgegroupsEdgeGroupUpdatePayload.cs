#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EdgegroupsEdgeGroupUpdatePayload {
    /// <summary>
    /// Gets or Sets Dynamic
    /// </summary>
    [JsonPropertyName("dynamic")]
    public bool? Dynamic { get; set; }

    /// <summary>
    /// Gets or Sets Endpoints
    /// </summary>
    [JsonPropertyName("endpoints")]
    public List<int?> Endpoints { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets PartialMatch
    /// </summary>
    [JsonPropertyName("partialMatch")]
    public bool? PartialMatch { get; set; }

    /// <summary>
    /// Gets or Sets TagIDs
    /// </summary>
    [JsonPropertyName("tagIDs")]
    public List<int?> TagIDs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class EdgegroupsEdgeGroupUpdatePayload {\n");
        sb.Append("  Dynamic: ").Append(Dynamic).Append("\n");
        sb.Append("  Endpoints: ").Append(Endpoints).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PartialMatch: ").Append(PartialMatch).Append("\n");
        sb.Append("  TagIDs: ").Append(TagIDs).Append("\n");
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