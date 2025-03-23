#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1ResourceQuotaSpec {
    /// <summary>
    /// hard is the set of desired hard limits for each named resource. More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/ +optional
    /// </summary>
    /// <value>hard is the set of desired hard limits for each named resource. More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/ +optional</value>
    [JsonPropertyName("hard")]
    public V1ResourceList Hard { get; set; }

    /// <summary>
    /// scopeSelector is also a collection of filters like scopes that must match each object tracked by a quota but expressed using ScopeSelectorOperator in combination with possible values. For a resource to match, both scopes AND scopeSelector (if specified in spec), must be matched. +optional
    /// </summary>
    /// <value>scopeSelector is also a collection of filters like scopes that must match each object tracked by a quota but expressed using ScopeSelectorOperator in combination with possible values. For a resource to match, both scopes AND scopeSelector (if specified in spec), must be matched. +optional</value>
    [JsonPropertyName("scopeSelector")]
    public V1ScopeSelector ScopeSelector { get; set; }

    /// <summary>
    /// A collection of filters that must match each object tracked by a quota. If not specified, the quota matches all objects. +optional
    /// </summary>
    /// <value>A collection of filters that must match each object tracked by a quota. If not specified, the quota matches all objects. +optional</value>
    [JsonPropertyName("scopes")]
    public List<string> Scopes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1ResourceQuotaSpec {\n");
        sb.Append("  Hard: ").Append(Hard).Append("\n");
        sb.Append("  ScopeSelector: ").Append(ScopeSelector).Append("\n");
        sb.Append("  Scopes: ").Append(Scopes).Append("\n");
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