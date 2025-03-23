#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class SettingsPublicSettingsResponse {
    /// <summary>
    /// Active authentication method for the Portainer instance. Valid values are: 1 for internal, 2 for LDAP, or 3 for oauth
    /// </summary>
    /// <value>Active authentication method for the Portainer instance. Valid values are: 1 for internal, 2 for LDAP, or 3 for oauth</value>
    [JsonPropertyName("AuthenticationMethod")]
    public int? AuthenticationMethod { get; set; }

    /// <summary>
    /// Whether edge compute features are enabled
    /// </summary>
    /// <value>Whether edge compute features are enabled</value>
    [JsonPropertyName("EnableEdgeComputeFeatures")]
    public bool? EnableEdgeComputeFeatures { get; set; }

    /// <summary>
    /// Whether telemetry is enabled
    /// </summary>
    /// <value>Whether telemetry is enabled</value>
    [JsonPropertyName("EnableTelemetry")]
    public bool? EnableTelemetry { get; set; }

    /// <summary>
    /// Supported feature flags
    /// </summary>
    /// <value>Supported feature flags</value>
    [JsonPropertyName("Features")]
    public Dictionary<string, bool?> Features { get; set; }

    /// <summary>
    /// Deployment options for encouraging deployment as code
    /// </summary>
    /// <value>Deployment options for encouraging deployment as code</value>
    [JsonPropertyName("GlobalDeploymentOptions")]
    public PortainerGlobalDeploymentOptions GlobalDeploymentOptions { get; set; }

    /// <summary>
    /// Gets or Sets IsDockerDesktopExtension
    /// </summary>
    [JsonPropertyName("IsDockerDesktopExtension")]
    public bool? IsDockerDesktopExtension { get; set; }

    /// <summary>
    /// URL to a logo that will be displayed on the login page as well as on top of the sidebar. Will use default Portainer logo when value is empty string
    /// </summary>
    /// <value>URL to a logo that will be displayed on the login page as well as on top of the sidebar. Will use default Portainer logo when value is empty string</value>
    [JsonPropertyName("LogoURL")]
    public string LogoURL { get; set; }

    /// <summary>
    /// The URL used for oauth login
    /// </summary>
    /// <value>The URL used for oauth login</value>
    [JsonPropertyName("OAuthLoginURI")]
    public string OAuthLoginURI { get; set; }

    /// <summary>
    /// The URL used for oauth logout
    /// </summary>
    /// <value>The URL used for oauth logout</value>
    [JsonPropertyName("OAuthLogoutURI")]
    public string OAuthLogoutURI { get; set; }

    /// <summary>
    /// The minimum required length for a password of any user when using internal auth mode
    /// </summary>
    /// <value>The minimum required length for a password of any user when using internal auth mode</value>
    [JsonPropertyName("RequiredPasswordLength")]
    public int? RequiredPasswordLength { get; set; }

    /// <summary>
    /// Whether team sync is enabled
    /// </summary>
    /// <value>Whether team sync is enabled</value>
    [JsonPropertyName("TeamSync")]
    public bool? TeamSync { get; set; }

    /// <summary>
    /// Gets or Sets Edge
    /// </summary>
    [JsonPropertyName("edge")]
    public SettingsPublicSettingsResponseEdge Edge { get; set; }

    /// <summary>
    /// Whether AMT is enabled
    /// </summary>
    /// <value>Whether AMT is enabled</value>
    [JsonPropertyName("isAMTEnabled")]
    public bool? IsAMTEnabled { get; set; }

    /// <summary>
    /// The expiry of a Kubeconfig
    /// </summary>
    /// <value>The expiry of a Kubeconfig</value>
    [JsonPropertyName("kubeconfigExpiry")]
    public string KubeconfigExpiry { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class SettingsPublicSettingsResponse {\n");
        sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
        sb.Append("  EnableEdgeComputeFeatures: ").Append(EnableEdgeComputeFeatures).Append("\n");
        sb.Append("  EnableTelemetry: ").Append(EnableTelemetry).Append("\n");
        sb.Append("  Features: ").Append(Features).Append("\n");
        sb.Append("  GlobalDeploymentOptions: ").Append(GlobalDeploymentOptions).Append("\n");
        sb.Append("  IsDockerDesktopExtension: ").Append(IsDockerDesktopExtension).Append("\n");
        sb.Append("  LogoURL: ").Append(LogoURL).Append("\n");
        sb.Append("  OAuthLoginURI: ").Append(OAuthLoginURI).Append("\n");
        sb.Append("  OAuthLogoutURI: ").Append(OAuthLogoutURI).Append("\n");
        sb.Append("  RequiredPasswordLength: ").Append(RequiredPasswordLength).Append("\n");
        sb.Append("  TeamSync: ").Append(TeamSync).Append("\n");
        sb.Append("  Edge: ").Append(Edge).Append("\n");
        sb.Append("  IsAMTEnabled: ").Append(IsAMTEnabled).Append("\n");
        sb.Append("  KubeconfigExpiry: ").Append(KubeconfigExpiry).Append("\n");
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