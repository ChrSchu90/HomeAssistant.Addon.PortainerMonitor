#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V2MetricValueStatus {
    /// <summary>
    /// currentAverageUtilization is the current value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods. +optional
    /// </summary>
    /// <value>currentAverageUtilization is the current value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods. +optional</value>
    [JsonPropertyName("averageUtilization")]
    public int? AverageUtilization { get; set; }

    /// <summary>
    /// averageValue is the current value of the average of the metric across all relevant pods (as a quantity) +optional
    /// </summary>
    /// <value>averageValue is the current value of the average of the metric across all relevant pods (as a quantity) +optional</value>
    [JsonPropertyName("averageValue")]
    public ResourceQuantity AverageValue { get; set; }

    /// <summary>
    /// value is the current value of the metric (as a quantity). +optional
    /// </summary>
    /// <value>value is the current value of the metric (as a quantity). +optional</value>
    [JsonPropertyName("value")]
    public ResourceQuantity Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V2MetricValueStatus {\n");
        sb.Append("  AverageUtilization: ").Append(AverageUtilization).Append("\n");
        sb.Append("  AverageValue: ").Append(AverageValue).Append("\n");
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