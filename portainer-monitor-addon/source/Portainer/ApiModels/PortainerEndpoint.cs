#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerEndpoint {
    /// <summary>
    /// The identifier of the AMT Device associated with this environment(endpoint)
    /// </summary>
    /// <value>The identifier of the AMT Device associated with this environment(endpoint)</value>
    [JsonPropertyName("AMTDeviceGUID")]
    public string AMTDeviceGUID { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizedTeams
    /// </summary>
    [JsonPropertyName("AuthorizedTeams")]
    public List<int?> AuthorizedTeams { get; set; }

    /// <summary>
    /// Deprecated in DBVersion == 18
    /// </summary>
    /// <value>Deprecated in DBVersion == 18</value>
    [JsonPropertyName("AuthorizedUsers")]
    public List<int?> AuthorizedUsers { get; set; }

    /// <summary>
    /// Gets or Sets AzureCredentials
    /// </summary>
    [JsonPropertyName("AzureCredentials")]
    public PortainerAzureCredentials AzureCredentials { get; set; }

    /// <summary>
    /// Maximum version of docker-compose
    /// </summary>
    /// <value>Maximum version of docker-compose</value>
    [JsonPropertyName("ComposeSyntaxMaxVersion")]
    public string ComposeSyntaxMaxVersion { get; set; }

    /// <summary>
    /// ContainerEngine represents the container engine type. This can be 'docker' or 'podman' when interacting directly with these environmentes, otherwise '' for kubernetes environments.
    /// </summary>
    /// <value>ContainerEngine represents the container engine type. This can be 'docker' or 'podman' when interacting directly with these environmentes, otherwise '' for kubernetes environments.</value>
    [JsonPropertyName("ContainerEngine")]
    public string ContainerEngine { get; set; }

    /// <summary>
    /// The check in interval for edge agent (in seconds)
    /// </summary>
    /// <value>The check in interval for edge agent (in seconds)</value>
    [JsonPropertyName("EdgeCheckinInterval")]
    public int? EdgeCheckinInterval { get; set; }

    /// <summary>
    /// The identifier of the edge agent associated with this environment(endpoint)
    /// </summary>
    /// <value>The identifier of the edge agent associated with this environment(endpoint)</value>
    [JsonPropertyName("EdgeID")]
    public string EdgeID { get; set; }

    /// <summary>
    /// The key which is used to map the agent to Portainer
    /// </summary>
    /// <value>The key which is used to map the agent to Portainer</value>
    [JsonPropertyName("EdgeKey")]
    public string EdgeKey { get; set; }

    /// <summary>
    /// Gets or Sets EnableGPUManagement
    /// </summary>
    [JsonPropertyName("EnableGPUManagement")]
    public bool? EnableGPUManagement { get; set; }

    /// <summary>
    /// Gets or Sets Gpus
    /// </summary>
    [JsonPropertyName("Gpus")]
    public List<PortainerPair> Gpus { get; set; }

    /// <summary>
    /// Environment(Endpoint) group identifier
    /// </summary>
    /// <value>Environment(Endpoint) group identifier</value>
    [JsonPropertyName("GroupId")]
    public int? GroupId { get; set; }

    /// <summary>
    /// Heartbeat indicates the heartbeat status of an edge environment
    /// </summary>
    /// <value>Heartbeat indicates the heartbeat status of an edge environment</value>
    [JsonPropertyName("Heartbeat")]
    public bool? Heartbeat { get; set; }

    /// <summary>
    /// Environment(Endpoint) Identifier
    /// </summary>
    /// <value>Environment(Endpoint) Identifier</value>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Deprecated v2.18
    /// </summary>
    /// <value>Deprecated v2.18</value>
    [JsonPropertyName("IsEdgeDevice")]
    public bool? IsEdgeDevice { get; set; }

    /// <summary>
    /// Associated Kubernetes data
    /// </summary>
    /// <value>Associated Kubernetes data</value>
    [JsonPropertyName("Kubernetes")]
    public PortainerKubernetesData Kubernetes { get; set; }

    /// <summary>
    /// Environment(Endpoint) name
    /// </summary>
    /// <value>Environment(Endpoint) name</value>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Whether we need to run any \"post init migrations\".
    /// </summary>
    /// <value>Whether we need to run any \"post init migrations\".</value>
    [JsonPropertyName("PostInitMigrations")]
    public PortainerEndpointPostInitMigrations PostInitMigrations { get; set; }

    /// <summary>
    /// URL or IP address where exposed containers will be reachable
    /// </summary>
    /// <value>URL or IP address where exposed containers will be reachable</value>
    [JsonPropertyName("PublicURL")]
    public string PublicURL { get; set; }

    /// <summary>
    /// List of snapshots
    /// </summary>
    /// <value>List of snapshots</value>
    [JsonPropertyName("Snapshots")]
    public List<PortainerDockerSnapshot> Snapshots { get; set; } = new();

    /// <summary>
    /// The status of the environment(endpoint) (1 - up, 2 - down)
    /// </summary>
    /// <value>The status of the environment(endpoint) (1 - up, 2 - down)</value>
    [JsonPropertyName("Status")]
    public int? Status { get; set; }

    /// <summary>
    /// Deprecated fields Deprecated in DBVersion == 4
    /// </summary>
    /// <value>Deprecated fields Deprecated in DBVersion == 4</value>
    [JsonPropertyName("TLS")]
    public bool? TLS { get; set; }

    /// <summary>
    /// Gets or Sets TLSCACert
    /// </summary>
    [JsonPropertyName("TLSCACert")]
    public string TLSCACert { get; set; }

    /// <summary>
    /// Gets or Sets TLSCert
    /// </summary>
    [JsonPropertyName("TLSCert")]
    public string TLSCert { get; set; }

    /// <summary>
    /// Gets or Sets TLSConfig
    /// </summary>
    [JsonPropertyName("TLSConfig")]
    public PortainerTLSConfiguration TLSConfig { get; set; }

    /// <summary>
    /// Gets or Sets TLSKey
    /// </summary>
    [JsonPropertyName("TLSKey")]
    public string TLSKey { get; set; }

    /// <summary>
    /// List of tag identifiers to which this environment(endpoint) is associated
    /// </summary>
    /// <value>List of tag identifiers to which this environment(endpoint) is associated</value>
    [JsonPropertyName("TagIds")]
    public List<int?> TagIds { get; set; }

    /// <summary>
    /// Deprecated in DBVersion == 22
    /// </summary>
    /// <value>Deprecated in DBVersion == 22</value>
    [JsonPropertyName("Tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// List of team identifiers authorized to connect to this environment(endpoint)
    /// </summary>
    /// <value>List of team identifiers authorized to connect to this environment(endpoint)</value>
    [JsonPropertyName("TeamAccessPolicies")]
    public PortainerTeamAccessPolicies TeamAccessPolicies { get; set; }

    /// <summary>
    /// Environment(Endpoint) environment(endpoint) type. 1 for a Docker environment(endpoint), 2 for an agent on Docker environment(endpoint) or 3 for an Azure environment(endpoint).
    /// </summary>
    /// <value>Environment(Endpoint) environment(endpoint) type. 1 for a Docker environment(endpoint), 2 for an agent on Docker environment(endpoint) or 3 for an Azure environment(endpoint).</value>
    [JsonPropertyName("Type")]
    public int? Type { get; set; }

    /// <summary>
    /// URL or IP address of the Docker host associated to this environment(endpoint)
    /// </summary>
    /// <value>URL or IP address of the Docker host associated to this environment(endpoint)</value>
    [JsonPropertyName("URL")]
    public string URL { get; set; }

    /// <summary>
    /// List of user identifiers authorized to connect to this environment(endpoint)
    /// </summary>
    /// <value>List of user identifiers authorized to connect to this environment(endpoint)</value>
    [JsonPropertyName("UserAccessPolicies")]
    public PortainerUserAccessPolicies UserAccessPolicies { get; set; }

    /// <summary>
    /// Whether the device has been trusted or not by the user
    /// </summary>
    /// <value>Whether the device has been trusted or not by the user</value>
    [JsonPropertyName("UserTrusted")]
    public bool? UserTrusted { get; set; }

    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    [JsonPropertyName("agent")]
    public PortainerEndpointAgent Agent { get; set; }

    /// <summary>
    /// Gets or Sets Edge
    /// </summary>
    [JsonPropertyName("edge")]
    public PortainerEnvironmentEdgeSettings Edge { get; set; }

    /// <summary>
    /// LastCheckInDate mark last check-in date on checkin
    /// </summary>
    /// <value>LastCheckInDate mark last check-in date on checkin</value>
    [JsonPropertyName("lastCheckInDate")]
    public int? LastCheckInDate { get; set; }

    /// <summary>
    /// QueryDate of each query with the endpoints list
    /// </summary>
    /// <value>QueryDate of each query with the endpoints list</value>
    [JsonPropertyName("queryDate")]
    public int? QueryDate { get; set; }

    /// <summary>
    /// Environment(Endpoint) specific security settings
    /// </summary>
    /// <value>Environment(Endpoint) specific security settings</value>
    [JsonPropertyName("securitySettings")]
    public PortainerEndpointSecuritySettings SecuritySettings { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerEndpoint {\n");
        sb.Append("  AMTDeviceGUID: ").Append(AMTDeviceGUID).Append("\n");
        sb.Append("  AuthorizedTeams: ").Append(AuthorizedTeams).Append("\n");
        sb.Append("  AuthorizedUsers: ").Append(AuthorizedUsers).Append("\n");
        sb.Append("  AzureCredentials: ").Append(AzureCredentials).Append("\n");
        sb.Append("  ComposeSyntaxMaxVersion: ").Append(ComposeSyntaxMaxVersion).Append("\n");
        sb.Append("  ContainerEngine: ").Append(ContainerEngine).Append("\n");
        sb.Append("  EdgeCheckinInterval: ").Append(EdgeCheckinInterval).Append("\n");
        sb.Append("  EdgeID: ").Append(EdgeID).Append("\n");
        sb.Append("  EdgeKey: ").Append(EdgeKey).Append("\n");
        sb.Append("  EnableGPUManagement: ").Append(EnableGPUManagement).Append("\n");
        sb.Append("  Gpus: ").Append(Gpus).Append("\n");
        sb.Append("  GroupId: ").Append(GroupId).Append("\n");
        sb.Append("  Heartbeat: ").Append(Heartbeat).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  IsEdgeDevice: ").Append(IsEdgeDevice).Append("\n");
        sb.Append("  Kubernetes: ").Append(Kubernetes).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PostInitMigrations: ").Append(PostInitMigrations).Append("\n");
        sb.Append("  PublicURL: ").Append(PublicURL).Append("\n");
        sb.Append("  Snapshots: ").Append(Snapshots).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  TLS: ").Append(TLS).Append("\n");
        sb.Append("  TLSCACert: ").Append(TLSCACert).Append("\n");
        sb.Append("  TLSCert: ").Append(TLSCert).Append("\n");
        sb.Append("  TLSConfig: ").Append(TLSConfig).Append("\n");
        sb.Append("  TLSKey: ").Append(TLSKey).Append("\n");
        sb.Append("  TagIds: ").Append(TagIds).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  TeamAccessPolicies: ").Append(TeamAccessPolicies).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  URL: ").Append(URL).Append("\n");
        sb.Append("  UserAccessPolicies: ").Append(UserAccessPolicies).Append("\n");
        sb.Append("  UserTrusted: ").Append(UserTrusted).Append("\n");
        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  Edge: ").Append(Edge).Append("\n");
        sb.Append("  LastCheckInDate: ").Append(LastCheckInDate).Append("\n");
        sb.Append("  QueryDate: ").Append(QueryDate).Append("\n");
        sb.Append("  SecuritySettings: ").Append(SecuritySettings).Append("\n");
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