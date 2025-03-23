#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1HTTPGetAction {
    /// <summary>
    /// Host name to connect to, defaults to the pod IP. You probably want to set \"Host\" in httpHeaders instead. +optional
    /// </summary>
    /// <value>Host name to connect to, defaults to the pod IP. You probably want to set \"Host\" in httpHeaders instead. +optional</value>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>
    /// Custom headers to set in the request. HTTP allows repeated headers. +optional
    /// </summary>
    /// <value>Custom headers to set in the request. HTTP allows repeated headers. +optional</value>
    [JsonPropertyName("httpHeaders")]
    public List<V1HTTPHeader> HttpHeaders { get; set; }

    /// <summary>
    /// Path to access on the HTTP server. +optional
    /// </summary>
    /// <value>Path to access on the HTTP server. +optional</value>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>
    /// Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
    /// </summary>
    /// <value>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</value>
    [JsonPropertyName("port")]
    public IntstrIntOrString Port { get; set; }

    /// <summary>
    /// Scheme to use for connecting to the host. Defaults to HTTP. +optional
    /// </summary>
    /// <value>Scheme to use for connecting to the host. Defaults to HTTP. +optional</value>
    [JsonPropertyName("scheme")]
    public string Scheme { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1HTTPGetAction {\n");
        sb.Append("  Host: ").Append(Host).Append("\n");
        sb.Append("  HttpHeaders: ").Append(HttpHeaders).Append("\n");
        sb.Append("  Path: ").Append(Path).Append("\n");
        sb.Append("  Port: ").Append(Port).Append("\n");
        sb.Append("  Scheme: ").Append(Scheme).Append("\n");
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