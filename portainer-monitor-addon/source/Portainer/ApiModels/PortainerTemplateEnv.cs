#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerTemplateEnv {
    /// <summary>
    /// Default value that will be set for the variable
    /// </summary>
    /// <value>Default value that will be set for the variable</value>
    [JsonPropertyName("default")]
    public string Default { get; set; }

    /// <summary>
    /// Content of the tooltip that will be generated in the UI
    /// </summary>
    /// <value>Content of the tooltip that will be generated in the UI</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Text for the label that will be generated in the UI
    /// </summary>
    /// <value>Text for the label that will be generated in the UI</value>
    [JsonPropertyName("label")]
    public string Label { get; set; }

    /// <summary>
    /// name of the environment(endpoint) variable
    /// </summary>
    /// <value>name of the environment(endpoint) variable</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// If set to true, will not generate any input for this variable in the UI
    /// </summary>
    /// <value>If set to true, will not generate any input for this variable in the UI</value>
    [JsonPropertyName("preset")]
    public bool? Preset { get; set; }

    /// <summary>
    /// A list of name/value that will be used to generate a dropdown in the UI
    /// </summary>
    /// <value>A list of name/value that will be used to generate a dropdown in the UI</value>
    [JsonPropertyName("select")]
    public List<PortainerTemplateEnvSelect> Select { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerTemplateEnv {\n");
        sb.Append("  Default: ").Append(Default).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Label: ").Append(Label).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Preset: ").Append(Preset).Append("\n");
        sb.Append("  Select: ").Append(Select).Append("\n");
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