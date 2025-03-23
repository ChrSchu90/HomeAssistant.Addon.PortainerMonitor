#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1LifecycleHandler {
    /// <summary>
    /// Exec specifies the action to take. +optional
    /// </summary>
    /// <value>Exec specifies the action to take. +optional</value>
    [JsonPropertyName("exec")]
    public V1ExecAction Exec { get; set; }

    /// <summary>
    /// HTTPGet specifies the http request to perform. +optional
    /// </summary>
    /// <value>HTTPGet specifies the http request to perform. +optional</value>
    [JsonPropertyName("httpGet")]
    public V1HTTPGetAction HttpGet { get; set; }

    /// <summary>
    /// Sleep represents the duration that the container should sleep before being terminated. +featureGate=PodLifecycleSleepAction +optional
    /// </summary>
    /// <value>Sleep represents the duration that the container should sleep before being terminated. +featureGate=PodLifecycleSleepAction +optional</value>
    [JsonPropertyName("sleep")]
    public V1SleepAction Sleep { get; set; }

    /// <summary>
    /// Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified. +optional
    /// </summary>
    /// <value>Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified. +optional</value>
    [JsonPropertyName("tcpSocket")]
    public V1TCPSocketAction TcpSocket { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1LifecycleHandler {\n");
        sb.Append("  Exec: ").Append(Exec).Append("\n");
        sb.Append("  HttpGet: ").Append(HttpGet).Append("\n");
        sb.Append("  Sleep: ").Append(Sleep).Append("\n");
        sb.Append("  TcpSocket: ").Append(TcpSocket).Append("\n");
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