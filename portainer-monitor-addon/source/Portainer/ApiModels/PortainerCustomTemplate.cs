#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerCustomTemplate {
    /// <summary>
    /// User identifier who created this template
    /// </summary>
    /// <value>User identifier who created this template</value>
    [JsonPropertyName("CreatedByUserId")]
    public int? CreatedByUserId { get; set; }

    /// <summary>
    /// Description of the template
    /// </summary>
    /// <value>Description of the template</value>
    [JsonPropertyName("Description")]
    public string Description { get; set; }

    /// <summary>
    /// Path to the Stack file
    /// </summary>
    /// <value>Path to the Stack file</value>
    [JsonPropertyName("EntryPoint")]
    public string EntryPoint { get; set; }

    /// <summary>
    /// Gets or Sets GitConfig
    /// </summary>
    [JsonPropertyName("GitConfig")]
    public GittypesRepoConfig GitConfig { get; set; }

    /// <summary>
    /// CustomTemplate Identifier
    /// </summary>
    /// <value>CustomTemplate Identifier</value>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>
    /// URL of the template's logo
    /// </summary>
    /// <value>URL of the template's logo</value>
    [JsonPropertyName("Logo")]
    public string Logo { get; set; }

    /// <summary>
    /// A note that will be displayed in the UI. Supports HTML content
    /// </summary>
    /// <value>A note that will be displayed in the UI. Supports HTML content</value>
    [JsonPropertyName("Note")]
    public string Note { get; set; }

    /// <summary>
    /// Platform associated to the template. Valid values are: 1 - 'linux', 2 - 'windows'
    /// </summary>
    /// <value>Platform associated to the template. Valid values are: 1 - 'linux', 2 - 'windows'</value>
    [JsonPropertyName("Platform")]
    public int? Platform { get; set; }

    /// <summary>
    /// Path on disk to the repository hosting the Stack file
    /// </summary>
    /// <value>Path on disk to the repository hosting the Stack file</value>
    [JsonPropertyName("ProjectPath")]
    public string ProjectPath { get; set; }

    /// <summary>
    /// Gets or Sets ResourceControl
    /// </summary>
    [JsonPropertyName("ResourceControl")]
    public PortainerResourceControl ResourceControl { get; set; }

    /// <summary>
    /// Title of the template
    /// </summary>
    /// <value>Title of the template</value>
    [JsonPropertyName("Title")]
    public string Title { get; set; }

    /// <summary>
    /// Type of created stack: * 1 - swarm * 2 - compose * 3 - kubernetes
    /// </summary>
    /// <value>Type of created stack: * 1 - swarm * 2 - compose * 3 - kubernetes</value>
    [JsonPropertyName("Type")]
    public int? Type { get; set; }

    /// <summary>
    /// EdgeTemplate indicates if this template purpose for Edge Stack
    /// </summary>
    /// <value>EdgeTemplate indicates if this template purpose for Edge Stack</value>
    [JsonPropertyName("edgeTemplate")]
    public bool? EdgeTemplate { get; set; }

    /// <summary>
    /// IsComposeFormat indicates if the Kubernetes template is created from a Docker Compose file
    /// </summary>
    /// <value>IsComposeFormat indicates if the Kubernetes template is created from a Docker Compose file</value>
    [JsonPropertyName("isComposeFormat")]
    public bool? IsComposeFormat { get; set; }

    /// <summary>
    /// Gets or Sets Variables
    /// </summary>
    [JsonPropertyName("variables")]
    public List<PortainerCustomTemplateVariableDefinition> Variables { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerCustomTemplate {\n");
        sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  EntryPoint: ").Append(EntryPoint).Append("\n");
        sb.Append("  GitConfig: ").Append(GitConfig).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Logo: ").Append(Logo).Append("\n");
        sb.Append("  Note: ").Append(Note).Append("\n");
        sb.Append("  Platform: ").Append(Platform).Append("\n");
        sb.Append("  ProjectPath: ").Append(ProjectPath).Append("\n");
        sb.Append("  ResourceControl: ").Append(ResourceControl).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  EdgeTemplate: ").Append(EdgeTemplate).Append("\n");
        sb.Append("  IsComposeFormat: ").Append(IsComposeFormat).Append("\n");
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