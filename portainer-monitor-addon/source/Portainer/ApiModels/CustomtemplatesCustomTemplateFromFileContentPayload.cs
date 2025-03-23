#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class CustomtemplatesCustomTemplateFromFileContentPayload {
    /// <summary>
    /// Description of the template
    /// </summary>
    /// <value>Description of the template</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// EdgeTemplate indicates if this template purpose for Edge Stack
    /// </summary>
    /// <value>EdgeTemplate indicates if this template purpose for Edge Stack</value>
    [JsonPropertyName("edgeTemplate")]
    public bool? EdgeTemplate { get; set; }

    /// <summary>
    /// Content of stack file
    /// </summary>
    /// <value>Content of stack file</value>
    [JsonPropertyName("fileContent")]
    public string FileContent { get; set; }

    /// <summary>
    /// URL of the template's logo
    /// </summary>
    /// <value>URL of the template's logo</value>
    [JsonPropertyName("logo")]
    public string Logo { get; set; }

    /// <summary>
    /// A note that will be displayed in the UI. Supports HTML content
    /// </summary>
    /// <value>A note that will be displayed in the UI. Supports HTML content</value>
    [JsonPropertyName("note")]
    public string Note { get; set; }

    /// <summary>
    /// Platform associated to the template. Valid values are: 1 - 'linux', 2 - 'windows' Required for Docker stacks
    /// </summary>
    /// <value>Platform associated to the template. Valid values are: 1 - 'linux', 2 - 'windows' Required for Docker stacks</value>
    [JsonPropertyName("platform")]
    public int? Platform { get; set; }

    /// <summary>
    /// Title of the template
    /// </summary>
    /// <value>Title of the template</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// Type of created stack: * 1 - swarm * 2 - compose * 3 - kubernetes
    /// </summary>
    /// <value>Type of created stack: * 1 - swarm * 2 - compose * 3 - kubernetes</value>
    [JsonPropertyName("type")]
    public int? Type { get; set; }

    /// <summary>
    /// Definitions of variables in the stack file
    /// </summary>
    /// <value>Definitions of variables in the stack file</value>
    [JsonPropertyName("variables")]
    public List<PortainerCustomTemplateVariableDefinition> Variables { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class CustomtemplatesCustomTemplateFromFileContentPayload {\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  EdgeTemplate: ").Append(EdgeTemplate).Append("\n");
        sb.Append("  FileContent: ").Append(FileContent).Append("\n");
        sb.Append("  Logo: ").Append(Logo).Append("\n");
        sb.Append("  Note: ").Append(Note).Append("\n");
        sb.Append("  Platform: ").Append(Platform).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Variables: ").Append(Variables).Append("\n");
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