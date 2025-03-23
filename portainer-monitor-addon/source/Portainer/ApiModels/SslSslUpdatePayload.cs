#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class SslSslUpdatePayload {
    /// <summary>
    /// SSL Certificates
    /// </summary>
    /// <value>SSL Certificates</value>
    [JsonPropertyName("cert")]
    public string Cert { get; set; }

    /// <summary>
    /// Gets or Sets Httpenabled
    /// </summary>
    [JsonPropertyName("httpenabled")]
    public bool? Httpenabled { get; set; }

    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class SslSslUpdatePayload {\n");
        sb.Append("  Cert: ").Append(Cert).Append("\n");
        sb.Append("  Httpenabled: ").Append(Httpenabled).Append("\n");
        sb.Append("  Key: ").Append(Key).Append("\n");
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