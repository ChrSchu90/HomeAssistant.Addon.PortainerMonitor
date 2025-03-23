#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V2ContainerResourceMetricStatus {
    /// <summary>
    /// container is the name of the container in the pods of the scaling target
    /// </summary>
    /// <value>container is the name of the container in the pods of the scaling target</value>
    [JsonPropertyName("container")]
    public string Container { get; set; }

    /// <summary>
    /// current contains the current value for the given metric
    /// </summary>
    /// <value>current contains the current value for the given metric</value>
    [JsonPropertyName("current")]
    public V2MetricValueStatus Current { get; set; }

    /// <summary>
    /// name is the name of the resource in question.
    /// </summary>
    /// <value>name is the name of the resource in question.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V2ContainerResourceMetricStatus {\n");
        sb.Append("  Container: ").Append(Container).Append("\n");
        sb.Append("  Current: ").Append(Current).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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