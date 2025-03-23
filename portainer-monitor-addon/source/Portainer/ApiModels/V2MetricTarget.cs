#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V2MetricTarget {
    /// <summary>
    /// averageUtilization is the target value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods. Currently only valid for Resource metric source type +optional
    /// </summary>
    /// <value>averageUtilization is the target value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods. Currently only valid for Resource metric source type +optional</value>
    [JsonPropertyName("averageUtilization")]
    public int? AverageUtilization { get; set; }

    /// <summary>
    /// averageValue is the target value of the average of the metric across all relevant pods (as a quantity) +optional
    /// </summary>
    /// <value>averageValue is the target value of the average of the metric across all relevant pods (as a quantity) +optional</value>
    [JsonPropertyName("averageValue")]
    public ResourceQuantity AverageValue { get; set; }

    /// <summary>
    /// type represents whether the metric type is Utilization, Value, or AverageValue
    /// </summary>
    /// <value>type represents whether the metric type is Utilization, Value, or AverageValue</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// value is the target value of the metric (as a quantity). +optional
    /// </summary>
    /// <value>value is the target value of the metric (as a quantity). +optional</value>
    [JsonPropertyName("value")]
    public ResourceQuantity Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V2MetricTarget {\n");
        sb.Append("  AverageUtilization: ").Append(AverageUtilization).Append("\n");
        sb.Append("  AverageValue: ").Append(AverageValue).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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