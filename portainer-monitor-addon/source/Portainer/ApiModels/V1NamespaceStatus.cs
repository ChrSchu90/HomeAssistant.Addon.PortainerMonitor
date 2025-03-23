#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1NamespaceStatus {
    /// <summary>
    /// Represents the latest available observations of a namespace's current state. +optional +patchMergeKey=type +patchStrategy=merge
    /// </summary>
    /// <value>Represents the latest available observations of a namespace's current state. +optional +patchMergeKey=type +patchStrategy=merge</value>
    [JsonPropertyName("conditions")]
    public List<V1NamespaceCondition> Conditions { get; set; }

    /// <summary>
    /// Phase is the current lifecycle phase of the namespace. More info: https://kubernetes.io/docs/tasks/administer-cluster/namespaces/ +optional
    /// </summary>
    /// <value>Phase is the current lifecycle phase of the namespace. More info: https://kubernetes.io/docs/tasks/administer-cluster/namespaces/ +optional</value>
    [JsonPropertyName("phase")]
    public string Phase { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1NamespaceStatus {\n");
        sb.Append("  Conditions: ").Append(Conditions).Append("\n");
        sb.Append("  Phase: ").Append(Phase).Append("\n");
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