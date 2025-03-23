#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerSSLSettings {
    /// <summary>
    /// Gets or Sets CertPath
    /// </summary>
    [JsonPropertyName("certPath")]
    public string CertPath { get; set; }

    /// <summary>
    /// Gets or Sets HttpEnabled
    /// </summary>
    [JsonPropertyName("httpEnabled")]
    public bool? HttpEnabled { get; set; }

    /// <summary>
    /// Gets or Sets KeyPath
    /// </summary>
    [JsonPropertyName("keyPath")]
    public string KeyPath { get; set; }

    /// <summary>
    /// Gets or Sets SelfSigned
    /// </summary>
    [JsonPropertyName("selfSigned")]
    public bool? SelfSigned { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerSSLSettings {\n");
        sb.Append("  CertPath: ").Append(CertPath).Append("\n");
        sb.Append("  HttpEnabled: ").Append(HttpEnabled).Append("\n");
        sb.Append("  KeyPath: ").Append(KeyPath).Append("\n");
        sb.Append("  SelfSigned: ").Append(SelfSigned).Append("\n");
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