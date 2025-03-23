#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1LabelSelector {
    /// <summary>
    /// matchExpressions is a list of label selector requirements. The requirements are ANDed. +optional
    /// </summary>
    /// <value>matchExpressions is a list of label selector requirements. The requirements are ANDed. +optional</value>
    [JsonPropertyName("matchExpressions")]
    public List<V1LabelSelectorRequirement> MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is \"key\", the operator is \"In\", and the values array contains only \"value\". The requirements are ANDed. +optional
    /// </summary>
    /// <value>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is \"key\", the operator is \"In\", and the values array contains only \"value\". The requirements are ANDed. +optional</value>
    [JsonPropertyName("matchLabels")]
    public Dictionary<string, string> MatchLabels { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1LabelSelector {\n");
        sb.Append("  MatchExpressions: ").Append(MatchExpressions).Append("\n");
        sb.Append("  MatchLabels: ").Append(MatchLabels).Append("\n");
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