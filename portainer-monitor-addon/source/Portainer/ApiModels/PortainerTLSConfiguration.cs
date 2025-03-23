#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerTLSConfiguration {
    /// <summary>
    /// Use TLS
    /// </summary>
    /// <value>Use TLS</value>
    [JsonPropertyName("TLS")]
    public bool? TLS { get; set; }

    /// <summary>
    /// Path to the TLS CA certificate file
    /// </summary>
    /// <value>Path to the TLS CA certificate file</value>
    [JsonPropertyName("TLSCACert")]
    public string TLSCACert { get; set; }

    /// <summary>
    /// Path to the TLS client certificate file
    /// </summary>
    /// <value>Path to the TLS client certificate file</value>
    [JsonPropertyName("TLSCert")]
    public string TLSCert { get; set; }

    /// <summary>
    /// Path to the TLS client key file
    /// </summary>
    /// <value>Path to the TLS client key file</value>
    [JsonPropertyName("TLSKey")]
    public string TLSKey { get; set; }

    /// <summary>
    /// Skip the verification of the server TLS certificate
    /// </summary>
    /// <value>Skip the verification of the server TLS certificate</value>
    [JsonPropertyName("TLSSkipVerify")]
    public bool? TLSSkipVerify { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerTLSConfiguration {\n");
        sb.Append("  TLS: ").Append(TLS).Append("\n");
        sb.Append("  TLSCACert: ").Append(TLSCACert).Append("\n");
        sb.Append("  TLSCert: ").Append(TLSCert).Append("\n");
        sb.Append("  TLSKey: ").Append(TLSKey).Append("\n");
        sb.Append("  TLSSkipVerify: ").Append(TLSSkipVerify).Append("\n");
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