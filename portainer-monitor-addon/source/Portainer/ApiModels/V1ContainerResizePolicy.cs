#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1ContainerResizePolicy {
    /// <summary>
    /// Name of the resource to which this resource resize policy applies. Supported values: cpu, memory.
    /// </summary>
    /// <value>Name of the resource to which this resource resize policy applies. Supported values: cpu, memory.</value>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; }

    /// <summary>
    /// Restart policy to apply when specified resource is resized. If not specified, it defaults to NotRequired.
    /// </summary>
    /// <value>Restart policy to apply when specified resource is resized. If not specified, it defaults to NotRequired.</value>
    [JsonPropertyName("restartPolicy")]
    public string RestartPolicy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1ContainerResizePolicy {\n");
        sb.Append("  ResourceName: ").Append(ResourceName).Append("\n");
        sb.Append("  RestartPolicy: ").Append(RestartPolicy).Append("\n");
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