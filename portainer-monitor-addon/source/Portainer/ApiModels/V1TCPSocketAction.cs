#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1TCPSocketAction {
    /// <summary>
    /// Optional: Host name to connect to, defaults to the pod IP. +optional
    /// </summary>
    /// <value>Optional: Host name to connect to, defaults to the pod IP. +optional</value>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>
    /// Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
    /// </summary>
    /// <value>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</value>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1TCPSocketAction {\n");
        sb.Append("  Host: ").Append(Host).Append("\n");
        sb.Append("  Port: ").Append(Port).Append("\n");
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