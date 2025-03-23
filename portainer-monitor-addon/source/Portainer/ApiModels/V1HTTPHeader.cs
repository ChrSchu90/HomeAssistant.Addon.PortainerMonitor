#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1HTTPHeader {
    /// <summary>
    /// The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.
    /// </summary>
    /// <value>The header field name. This will be canonicalized upon output, so case-variant names will be understood as the same header.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The header field value
    /// </summary>
    /// <value>The header field value</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1HTTPHeader {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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