#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1beta1ContainerMetrics {
    /// <summary>
    /// Container name corresponding to the one from pod.spec.containers.
    /// </summary>
    /// <value>Container name corresponding to the one from pod.spec.containers.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The memory usage is the memory working set.
    /// </summary>
    /// <value>The memory usage is the memory working set.</value>
    [JsonPropertyName("usage")]
    public V1ResourceList Usage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1beta1ContainerMetrics {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Usage: ").Append(Usage).Append("\n");
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