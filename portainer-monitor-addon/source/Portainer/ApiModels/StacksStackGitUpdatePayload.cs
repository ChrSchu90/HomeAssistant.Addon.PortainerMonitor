#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class StacksStackGitUpdatePayload {
    /// <summary>
    /// Gets or Sets AutoUpdate
    /// </summary>
    [JsonPropertyName("autoUpdate")]
    public PortainerAutoUpdateSettings AutoUpdate { get; set; }

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
    /// Gets or Sets TlsskipVerify
    /// </summary>
    [JsonPropertyName("tlsskipVerify")]
    public bool? TlsskipVerify { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class StacksStackGitUpdatePayload {\n");
        sb.Append("  AutoUpdate: ").Append(AutoUpdate).Append("\n");
        sb.Append("  Env: ").Append(Env).Append("\n");
        sb.Append("  Prune: ").Append(Prune).Append("\n");
        sb.Append("  RepositoryAuthentication: ").Append(RepositoryAuthentication).Append("\n");
        sb.Append("  RepositoryPassword: ").Append(RepositoryPassword).Append("\n");
        sb.Append("  RepositoryReferenceName: ").Append(RepositoryReferenceName).Append("\n");
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