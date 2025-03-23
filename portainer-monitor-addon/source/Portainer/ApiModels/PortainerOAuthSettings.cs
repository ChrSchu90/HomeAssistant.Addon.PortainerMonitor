#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerOAuthSettings {
    /// <summary>
    /// Gets or Sets AccessTokenURI
    /// </summary>
    [JsonPropertyName("AccessTokenURI")]
    public string AccessTokenURI { get; set; }

    /// <summary>
    /// Gets or Sets AuthStyle
    /// </summary>
    [JsonPropertyName("AuthStyle")]
    public int? AuthStyle { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizationURI
    /// </summary>
    [JsonPropertyName("AuthorizationURI")]
    public string AuthorizationURI { get; set; }

    /// <summary>
    /// Gets or Sets ClientID
    /// </summary>
    [JsonPropertyName("ClientID")]
    public string ClientID { get; set; }

    /// <summary>
    /// Gets or Sets ClientSecret
    /// </summary>
    [JsonPropertyName("ClientSecret")]
    public string ClientSecret { get; set; }

    /// <summary>
    /// Gets or Sets DefaultTeamID
    /// </summary>
    [JsonPropertyName("DefaultTeamID")]
    public int? DefaultTeamID { get; set; }

    /// <summary>
    /// Gets or Sets KubeSecretKey
    /// </summary>
    [JsonPropertyName("KubeSecretKey")]
    public List<int?> KubeSecretKey { get; set; }

    /// <summary>
    /// Gets or Sets LogoutURI
    /// </summary>
    [JsonPropertyName("LogoutURI")]
    public string LogoutURI { get; set; }

    /// <summary>
    /// Gets or Sets OAuthAutoCreateUsers
    /// </summary>
    [JsonPropertyName("OAuthAutoCreateUsers")]
    public bool? OAuthAutoCreateUsers { get; set; }

    /// <summary>
    /// Gets or Sets RedirectURI
    /// </summary>
    [JsonPropertyName("RedirectURI")]
    public string RedirectURI { get; set; }

    /// <summary>
    /// Gets or Sets ResourceURI
    /// </summary>
    [JsonPropertyName("ResourceURI")]
    public string ResourceURI { get; set; }

    /// <summary>
    /// Gets or Sets SSO
    /// </summary>
    [JsonPropertyName("SSO")]
    public bool? SSO { get; set; }

    /// <summary>
    /// Gets or Sets Scopes
    /// </summary>
    [JsonPropertyName("Scopes")]
    public string Scopes { get; set; }

    /// <summary>
    /// Gets or Sets UserIdentifier
    /// </summary>
    [JsonPropertyName("UserIdentifier")]
    public string UserIdentifier { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerOAuthSettings {\n");
        sb.Append("  AccessTokenURI: ").Append(AccessTokenURI).Append("\n");
        sb.Append("  AuthStyle: ").Append(AuthStyle).Append("\n");
        sb.Append("  AuthorizationURI: ").Append(AuthorizationURI).Append("\n");
        sb.Append("  ClientID: ").Append(ClientID).Append("\n");
        sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
        sb.Append("  DefaultTeamID: ").Append(DefaultTeamID).Append("\n");
        sb.Append("  KubeSecretKey: ").Append(KubeSecretKey).Append("\n");
        sb.Append("  LogoutURI: ").Append(LogoutURI).Append("\n");
        sb.Append("  OAuthAutoCreateUsers: ").Append(OAuthAutoCreateUsers).Append("\n");
        sb.Append("  RedirectURI: ").Append(RedirectURI).Append("\n");
        sb.Append("  ResourceURI: ").Append(ResourceURI).Append("\n");
        sb.Append("  SSO: ").Append(SSO).Append("\n");
        sb.Append("  Scopes: ").Append(Scopes).Append("\n");
        sb.Append("  UserIdentifier: ").Append(UserIdentifier).Append("\n");
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