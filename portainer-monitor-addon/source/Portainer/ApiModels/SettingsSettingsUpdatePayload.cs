#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class SettingsSettingsUpdatePayload {
    /// <summary>
    /// EdgePortainerURL is the URL that is exposed to edge agents
    /// </summary>
    /// <value>EdgePortainerURL is the URL that is exposed to edge agents</value>
    [JsonPropertyName("EdgePortainerURL")]
    public string EdgePortainerURL { get; set; }

    /// <summary>
    /// Active authentication method for the Portainer instance. Valid values are: 1 for internal, 2 for LDAP, or 3 for oauth
    /// </summary>
    /// <value>Active authentication method for the Portainer instance. Valid values are: 1 for internal, 2 for LDAP, or 3 for oauth</value>
    [JsonPropertyName("authenticationMethod")]
    public int? AuthenticationMethod { get; set; }

    /// <summary>
    /// A list of label name & value that will be used to hide containers when querying containers
    /// </summary>
    /// <value>A list of label name & value that will be used to hide containers when querying containers</value>
    [JsonPropertyName("blackListedLabels")]
    public List<PortainerPair> BlackListedLabels { get; set; }

    /// <summary>
    /// Gets or Sets EdgeAgentCheckinInterval
    /// </summary>
    [JsonPropertyName("edgeAgentCheckinInterval")]
    public int? EdgeAgentCheckinInterval { get; set; }

    /// <summary>
    /// Whether edge compute features are enabled
    /// </summary>
    /// <value>Whether edge compute features are enabled</value>
    [JsonPropertyName("enableEdgeComputeFeatures")]
    public bool? EnableEdgeComputeFeatures { get; set; }

    /// <summary>
    /// Whether telemetry is enabled
    /// </summary>
    /// <value>Whether telemetry is enabled</value>
    [JsonPropertyName("enableTelemetry")]
    public bool? EnableTelemetry { get; set; }

    /// <summary>
    /// EnforceEdgeID makes Portainer store the Edge ID instead of accepting anyone
    /// </summary>
    /// <value>EnforceEdgeID makes Portainer store the Edge ID instead of accepting anyone</value>
    [JsonPropertyName("enforceEdgeID")]
    public bool? EnforceEdgeID { get; set; }

    /// <summary>
    /// Deployment options for encouraging deployment as code
    /// </summary>
    /// <value>Deployment options for encouraging deployment as code</value>
    [JsonPropertyName("globalDeploymentOptions")]
    public PortainerGlobalDeploymentOptions GlobalDeploymentOptions { get; set; }

    /// <summary>
    /// Helm repository URL
    /// </summary>
    /// <value>Helm repository URL</value>
    [JsonPropertyName("helmRepositoryURL")]
    public string HelmRepositoryURL { get; set; }

    /// <summary>
    /// Gets or Sets InternalAuthSettings
    /// </summary>
    [JsonPropertyName("internalAuthSettings")]
    public PortainerInternalAuthSettings InternalAuthSettings { get; set; }

    /// <summary>
    /// The expiry of a Kubeconfig
    /// </summary>
    /// <value>The expiry of a Kubeconfig</value>
    [JsonPropertyName("kubeconfigExpiry")]
    public string KubeconfigExpiry { get; set; }

    /// <summary>
    /// Kubectl Shell Image
    /// </summary>
    /// <value>Kubectl Shell Image</value>
    [JsonPropertyName("kubectlShellImage")]
    public string KubectlShellImage { get; set; }

    /// <summary>
    /// Gets or Sets Ldapsettings
    /// </summary>
    [JsonPropertyName("ldapsettings")]
    public PortainerLDAPSettings Ldapsettings { get; set; }

    /// <summary>
    /// URL to a logo that will be displayed on the login page as well as on top of the sidebar. Will use default Portainer logo when value is empty string
    /// </summary>
    /// <value>URL to a logo that will be displayed on the login page as well as on top of the sidebar. Will use default Portainer logo when value is empty string</value>
    [JsonPropertyName("logoURL")]
    public string LogoURL { get; set; }

    /// <summary>
    /// Gets or Sets OauthSettings
    /// </summary>
    [JsonPropertyName("oauthSettings")]
    public PortainerOAuthSettings OauthSettings { get; set; }

    /// <summary>
    /// The interval in which environment(endpoint) snapshots are created
    /// </summary>
    /// <value>The interval in which environment(endpoint) snapshots are created</value>
    [JsonPropertyName("snapshotInterval")]
    public string SnapshotInterval { get; set; }

    /// <summary>
    /// URL to the templates that will be displayed in the UI when navigating to App Templates
    /// </summary>
    /// <value>URL to the templates that will be displayed in the UI when navigating to App Templates</value>
    [JsonPropertyName("templatesURL")]
    public string TemplatesURL { get; set; }

    /// <summary>
    /// TrustOnFirstConnect makes Portainer accepting edge agent connection by default
    /// </summary>
    /// <value>TrustOnFirstConnect makes Portainer accepting edge agent connection by default</value>
    [JsonPropertyName("trustOnFirstConnect")]
    public bool? TrustOnFirstConnect { get; set; }

    /// <summary>
    /// The duration of a user session
    /// </summary>
    /// <value>The duration of a user session</value>
    [JsonPropertyName("userSessionTimeout")]
    public string UserSessionTimeout { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class SettingsSettingsUpdatePayload {\n");
        sb.Append("  EdgePortainerURL: ").Append(EdgePortainerURL).Append("\n");
        sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
        sb.Append("  BlackListedLabels: ").Append(BlackListedLabels).Append("\n");
        sb.Append("  EdgeAgentCheckinInterval: ").Append(EdgeAgentCheckinInterval).Append("\n");
        sb.Append("  EnableEdgeComputeFeatures: ").Append(EnableEdgeComputeFeatures).Append("\n");
        sb.Append("  EnableTelemetry: ").Append(EnableTelemetry).Append("\n");
        sb.Append("  EnforceEdgeID: ").Append(EnforceEdgeID).Append("\n");
        sb.Append("  GlobalDeploymentOptions: ").Append(GlobalDeploymentOptions).Append("\n");
        sb.Append("  HelmRepositoryURL: ").Append(HelmRepositoryURL).Append("\n");
        sb.Append("  InternalAuthSettings: ").Append(InternalAuthSettings).Append("\n");
        sb.Append("  KubeconfigExpiry: ").Append(KubeconfigExpiry).Append("\n");
        sb.Append("  KubectlShellImage: ").Append(KubectlShellImage).Append("\n");
        sb.Append("  Ldapsettings: ").Append(Ldapsettings).Append("\n");
        sb.Append("  LogoURL: ").Append(LogoURL).Append("\n");
        sb.Append("  OauthSettings: ").Append(OauthSettings).Append("\n");
        sb.Append("  SnapshotInterval: ").Append(SnapshotInterval).Append("\n");
        sb.Append("  TemplatesURL: ").Append(TemplatesURL).Append("\n");
        sb.Append("  TrustOnFirstConnect: ").Append(TrustOnFirstConnect).Append("\n");
        sb.Append("  UserSessionTimeout: ").Append(UserSessionTimeout).Append("\n");
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