#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1ScopedResourceSelectorRequirement {
    /// <summary>
    /// Represents a scope's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist.
    /// </summary>
    /// <value>Represents a scope's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist.</value>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>
    /// The name of the scope that the selector applies to.
    /// </summary>
    /// <value>The name of the scope that the selector applies to.</value>
    [JsonPropertyName("scopeName")]
    public string ScopeName { get; set; }

    /// <summary>
    /// An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch. +optional
    /// </summary>
    /// <value>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch. +optional</value>
    [JsonPropertyName("values")]
    public List<string> Values { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1ScopedResourceSelectorRequirement {\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  ScopeName: ").Append(ScopeName).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
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