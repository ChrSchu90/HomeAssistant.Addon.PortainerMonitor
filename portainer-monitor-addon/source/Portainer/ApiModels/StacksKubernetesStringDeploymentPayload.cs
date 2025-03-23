#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class StacksKubernetesStringDeploymentPayload {
    /// <summary>
    /// Gets or Sets ComposeFormat
    /// </summary>
    [JsonPropertyName("composeFormat")]
    public bool? ComposeFormat { get; set; }

    /// <summary>
    /// Whether the stack is from a app template
    /// </summary>
    /// <value>Whether the stack is from a app template</value>
    [JsonPropertyName("fromAppTemplate")]
    public bool? FromAppTemplate { get; set; }

    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Gets or Sets StackFileContent
    /// </summary>
    [JsonPropertyName("stackFileContent")]
    public string StackFileContent { get; set; }

    /// <summary>
    /// Gets or Sets StackName
    /// </summary>
    [JsonPropertyName("stackName")]
    public string StackName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class StacksKubernetesStringDeploymentPayload {\n");
        sb.Append("  ComposeFormat: ").Append(ComposeFormat).Append("\n");
        sb.Append("  FromAppTemplate: ").Append(FromAppTemplate).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  StackFileContent: ").Append(StackFileContent).Append("\n");
        sb.Append("  StackName: ").Append(StackName).Append("\n");
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