#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V2HPAScalingRules {
    /// <summary>
    /// policies is a list of potential scaling polices which can be used during scaling. At least one policy must be specified, otherwise the HPAScalingRules will be discarded as invalid +listType=atomic +optional
    /// </summary>
    /// <value>policies is a list of potential scaling polices which can be used during scaling. At least one policy must be specified, otherwise the HPAScalingRules will be discarded as invalid +listType=atomic +optional</value>
    [JsonPropertyName("policies")]
    public List<V2HPAScalingPolicy> Policies { get; set; }

    /// <summary>
    /// selectPolicy is used to specify which policy should be used. If not set, the default value Max is used. +optional
    /// </summary>
    /// <value>selectPolicy is used to specify which policy should be used. If not set, the default value Max is used. +optional</value>
    [JsonPropertyName("selectPolicy")]
    public string SelectPolicy { get; set; }

    /// <summary>
    /// stabilizationWindowSeconds is the number of seconds for which past recommendations should be considered while scaling up or scaling down. StabilizationWindowSeconds must be greater than or equal to zero and less than or equal to 3600 (one hour). If not set, use the default values: - For scale up: 0 (i.e. no stabilization is done). - For scale down: 300 (i.e. the stabilization window is 300 seconds long). +optional
    /// </summary>
    /// <value>stabilizationWindowSeconds is the number of seconds for which past recommendations should be considered while scaling up or scaling down. StabilizationWindowSeconds must be greater than or equal to zero and less than or equal to 3600 (one hour). If not set, use the default values: - For scale up: 0 (i.e. no stabilization is done). - For scale down: 300 (i.e. the stabilization window is 300 seconds long). +optional</value>
    [JsonPropertyName("stabilizationWindowSeconds")]
    public int? StabilizationWindowSeconds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V2HPAScalingRules {\n");
        sb.Append("  Policies: ").Append(Policies).Append("\n");
        sb.Append("  SelectPolicy: ").Append(SelectPolicy).Append("\n");
        sb.Append("  StabilizationWindowSeconds: ").Append(StabilizationWindowSeconds).Append("\n");
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