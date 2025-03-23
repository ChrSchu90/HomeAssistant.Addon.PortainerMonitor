#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class StacksKubernetesGitDeploymentPayload {
    /// <summary>
    /// Gets or Sets AdditionalFiles
    /// </summary>
    [JsonPropertyName("additionalFiles")]
    public List<string> AdditionalFiles { get; set; }

    /// <summary>
    /// Gets or Sets AutoUpdate
    /// </summary>
    [JsonPropertyName("autoUpdate")]
    public PortainerAutoUpdateSettings AutoUpdate { get; set; }

    /// <summary>
    /// Gets or Sets ComposeFormat
    /// </summary>
    [JsonPropertyName("composeFormat")]
    public bool? ComposeFormat { get; set; }

    /// <summary>
    /// Gets or Sets ManifestFile
    /// </summary>
    [JsonPropertyName("manifestFile")]
    public string ManifestFile { get; set; }

    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryAuthentication
    /// </summary>
    [JsonPropertyName("repositoryAuthentication")]
    public bool? RepositoryAuthentication { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryPassword
    /// </summary>
    [JsonPropertyName("repositoryPassword")]
    public string RepositoryPassword { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryReferenceName
    /// </summary>
    [JsonPropertyName("repositoryReferenceName")]
    public string RepositoryReferenceName { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryURL
    /// </summary>
    [JsonPropertyName("repositoryURL")]
    public string RepositoryURL { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryUsername
    /// </summary>
    [JsonPropertyName("repositoryUsername")]
    public string RepositoryUsername { get; set; }

    /// <summary>
    /// Gets or Sets StackName
    /// </summary>
    [JsonPropertyName("stackName")]
    public string StackName { get; set; }

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
        sb.Append("class StacksKubernetesGitDeploymentPayload {\n");
        sb.Append("  AdditionalFiles: ").Append(AdditionalFiles).Append("\n");
        sb.Append("  AutoUpdate: ").Append(AutoUpdate).Append("\n");
        sb.Append("  ComposeFormat: ").Append(ComposeFormat).Append("\n");
        sb.Append("  ManifestFile: ").Append(ManifestFile).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  RepositoryAuthentication: ").Append(RepositoryAuthentication).Append("\n");
        sb.Append("  RepositoryPassword: ").Append(RepositoryPassword).Append("\n");
        sb.Append("  RepositoryReferenceName: ").Append(RepositoryReferenceName).Append("\n");
        sb.Append("  RepositoryURL: ").Append(RepositoryURL).Append("\n");
        sb.Append("  RepositoryUsername: ").Append(RepositoryUsername).Append("\n");
        sb.Append("  StackName: ").Append(StackName).Append("\n");
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