#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V2ResourceMetricSource {
    /// <summary>
    /// name is the name of the resource in question.
    /// </summary>
    /// <value>name is the name of the resource in question.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// target specifies the target value for the given metric
    /// </summary>
    /// <value>target specifies the target value for the given metric</value>
    [JsonPropertyName("target")]
    public V2MetricTarget Target { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V2ResourceMetricSource {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Target: ").Append(Target).Append("\n");
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