#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1GRPCAction {
    /// <summary>
    /// Port number of the gRPC service. Number must be in the range 1 to 65535.
    /// </summary>
    /// <value>Port number of the gRPC service. Number must be in the range 1 to 65535.</value>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>
    /// Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).  If this is not specified, the default behavior is defined by gRPC. +optional +default=\"\"
    /// </summary>
    /// <value>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).  If this is not specified, the default behavior is defined by gRPC. +optional +default=\"\"</value>
    [JsonPropertyName("service")]
    public string Service { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1GRPCAction {\n");
        sb.Append("  Port: ").Append(Port).Append("\n");
        sb.Append("  Service: ").Append(Service).Append("\n");
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