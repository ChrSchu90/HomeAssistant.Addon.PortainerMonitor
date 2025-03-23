#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerDiagnosticsData {
    /// <summary>
    /// Gets or Sets DNS
    /// </summary>
    [JsonPropertyName("DNS")]
    public Dictionary<string, string> DNS { get; set; }

    /// <summary>
    /// Gets or Sets Log
    /// </summary>
    [JsonPropertyName("Log")]
    public string Log { get; set; }

    /// <summary>
    /// Gets or Sets Proxy
    /// </summary>
    [JsonPropertyName("Proxy")]
    public Dictionary<string, string> Proxy { get; set; }

    /// <summary>
    /// Gets or Sets Telnet
    /// </summary>
    [JsonPropertyName("Telnet")]
    public Dictionary<string, string> Telnet { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerDiagnosticsData {\n");
        sb.Append("  DNS: ").Append(DNS).Append("\n");
        sb.Append("  Log: ").Append(Log).Append("\n");
        sb.Append("  Proxy: ").Append(Proxy).Append("\n");
        sb.Append("  Telnet: ").Append(Telnet).Append("\n");
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