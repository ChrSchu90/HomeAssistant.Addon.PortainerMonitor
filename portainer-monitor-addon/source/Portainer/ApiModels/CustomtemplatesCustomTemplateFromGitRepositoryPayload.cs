#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class CustomtemplatesCustomTemplateFromGitRepositoryPayload {
    /// <summary>
    /// Path to the Stack file inside the Git repository
    /// </summary>
    /// <value>Path to the Stack file inside the Git repository</value>
    [JsonPropertyName("composeFilePathInRepository")]
    public string ComposeFilePathInRepository { get; set; }

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
    /// IsComposeFormat indicates if the Kubernetes template is created from a Docker Compose file
    /// </summary>
    /// <value>IsComposeFormat indicates if the Kubernetes template is created from a Docker Compose file</value>
    [JsonPropertyName("isComposeFormat")]
    public bool? IsComposeFormat { get; set; }

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
    /// Use basic authentication to clone the Git repository
    /// </summary>
    /// <value>Use basic authentication to clone the Git repository</value>
    [JsonPropertyName("repositoryAuthentication")]
    public bool? RepositoryAuthentication { get; set; }

    /// <summary>
    /// Password used in basic authentication. Required when RepositoryAuthentication is true.
    /// </summary>
    /// <value>Password used in basic authentication. Required when RepositoryAuthentication is true.</value>
    [JsonPropertyName("repositoryPassword")]
    public string RepositoryPassword { get; set; }

    /// <summary>
    /// Reference name of a Git repository hosting the Stack file
    /// </summary>
    /// <value>Reference name of a Git repository hosting the Stack file</value>
    [JsonPropertyName("repositoryReferenceName")]
    public string RepositoryReferenceName { get; set; }

    /// <summary>
    /// URL of a Git repository hosting the Stack file
    /// </summary>
    /// <value>URL of a Git repository hosting the Stack file</value>
    [JsonPropertyName("repositoryURL")]
    public string RepositoryURL { get; set; }

    /// <summary>
    /// Username used in basic authentication. Required when RepositoryAuthentication is true.
    /// </summary>
    /// <value>Username used in basic authentication. Required when RepositoryAuthentication is true.</value>
    [JsonPropertyName("repositoryUsername")]
    public string RepositoryUsername { get; set; }

    /// <summary>
    /// Title of the template
    /// </summary>
    /// <value>Title of the template</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// TLSSkipVerify skips SSL verification when cloning the Git repository
    /// </summary>
    /// <value>TLSSkipVerify skips SSL verification when cloning the Git repository</value>
    [JsonPropertyName("tlsskipVerify")]
    public bool? TlsskipVerify { get; set; }

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
        sb.Append("class CustomtemplatesCustomTemplateFromGitRepositoryPayload {\n");
        sb.Append("  ComposeFilePathInRepository: ").Append(ComposeFilePathInRepository).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  EdgeTemplate: ").Append(EdgeTemplate).Append("\n");
        sb.Append("  IsComposeFormat: ").Append(IsComposeFormat).Append("\n");
        sb.Append("  Logo: ").Append(Logo).Append("\n");
        sb.Append("  Note: ").Append(Note).Append("\n");
        sb.Append("  Platform: ").Append(Platform).Append("\n");
        sb.Append("  RepositoryAuthentication: ").Append(RepositoryAuthentication).Append("\n");
        sb.Append("  RepositoryPassword: ").Append(RepositoryPassword).Append("\n");
        sb.Append("  RepositoryReferenceName: ").Append(RepositoryReferenceName).Append("\n");
        sb.Append("  RepositoryURL: ").Append(RepositoryURL).Append("\n");
        sb.Append("  RepositoryUsername: ").Append(RepositoryUsername).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  TlsskipVerify: ").Append(TlsskipVerify).Append("\n");
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