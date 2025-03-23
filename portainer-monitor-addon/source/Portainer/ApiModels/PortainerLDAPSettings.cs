#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerLDAPSettings {
    /// <summary>
    /// Enable this option if the server is configured for Anonymous access. When enabled, ReaderDN and Password will not be used
    /// </summary>
    /// <value>Enable this option if the server is configured for Anonymous access. When enabled, ReaderDN and Password will not be used</value>
    [JsonPropertyName("AnonymousMode")]
    public bool? AnonymousMode { get; set; }

    /// <summary>
    /// Automatically provision users and assign them to matching LDAP group names
    /// </summary>
    /// <value>Automatically provision users and assign them to matching LDAP group names</value>
    [JsonPropertyName("AutoCreateUsers")]
    public bool? AutoCreateUsers { get; set; }

    /// <summary>
    /// Gets or Sets GroupSearchSettings
    /// </summary>
    [JsonPropertyName("GroupSearchSettings")]
    public List<PortainerLDAPGroupSearchSettings> GroupSearchSettings { get; set; }

    /// <summary>
    /// Password of the account that will be used to search users
    /// </summary>
    /// <value>Password of the account that will be used to search users</value>
    [JsonPropertyName("Password")]
    public string Password { get; set; }

    /// <summary>
    /// Account that will be used to search for users
    /// </summary>
    /// <value>Account that will be used to search for users</value>
    [JsonPropertyName("ReaderDN")]
    public string ReaderDN { get; set; }

    /// <summary>
    /// Gets or Sets SearchSettings
    /// </summary>
    [JsonPropertyName("SearchSettings")]
    public List<PortainerLDAPSearchSettings> SearchSettings { get; set; }

    /// <summary>
    /// Whether LDAP connection should use StartTLS
    /// </summary>
    /// <value>Whether LDAP connection should use StartTLS</value>
    [JsonPropertyName("StartTLS")]
    public bool? StartTLS { get; set; }

    /// <summary>
    /// Gets or Sets TLSConfig
    /// </summary>
    [JsonPropertyName("TLSConfig")]
    public PortainerTLSConfiguration TLSConfig { get; set; }

    /// <summary>
    /// URL or IP address of the LDAP server
    /// </summary>
    /// <value>URL or IP address of the LDAP server</value>
    [JsonPropertyName("URL")]
    public string URL { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerLDAPSettings {\n");
        sb.Append("  AnonymousMode: ").Append(AnonymousMode).Append("\n");
        sb.Append("  AutoCreateUsers: ").Append(AutoCreateUsers).Append("\n");
        sb.Append("  GroupSearchSettings: ").Append(GroupSearchSettings).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  ReaderDN: ").Append(ReaderDN).Append("\n");
        sb.Append("  SearchSettings: ").Append(SearchSettings).Append("\n");
        sb.Append("  StartTLS: ").Append(StartTLS).Append("\n");
        sb.Append("  TLSConfig: ").Append(TLSConfig).Append("\n");
        sb.Append("  URL: ").Append(URL).Append("\n");
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