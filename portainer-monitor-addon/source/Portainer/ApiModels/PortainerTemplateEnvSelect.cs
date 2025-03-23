#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerTemplateEnvSelect {
    /// <summary>
    /// Will set this choice as the default choice
    /// </summary>
    /// <value>Will set this choice as the default choice</value>
    [JsonPropertyName("default")]
    public bool? Default { get; set; }

    /// <summary>
    /// Some text that will displayed as a choice
    /// </summary>
    /// <value>Some text that will displayed as a choice</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }

    /// <summary>
    /// A value that will be associated to the choice
    /// </summary>
    /// <value>A value that will be associated to the choice</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerTemplateEnvSelect {\n");
        sb.Append("  Default: ").Append(Default).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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