#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EndpointsEndpointUpdatePayload {
    /// <summary>
    /// Azure application ID
    /// </summary>
    /// <value>Azure application ID</value>
    [JsonPropertyName("azureApplicationID")]
    public string AzureApplicationID { get; set; }

    /// <summary>
    /// Azure authentication key
    /// </summary>
    /// <value>Azure authentication key</value>
    [JsonPropertyName("azureAuthenticationKey")]
    public string AzureAuthenticationKey { get; set; }

    /// <summary>
    /// Azure tenant ID
    /// </summary>
    /// <value>Azure tenant ID</value>
    [JsonPropertyName("azureTenantID")]
    public string AzureTenantID { get; set; }

    /// <summary>
    /// The check in interval for edge agent (in seconds)
    /// </summary>
    /// <value>The check in interval for edge agent (in seconds)</value>
    [JsonPropertyName("edgeCheckinInterval")]
    public int? EdgeCheckinInterval { get; set; }

    /// <summary>
    /// GPUs information
    /// </summary>
    /// <value>GPUs information</value>
    [JsonPropertyName("gpus")]
    public List<PortainerPair> Gpus { get; set; }

    /// <summary>
    /// Group identifier
    /// </summary>
    /// <value>Group identifier</value>
    [JsonPropertyName("groupID")]
    public int? GroupID { get; set; }

    /// <summary>
    /// Associated Kubernetes data
    /// </summary>
    /// <value>Associated Kubernetes data</value>
    [JsonPropertyName("kubernetes")]
    public PortainerKubernetesData Kubernetes { get; set; }

    /// <summary>
    /// Name that will be used to identify this environment(endpoint)
    /// </summary>
    /// <value>Name that will be used to identify this environment(endpoint)</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// URL or IP address where exposed containers will be reachable.\\ Defaults to URL if not specified
    /// </summary>
    /// <value>URL or IP address where exposed containers will be reachable.\\ Defaults to URL if not specified</value>
    [JsonPropertyName("publicURL")]
    public string PublicURL { get; set; }

    /// <summary>
    /// The status of the environment(endpoint) (1 - up, 2 - down)
    /// </summary>
    /// <value>The status of the environment(endpoint) (1 - up, 2 - down)</value>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// List of tag identifiers to which this environment(endpoint) is associated
    /// </summary>
    /// <value>List of tag identifiers to which this environment(endpoint) is associated</value>
    [JsonPropertyName("tagIDs")]
    public List<int?> TagIDs { get; set; }

    /// <summary>
    /// Gets or Sets TeamAccessPolicies
    /// </summary>
    [JsonPropertyName("teamAccessPolicies")]
    public PortainerTeamAccessPolicies TeamAccessPolicies { get; set; }

    /// <summary>
    /// Require TLS to connect against this environment(endpoint)
    /// </summary>
    /// <value>Require TLS to connect against this environment(endpoint)</value>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>
    /// Skip client verification when using TLS
    /// </summary>
    /// <value>Skip client verification when using TLS</value>
    [JsonPropertyName("tlsskipClientVerify")]
    public bool? TlsskipClientVerify { get; set; }

    /// <summary>
    /// Skip server verification when using TLS
    /// </summary>
    /// <value>Skip server verification when using TLS</value>
    [JsonPropertyName("tlsskipVerify")]
    public bool? TlsskipVerify { get; set; }

    /// <summary>
    /// URL or IP address of a Docker host
    /// </summary>
    /// <value>URL or IP address of a Docker host</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets UserAccessPolicies
    /// </summary>
    [JsonPropertyName("userAccessPolicies")]
    public PortainerUserAccessPolicies UserAccessPolicies { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class EndpointsEndpointUpdatePayload {\n");
        sb.Append("  AzureApplicationID: ").Append(AzureApplicationID).Append("\n");
        sb.Append("  AzureAuthenticationKey: ").Append(AzureAuthenticationKey).Append("\n");
        sb.Append("  AzureTenantID: ").Append(AzureTenantID).Append("\n");
        sb.Append("  EdgeCheckinInterval: ").Append(EdgeCheckinInterval).Append("\n");
        sb.Append("  Gpus: ").Append(Gpus).Append("\n");
        sb.Append("  GroupID: ").Append(GroupID).Append("\n");
        sb.Append("  Kubernetes: ").Append(Kubernetes).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PublicURL: ").Append(PublicURL).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  TagIDs: ").Append(TagIDs).Append("\n");
        sb.Append("  TeamAccessPolicies: ").Append(TeamAccessPolicies).Append("\n");
        sb.Append("  Tls: ").Append(Tls).Append("\n");
        sb.Append("  TlsskipClientVerify: ").Append(TlsskipClientVerify).Append("\n");
        sb.Append("  TlsskipVerify: ").Append(TlsskipVerify).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  UserAccessPolicies: ").Append(UserAccessPolicies).Append("\n");
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