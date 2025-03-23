#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1ResourceQuotaStatus {
    /// <summary>
    /// Hard is the set of enforced hard limits for each named resource. More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/ +optional
    /// </summary>
    /// <value>Hard is the set of enforced hard limits for each named resource. More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/ +optional</value>
    [JsonPropertyName("hard")]
    public V1ResourceList Hard { get; set; }

    /// <summary>
    /// Used is the current observed total usage of the resource in the namespace. +optional
    /// </summary>
    /// <value>Used is the current observed total usage of the resource in the namespace. +optional</value>
    [JsonPropertyName("used")]
    public V1ResourceList Used { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1ResourceQuotaStatus {\n");
        sb.Append("  Hard: ").Append(Hard).Append("\n");
        sb.Append("  Used: ").Append(Used).Append("\n");
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