#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class StacksStackGitRedployPayload {
    /// <summary>
    /// Gets or Sets Env
    /// </summary>
    [JsonPropertyName("env")]
    public List<PortainerPair> Env { get; set; }

    /// <summary>
    /// Gets or Sets Prune
    /// </summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary>
    /// Force a pulling to current image with the original tag though the image is already the latest
    /// </summary>
    /// <value>Force a pulling to current image with the original tag though the image is already the latest</value>
    [JsonPropertyName("pullImage")]
    public bool? PullImage { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class StacksStackGitRedployPayload {\n");
        sb.Append("  Env: ").Append(Env).Append("\n");
        sb.Append("  Prune: ").Append(Prune).Append("\n");
        sb.Append("  PullImage: ").Append(PullImage).Append("\n");
        sb.Append("  RepositoryAuthentication: ").Append(RepositoryAuthentication).Append("\n");
        sb.Append("  RepositoryPassword: ").Append(RepositoryPassword).Append("\n");
        sb.Append("  RepositoryReferenceName: ").Append(RepositoryReferenceName).Append("\n");
        sb.Append("  RepositoryUsername: ").Append(RepositoryUsername).Append("\n");
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