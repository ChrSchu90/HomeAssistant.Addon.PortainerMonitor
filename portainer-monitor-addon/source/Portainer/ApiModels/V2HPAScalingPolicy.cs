#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V2HPAScalingPolicy {
    /// <summary>
    /// periodSeconds specifies the window of time for which the policy should hold true. PeriodSeconds must be greater than zero and less than or equal to 1800 (30 min).
    /// </summary>
    /// <value>periodSeconds specifies the window of time for which the policy should hold true. PeriodSeconds must be greater than zero and less than or equal to 1800 (30 min).</value>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>
    /// type is used to specify the scaling policy.
    /// </summary>
    /// <value>type is used to specify the scaling policy.</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// value contains the amount of change which is permitted by the policy. It must be greater than zero
    /// </summary>
    /// <value>value contains the amount of change which is permitted by the policy. It must be greater than zero</value>
    [JsonPropertyName("value")]
    public int? Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V2HPAScalingPolicy {\n");
        sb.Append("  PeriodSeconds: ").Append(PeriodSeconds).Append("\n");
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