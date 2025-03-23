#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class RegistriesRegistryConfigurePayload {
    /// <summary>
    /// Is authentication against this registry enabled
    /// </summary>
    /// <value>Is authentication against this registry enabled</value>
    [JsonPropertyName("authentication")]
    public bool? Authentication { get; set; }

    /// <summary>
    /// Password used to authenticate against this registry. required when Authentication is true
    /// </summary>
    /// <value>Password used to authenticate against this registry. required when Authentication is true</value>
    [JsonPropertyName("password")]
    public string Password { get; set; }

    /// <summary>
    /// ECR region
    /// </summary>
    /// <value>ECR region</value>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>
    /// Use TLS
    /// </summary>
    /// <value>Use TLS</value>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>
    /// The TLS CA certificate file
    /// </summary>
    /// <value>The TLS CA certificate file</value>
    [JsonPropertyName("tlscacertFile")]
    public List<int?> TlscacertFile { get; set; }

    /// <summary>
    /// The TLS client certificate file
    /// </summary>
    /// <value>The TLS client certificate file</value>
    [JsonPropertyName("tlscertFile")]
    public List<int?> TlscertFile { get; set; }

    /// <summary>
    /// The TLS client key file
    /// </summary>
    /// <value>The TLS client key file</value>
    [JsonPropertyName("tlskeyFile")]
    public List<int?> TlskeyFile { get; set; }

    /// <summary>
    /// Skip the verification of the server TLS certificate
    /// </summary>
    /// <value>Skip the verification of the server TLS certificate</value>
    [JsonPropertyName("tlsskipVerify")]
    public bool? TlsskipVerify { get; set; }

    /// <summary>
    /// Username used to authenticate against this registry. Required when Authentication is true
    /// </summary>
    /// <value>Username used to authenticate against this registry. Required when Authentication is true</value>
    [JsonPropertyName("username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class RegistriesRegistryConfigurePayload {\n");
        sb.Append("  Authentication: ").Append(Authentication).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
        sb.Append("  Tls: ").Append(Tls).Append("\n");
        sb.Append("  TlscacertFile: ").Append(TlscacertFile).Append("\n");
        sb.Append("  TlscertFile: ").Append(TlscertFile).Append("\n");
        sb.Append("  TlskeyFile: ").Append(TlskeyFile).Append("\n");
        sb.Append("  TlsskipVerify: ").Append(TlsskipVerify).Append("\n");
        sb.Append("  Username: ").Append(Username).Append("\n");
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