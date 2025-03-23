#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerSettings {
    /// <summary>
    /// Container environment parameter AGENT_SECRET
    /// </summary>
    /// <value>Container environment parameter AGENT_SECRET</value>
    [JsonPropertyName("AgentSecret")]
    public string AgentSecret { get; set; }

    /// <summary>
    /// Gets or Sets AllowBindMountsForRegularUsers
    /// </summary>
    [JsonPropertyName("AllowBindMountsForRegularUsers")]
    public bool? AllowBindMountsForRegularUsers { get; set; }

    /// <summary>
    /// Gets or Sets AllowContainerCapabilitiesForRegularUsers
    /// </summary>
    [JsonPropertyName("AllowContainerCapabilitiesForRegularUsers")]
    public bool? AllowContainerCapabilitiesForRegularUsers { get; set; }

    /// <summary>
    /// Gets or Sets AllowDeviceMappingForRegularUsers
    /// </summary>
    [JsonPropertyName("AllowDeviceMappingForRegularUsers")]
    public bool? AllowDeviceMappingForRegularUsers { get; set; }

    /// <summary>
    /// Gets or Sets AllowHostNamespaceForRegularUsers
    /// </summary>
    [JsonPropertyName("AllowHostNamespaceForRegularUsers")]
    public bool? AllowHostNamespaceForRegularUsers { get; set; }

    /// <summary>
    /// Gets or Sets AllowPrivilegedModeForRegularUsers
    /// </summary>
    [JsonPropertyName("AllowPrivilegedModeForRegularUsers")]
    public bool? AllowPrivilegedModeForRegularUsers { get; set; }

    /// <summary>
    /// Gets or Sets AllowStackManagementForRegularUsers
    /// </summary>
    [JsonPropertyName("AllowStackManagementForRegularUsers")]
    public bool? AllowStackManagementForRegularUsers { get; set; }

    /// <summary>
    /// Gets or Sets AllowVolumeBrowserForRegularUsers
    /// </summary>
    [JsonPropertyName("AllowVolumeBrowserForRegularUsers")]
    public bool? AllowVolumeBrowserForRegularUsers { get; set; }

    /// <summary>
    /// Active authentication method for the Portainer instance. Valid values are: 1 for internal, 2 for LDAP, or 3 for oauth
    /// </summary>
    /// <value>Active authentication method for the Portainer instance. Valid values are: 1 for internal, 2 for LDAP, or 3 for oauth</value>
    [JsonPropertyName("AuthenticationMethod")]
    public int? AuthenticationMethod { get; set; }

    /// <summary>
    /// A list of label name & value that will be used to hide containers when querying containers
    /// </summary>
    /// <value>A list of label name & value that will be used to hide containers when querying containers</value>
    [JsonPropertyName("BlackListedLabels")]
    public List<PortainerPair> BlackListedLabels { get; set; }

    /// <summary>
    /// Deprecated fields
    /// </summary>
    /// <value>Deprecated fields</value>
    [JsonPropertyName("DisplayDonationHeader")]
    public bool? DisplayDonationHeader { get; set; }

    /// <summary>
    /// Gets or Sets DisplayExternalContributors
    /// </summary>
    [JsonPropertyName("DisplayExternalContributors")]
    public bool? DisplayExternalContributors { get; set; }

    /// <summary>
    /// Gets or Sets Edge
    /// </summary>
    [JsonPropertyName("Edge")]
    public PortainerEdge Edge { get; set; }

    /// <summary>
    /// The default check in interval for edge agent (in seconds)
    /// </summary>
    /// <value>The default check in interval for edge agent (in seconds)</value>
    [JsonPropertyName("EdgeAgentCheckinInterval")]
    public int? EdgeAgentCheckinInterval { get; set; }

    /// <summary>
    /// EdgePortainerURL is the URL that is exposed to edge agents
    /// </summary>
    /// <value>EdgePortainerURL is the URL that is exposed to edge agents</value>
    [JsonPropertyName("EdgePortainerUrl")]
    public string EdgePortainerUrl { get; set; }

    /// <summary>
    /// Whether edge compute features are enabled
    /// </summary>
    /// <value>Whether edge compute features are enabled</value>
    [JsonPropertyName("EnableEdgeComputeFeatures")]
    public bool? EnableEdgeComputeFeatures { get; set; }

    /// <summary>
    /// Deprecated fields v26
    /// </summary>
    /// <value>Deprecated fields v26</value>
    [JsonPropertyName("EnableHostManagementFeatures")]
    public bool? EnableHostManagementFeatures { get; set; }

    /// <summary>
    /// Whether telemetry is enabled
    /// </summary>
    /// <value>Whether telemetry is enabled</value>
    [JsonPropertyName("EnableTelemetry")]
    public bool? EnableTelemetry { get; set; }

    /// <summary>
    /// EnforceEdgeID makes Portainer store the Edge ID instead of accepting anyone
    /// </summary>
    /// <value>EnforceEdgeID makes Portainer store the Edge ID instead of accepting anyone</value>
    [JsonPropertyName("EnforceEdgeID")]
    public bool? EnforceEdgeID { get; set; }

    /// <summary>
    /// Gets or Sets FeatureFlagSettings
    /// </summary>
    [JsonPropertyName("FeatureFlagSettings")]
    public Dictionary<string, bool?> FeatureFlagSettings { get; set; }

    /// <summary>
    /// Deployment options for encouraging git ops workflows
    /// </summary>
    /// <value>Deployment options for encouraging git ops workflows</value>
    [JsonPropertyName("GlobalDeploymentOptions")]
    public PortainerGlobalDeploymentOptions GlobalDeploymentOptions { get; set; }

    /// <summary>
    /// Helm repository URL, defaults to \"\"
    /// </summary>
    /// <value>Helm repository URL, defaults to \"\"</value>
    [JsonPropertyName("HelmRepositoryURL")]
    public string HelmRepositoryURL { get; set; }

    /// <summary>
    /// Gets or Sets InternalAuthSettings
    /// </summary>
    [JsonPropertyName("InternalAuthSettings")]
    public PortainerInternalAuthSettings InternalAuthSettings { get; set; }

    /// <summary>
    /// Gets or Sets IsDockerDesktopExtension
    /// </summary>
    [JsonPropertyName("IsDockerDesktopExtension")]
    public bool? IsDockerDesktopExtension { get; set; }

    /// <summary>
    /// The expiry of a Kubeconfig
    /// </summary>
    /// <value>The expiry of a Kubeconfig</value>
    [JsonPropertyName("KubeconfigExpiry")]
    public string KubeconfigExpiry { get; set; }

    /// <summary>
    /// KubectlImage, defaults to portainer/kubectl-shell
    /// </summary>
    /// <value>KubectlImage, defaults to portainer/kubectl-shell</value>
    [JsonPropertyName("KubectlShellImage")]
    public string KubectlShellImage { get; set; }

    /// <summary>
    /// Gets or Sets LDAPSettings
    /// </summary>
    [JsonPropertyName("LDAPSettings")]
    public PortainerLDAPSettings LDAPSettings { get; set; }

    /// <summary>
    /// URL to a logo that will be displayed on the login page as well as on top of the sidebar. Will use default Portainer logo when value is empty string
    /// </summary>
    /// <value>URL to a logo that will be displayed on the login page as well as on top of the sidebar. Will use default Portainer logo when value is empty string</value>
    [JsonPropertyName("LogoURL")]
    public string LogoURL { get; set; }

    /// <summary>
    /// Gets or Sets OAuthSettings
    /// </summary>
    [JsonPropertyName("OAuthSettings")]
    public PortainerOAuthSettings OAuthSettings { get; set; }

    /// <summary>
    /// The interval in which environment(endpoint) snapshots are created
    /// </summary>
    /// <value>The interval in which environment(endpoint) snapshots are created</value>
    [JsonPropertyName("SnapshotInterval")]
    public string SnapshotInterval { get; set; }

    /// <summary>
    /// URL to the templates that will be displayed in the UI when navigating to App Templates
    /// </summary>
    /// <value>URL to the templates that will be displayed in the UI when navigating to App Templates</value>
    [JsonPropertyName("TemplatesURL")]
    public string TemplatesURL { get; set; }

    /// <summary>
    /// TrustOnFirstConnect makes Portainer accepting edge agent connection by default
    /// </summary>
    /// <value>TrustOnFirstConnect makes Portainer accepting edge agent connection by default</value>
    [JsonPropertyName("TrustOnFirstConnect")]
    public bool? TrustOnFirstConnect { get; set; }

    /// <summary>
    /// The duration of a user session
    /// </summary>
    /// <value>The duration of a user session</value>
    [JsonPropertyName("UserSessionTimeout")]
    public string UserSessionTimeout { get; set; }

    /// <summary>
    /// Gets or Sets OpenAMTConfiguration
    /// </summary>
    [JsonPropertyName("openAMTConfiguration")]
    public PortainerOpenAMTConfiguration OpenAMTConfiguration { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerSettings {\n");
        sb.Append("  AgentSecret: ").Append(AgentSecret).Append("\n");
        sb.Append("  AllowBindMountsForRegularUsers: ").Append(AllowBindMountsForRegularUsers).Append("\n");
        sb.Append("  AllowContainerCapabilitiesForRegularUsers: ").Append(AllowContainerCapabilitiesForRegularUsers).Append("\n");
        sb.Append("  AllowDeviceMappingForRegularUsers: ").Append(AllowDeviceMappingForRegularUsers).Append("\n");
        sb.Append("  AllowHostNamespaceForRegularUsers: ").Append(AllowHostNamespaceForRegularUsers).Append("\n");
        sb.Append("  AllowPrivilegedModeForRegularUsers: ").Append(AllowPrivilegedModeForRegularUsers).Append("\n");
        sb.Append("  AllowStackManagementForRegularUsers: ").Append(AllowStackManagementForRegularUsers).Append("\n");
        sb.Append("  AllowVolumeBrowserForRegularUsers: ").Append(AllowVolumeBrowserForRegularUsers).Append("\n");
        sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
        sb.Append("  BlackListedLabels: ").Append(BlackListedLabels).Append("\n");
        sb.Append("  DisplayDonationHeader: ").Append(DisplayDonationHeader).Append("\n");
        sb.Append("  DisplayExternalContributors: ").Append(DisplayExternalContributors).Append("\n");
        sb.Append("  Edge: ").Append(Edge).Append("\n");
        sb.Append("  EdgeAgentCheckinInterval: ").Append(EdgeAgentCheckinInterval).Append("\n");
        sb.Append("  EdgePortainerUrl: ").Append(EdgePortainerUrl).Append("\n");
        sb.Append("  EnableEdgeComputeFeatures: ").Append(EnableEdgeComputeFeatures).Append("\n");
        sb.Append("  EnableHostManagementFeatures: ").Append(EnableHostManagementFeatures).Append("\n");
        sb.Append("  EnableTelemetry: ").Append(EnableTelemetry).Append("\n");
        sb.Append("  EnforceEdgeID: ").Append(EnforceEdgeID).Append("\n");
        sb.Append("  FeatureFlagSettings: ").Append(FeatureFlagSettings).Append("\n");
        sb.Append("  GlobalDeploymentOptions: ").Append(GlobalDeploymentOptions).Append("\n");
        sb.Append("  HelmRepositoryURL: ").Append(HelmRepositoryURL).Append("\n");
        sb.Append("  InternalAuthSettings: ").Append(InternalAuthSettings).Append("\n");
        sb.Append("  IsDockerDesktopExtension: ").Append(IsDockerDesktopExtension).Append("\n");
        sb.Append("  KubeconfigExpiry: ").Append(KubeconfigExpiry).Append("\n");
        sb.Append("  KubectlShellImage: ").Append(KubectlShellImage).Append("\n");
        sb.Append("  LDAPSettings: ").Append(LDAPSettings).Append("\n");
        sb.Append("  LogoURL: ").Append(LogoURL).Append("\n");
        sb.Append("  OAuthSettings: ").Append(OAuthSettings).Append("\n");
        sb.Append("  SnapshotInterval: ").Append(SnapshotInterval).Append("\n");
        sb.Append("  TemplatesURL: ").Append(TemplatesURL).Append("\n");
        sb.Append("  TrustOnFirstConnect: ").Append(TrustOnFirstConnect).Append("\n");
        sb.Append("  UserSessionTimeout: ").Append(UserSessionTimeout).Append("\n");
        sb.Append("  OpenAMTConfiguration: ").Append(OpenAMTConfiguration).Append("\n");
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