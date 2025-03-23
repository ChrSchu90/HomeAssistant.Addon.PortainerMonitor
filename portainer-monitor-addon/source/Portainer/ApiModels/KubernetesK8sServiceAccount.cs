#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sServiceAccount {
    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [JsonPropertyName("creationDate")]
    public string CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets IsSystem
    /// </summary>
    [JsonPropertyName("isSystem")]
    public bool? IsSystem { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names#uids
    /// </summary>
    /// <value>UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names#uids</value>
    [JsonPropertyName("uid")]
    public string Uid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sServiceAccount {\n");
        sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
        sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  Uid: ").Append(Uid).Append("\n");
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