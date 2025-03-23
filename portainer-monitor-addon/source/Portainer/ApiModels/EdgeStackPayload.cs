#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EdgeStackPayload {
    /// <summary>
    /// Gets or Sets DeployerOptionsPayload
    /// </summary>
    [JsonPropertyName("deployerOptionsPayload")]
    public EdgeDeployerOptionsPayload DeployerOptionsPayload { get; set; }

    /// <summary>
    /// Content of stack folder
    /// </summary>
    /// <value>Content of stack folder</value>
    [JsonPropertyName("dirEntries")]
    public List<FilesystemDirEntry> DirEntries { get; set; }

    /// <summary>
    /// EdgeUpdateID is the ID of the edge update related to this stack. Used only for EE
    /// </summary>
    /// <value>EdgeUpdateID is the ID of the edge update related to this stack. Used only for EE</value>
    [JsonPropertyName("edgeUpdateID")]
    public int? EdgeUpdateID { get; set; }

    /// <summary>
    /// Name of the stack entry file
    /// </summary>
    /// <value>Name of the stack entry file</value>
    [JsonPropertyName("entryFileName")]
    public string EntryFileName { get; set; }

    /// <summary>
    /// Used only for EE EnvVars is a list of environment variables to inject into the stack
    /// </summary>
    /// <value>Used only for EE EnvVars is a list of environment variables to inject into the stack</value>
    [JsonPropertyName("envVars")]
    public List<PortainerPair> EnvVars { get; set; }

    /// <summary>
    /// Mount point for relative path
    /// </summary>
    /// <value>Mount point for relative path</value>
    [JsonPropertyName("filesystemPath")]
    public string FilesystemPath { get; set; }

    /// <summary>
    /// ID of the stack
    /// </summary>
    /// <value>ID of the stack</value>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of the stack
    /// </summary>
    /// <value>Name of the stack</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Namespace to use for kubernetes stack. Keep empty to use the manifest namespace.
    /// </summary>
    /// <value>Namespace to use for kubernetes stack. Keep empty to use the manifest namespace.</value>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// PrePullImage is a flag indicating if the agent must pull the image before deploying the stack. Used only for EE
    /// </summary>
    /// <value>PrePullImage is a flag indicating if the agent must pull the image before deploying the stack. Used only for EE</value>
    [JsonPropertyName("prePullImage")]
    public bool? PrePullImage { get; set; }

    /// <summary>
    /// RePullImage is a flag indicating if the agent must pull the image if it is already present on the node. Used only for EE
    /// </summary>
    /// <value>RePullImage is a flag indicating if the agent must pull the image if it is already present on the node. Used only for EE</value>
    [JsonPropertyName("rePullImage")]
    public bool? RePullImage { get; set; }

    /// <summary>
    /// Used only for EE async edge agent ReadyRePullImage is a flag to indicate whether the auto update is trigger to re-pull image
    /// </summary>
    /// <value>Used only for EE async edge agent ReadyRePullImage is a flag to indicate whether the auto update is trigger to re-pull image</value>
    [JsonPropertyName("readyRePullImage")]
    public bool? ReadyRePullImage { get; set; }

    /// <summary>
    /// RegistryCredentials holds the credentials for a Docker registry. Used only for EE
    /// </summary>
    /// <value>RegistryCredentials holds the credentials for a Docker registry. Used only for EE</value>
    [JsonPropertyName("registryCredentials")]
    public List<EdgeRegistryCredentials> RegistryCredentials { get; set; }

    /// <summary>
    /// RetryDeploy is a flag indicating if the agent must retry to deploy the stack if it fails. Used only for EE
    /// </summary>
    /// <value>RetryDeploy is a flag indicating if the agent must retry to deploy the stack if it fails. Used only for EE</value>
    [JsonPropertyName("retryDeploy")]
    public bool? RetryDeploy { get; set; }

    /// <summary>
    /// RetryPeriod specifies the duration, in seconds, for which the agent should continue attempting to deploy the stack after a failure Used only for EE
    /// </summary>
    /// <value>RetryPeriod specifies the duration, in seconds, for which the agent should continue attempting to deploy the stack after a failure Used only for EE</value>
    [JsonPropertyName("retryPeriod")]
    public int? RetryPeriod { get; set; }

    /// <summary>
    /// RollbackTo specifies the stack file version to rollback to (only support to rollback to the last version currently)
    /// </summary>
    /// <value>RollbackTo specifies the stack file version to rollback to (only support to rollback to the last version currently)</value>
    [JsonPropertyName("rollbackTo")]
    public int? RollbackTo { get; set; }

    /// <summary>
    /// Content of the stack file (for compatibility to agent version less than 2.19.0)
    /// </summary>
    /// <value>Content of the stack file (for compatibility to agent version less than 2.19.0)</value>
    [JsonPropertyName("stackFileContent")]
    public string StackFileContent { get; set; }

    /// <summary>
    /// Is relative path supported
    /// </summary>
    /// <value>Is relative path supported</value>
    [JsonPropertyName("supportRelativePath")]
    public bool? SupportRelativePath { get; set; }

    /// <summary>
    /// Version of the stack file
    /// </summary>
    /// <value>Version of the stack file</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class EdgeStackPayload {\n");
        sb.Append("  DeployerOptionsPayload: ").Append(DeployerOptionsPayload).Append("\n");
        sb.Append("  DirEntries: ").Append(DirEntries).Append("\n");
        sb.Append("  EdgeUpdateID: ").Append(EdgeUpdateID).Append("\n");
        sb.Append("  EntryFileName: ").Append(EntryFileName).Append("\n");
        sb.Append("  EnvVars: ").Append(EnvVars).Append("\n");
        sb.Append("  FilesystemPath: ").Append(FilesystemPath).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  PrePullImage: ").Append(PrePullImage).Append("\n");
        sb.Append("  RePullImage: ").Append(RePullImage).Append("\n");
        sb.Append("  ReadyRePullImage: ").Append(ReadyRePullImage).Append("\n");
        sb.Append("  RegistryCredentials: ").Append(RegistryCredentials).Append("\n");
        sb.Append("  RetryDeploy: ").Append(RetryDeploy).Append("\n");
        sb.Append("  RetryPeriod: ").Append(RetryPeriod).Append("\n");
        sb.Append("  RollbackTo: ").Append(RollbackTo).Append("\n");
        sb.Append("  StackFileContent: ").Append(StackFileContent).Append("\n");
        sb.Append("  SupportRelativePath: ").Append(SupportRelativePath).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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