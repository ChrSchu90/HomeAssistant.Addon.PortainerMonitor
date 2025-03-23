#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sIngressController {
    /// <summary>
    /// Gets or Sets Availability
    /// </summary>
    [JsonPropertyName("Availability")]
    public bool? Availability { get; set; }

    /// <summary>
    /// Gets or Sets ClassName
    /// </summary>
    [JsonPropertyName("ClassName")]
    public string ClassName { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets New
    /// </summary>
    [JsonPropertyName("New")]
    public bool? New { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("Type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Used
    /// </summary>
    [JsonPropertyName("Used")]
    public bool? Used { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sIngressController {\n");
        sb.Append("  Availability: ").Append(Availability).Append("\n");
        sb.Append("  ClassName: ").Append(ClassName).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  New: ").Append(New).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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