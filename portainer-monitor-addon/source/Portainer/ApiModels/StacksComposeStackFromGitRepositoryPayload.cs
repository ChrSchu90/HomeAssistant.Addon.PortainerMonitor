#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class StacksComposeStackFromGitRepositoryPayload {
    /// <summary>
    /// Applicable when deploying with multiple stack files
    /// </summary>
    /// <value>Applicable when deploying with multiple stack files</value>
    [JsonPropertyName("additionalFiles")]
    public List<string> AdditionalFiles { get; set; }

    /// <summary>
    /// Optional GitOps update configuration
    /// </summary>
    /// <value>Optional GitOps update configuration</value>
    [JsonPropertyName("autoUpdate")]
    public PortainerAutoUpdateSettings AutoUpdate { get; set; }

    /// <summary>
    /// Path to the Stack file inside the Git repository
    /// </summary>
    /// <value>Path to the Stack file inside the Git repository</value>
    [JsonPropertyName("composeFile")]
    public string ComposeFile { get; set; }

    /// <summary>
    /// A list of environment variables used during stack deployment
    /// </summary>
    /// <value>A list of environment variables used during stack deployment</value>
    [JsonPropertyName("env")]
    public List<PortainerPair> Env { get; set; }

    /// <summary>
    /// Whether the stack is from a app template
    /// </summary>
    /// <value>Whether the stack is from a app template</value>
    [JsonPropertyName("fromAppTemplate")]
    public bool? FromAppTemplate { get; set; }

    /// <summary>
    /// Name of the stack
    /// </summary>
    /// <value>Name of the stack</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

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
    /// TLSSkipVerify skips SSL verification when cloning the Git repository
    /// </summary>
    /// <value>TLSSkipVerify skips SSL verification when cloning the Git repository</value>
    [JsonPropertyName("tlsskipVerify")]
    public bool? TlsskipVerify { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class StacksComposeStackFromGitRepositoryPayload {\n");
        sb.Append("  AdditionalFiles: ").Append(AdditionalFiles).Append("\n");
        sb.Append("  AutoUpdate: ").Append(AutoUpdate).Append("\n");
        sb.Append("  ComposeFile: ").Append(ComposeFile).Append("\n");
        sb.Append("  Env: ").Append(Env).Append("\n");
        sb.Append("  FromAppTemplate: ").Append(FromAppTemplate).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  RepositoryAuthentication: ").Append(RepositoryAuthentication).Append("\n");
        sb.Append("  RepositoryPassword: ").Append(RepositoryPassword).Append("\n");
        sb.Append("  RepositoryReferenceName: ").Append(RepositoryReferenceName).Append("\n");
        sb.Append("  RepositoryURL: ").Append(RepositoryURL).Append("\n");
        sb.Append("  RepositoryUsername: ").Append(RepositoryUsername).Append("\n");
        sb.Append("  TlsskipVerify: ").Append(TlsskipVerify).Append("\n");
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