#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerStack {
    /// <summary>
    /// Only applies when deploying stack with multiple files
    /// </summary>
    /// <value>Only applies when deploying stack with multiple files</value>
    [JsonPropertyName("AdditionalFiles")]
    public List<string> AdditionalFiles { get; set; }

    /// <summary>
    /// The GitOps update settings of a git stack
    /// </summary>
    /// <value>The GitOps update settings of a git stack</value>
    [JsonPropertyName("AutoUpdate")]
    public PortainerAutoUpdateSettings AutoUpdate { get; set; }

    /// <summary>
    /// Environment(Endpoint) identifier. Reference the environment(endpoint) that will be used for deployment
    /// </summary>
    /// <value>Environment(Endpoint) identifier. Reference the environment(endpoint) that will be used for deployment</value>
    [JsonPropertyName("EndpointId")]
    public int? EndpointId { get; set; }

    /// <summary>
    /// Path to the Stack file
    /// </summary>
    /// <value>Path to the Stack file</value>
    [JsonPropertyName("EntryPoint")]
    public string EntryPoint { get; set; }

    /// <summary>
    /// A list of environment(endpoint) variables used during stack deployment
    /// </summary>
    /// <value>A list of environment(endpoint) variables used during stack deployment</value>
    [JsonPropertyName("Env")]
    public List<PortainerPair> Env { get; set; }

    /// <summary>
    /// Stack Identifier
    /// </summary>
    /// <value>Stack Identifier</value>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Stack name
    /// </summary>
    /// <value>Stack name</value>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// The stack deployment option
    /// </summary>
    /// <value>The stack deployment option</value>
    [JsonPropertyName("Option")]
    public PortainerStackOption Option { get; set; }

    /// <summary>
    /// Gets or Sets ResourceControl
    /// </summary>
    [JsonPropertyName("ResourceControl")]
    public PortainerResourceControl ResourceControl { get; set; }

    /// <summary>
    /// Stack status (1 - active, 2 - inactive)
    /// </summary>
    /// <value>Stack status (1 - active, 2 - inactive)</value>
    [JsonPropertyName("Status")]
    public int? Status { get; set; }

    /// <summary>
    /// Cluster identifier of the Swarm cluster where the stack is deployed
    /// </summary>
    /// <value>Cluster identifier of the Swarm cluster where the stack is deployed</value>
    [JsonPropertyName("SwarmId")]
    public string SwarmId { get; set; }

    /// <summary>
    /// Stack type. 1 for a Swarm stack, 2 for a Compose stack
    /// </summary>
    /// <value>Stack type. 1 for a Swarm stack, 2 for a Compose stack</value>
    [JsonPropertyName("Type")]
    public int? Type { get; set; }

    /// <summary>
    /// The username which created this stack
    /// </summary>
    /// <value>The username which created this stack</value>
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// The date in unix time when stack was created
    /// </summary>
    /// <value>The date in unix time when stack was created</value>
    [JsonPropertyName("creationDate")]
    public int? CreationDate { get; set; }

    /// <summary>
    /// Whether the stack is from a app template
    /// </summary>
    /// <value>Whether the stack is from a app template</value>
    [JsonPropertyName("fromAppTemplate")]
    public bool? FromAppTemplate { get; set; }

    /// <summary>
    /// The git config of this stack
    /// </summary>
    /// <value>The git config of this stack</value>
    [JsonPropertyName("gitConfig")]
    public GittypesRepoConfig GitConfig { get; set; }

    /// <summary>
    /// Kubernetes namespace if stack is a kube application
    /// </summary>
    /// <value>Kubernetes namespace if stack is a kube application</value>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Path on disk to the repository hosting the Stack file
    /// </summary>
    /// <value>Path on disk to the repository hosting the Stack file</value>
    [JsonPropertyName("projectPath")]
    public string ProjectPath { get; set; }

    /// <summary>
    /// The date in unix time when stack was last updated
    /// </summary>
    /// <value>The date in unix time when stack was last updated</value>
    [JsonPropertyName("updateDate")]
    public int? UpdateDate { get; set; }

    /// <summary>
    /// The username which last updated this stack
    /// </summary>
    /// <value>The username which last updated this stack</value>
    [JsonPropertyName("updatedBy")]
    public string UpdatedBy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerStack {\n");
        sb.Append("  AdditionalFiles: ").Append(AdditionalFiles).Append("\n");
        sb.Append("  AutoUpdate: ").Append(AutoUpdate).Append("\n");
        sb.Append("  EndpointId: ").Append(EndpointId).Append("\n");
        sb.Append("  EntryPoint: ").Append(EntryPoint).Append("\n");
        sb.Append("  Env: ").Append(Env).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Option: ").Append(Option).Append("\n");
        sb.Append("  ResourceControl: ").Append(ResourceControl).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  SwarmId: ").Append(SwarmId).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
        sb.Append("  FromAppTemplate: ").Append(FromAppTemplate).Append("\n");
        sb.Append("  GitConfig: ").Append(GitConfig).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  ProjectPath: ").Append(ProjectPath).Append("\n");
        sb.Append("  UpdateDate: ").Append(UpdateDate).Append("\n");
        sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
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