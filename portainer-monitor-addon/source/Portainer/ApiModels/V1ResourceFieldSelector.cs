#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1ResourceFieldSelector {
    /// <summary>
    /// Container name: required for volumes, optional for env vars +optional
    /// </summary>
    /// <value>Container name: required for volumes, optional for env vars +optional</value>
    [JsonPropertyName("containerName")]
    public string ContainerName { get; set; }

    /// <summary>
    /// Specifies the output format of the exposed resources, defaults to \"1\" +optional
    /// </summary>
    /// <value>Specifies the output format of the exposed resources, defaults to \"1\" +optional</value>
    [JsonPropertyName("divisor")]
    public ResourceQuantity Divisor { get; set; }

    /// <summary>
    /// Required: resource to select
    /// </summary>
    /// <value>Required: resource to select</value>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1ResourceFieldSelector {\n");
        sb.Append("  ContainerName: ").Append(ContainerName).Append("\n");
        sb.Append("  Divisor: ").Append(Divisor).Append("\n");
        sb.Append("  Resource: ").Append(Resource).Append("\n");
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