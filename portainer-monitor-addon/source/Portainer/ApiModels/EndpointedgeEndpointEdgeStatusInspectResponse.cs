#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EndpointedgeEndpointEdgeStatusInspectResponse {
    /// <summary>
    /// The current value of CheckinInterval
    /// </summary>
    /// <value>The current value of CheckinInterval</value>
    [JsonPropertyName("checkin")]
    public int? Checkin { get; set; }

    /// <summary>
    /// Gets or Sets Credentials
    /// </summary>
    [JsonPropertyName("credentials")]
    public string Credentials { get; set; }

    /// <summary>
    /// The tunnel port
    /// </summary>
    /// <value>The tunnel port</value>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>
    /// List of requests for jobs to run on the environment(endpoint)
    /// </summary>
    /// <value>List of requests for jobs to run on the environment(endpoint)</value>
    [JsonPropertyName("schedules")]
    public List<EndpointedgeEdgeJobResponse> Schedules { get; set; }

    /// <summary>
    /// List of stacks to be deployed on the environments(endpoints)
    /// </summary>
    /// <value>List of stacks to be deployed on the environments(endpoints)</value>
    [JsonPropertyName("stacks")]
    public List<EndpointedgeStackStatusResponse> Stacks { get; set; }

    /// <summary>
    /// Status represents the environment(endpoint) status
    /// </summary>
    /// <value>Status represents the environment(endpoint) status</value>
    [JsonPropertyName("status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class EndpointedgeEndpointEdgeStatusInspectResponse {\n");
        sb.Append("  Checkin: ").Append(Checkin).Append("\n");
        sb.Append("  Credentials: ").Append(Credentials).Append("\n");
        sb.Append("  Port: ").Append(Port).Append("\n");
        sb.Append("  Schedules: ").Append(Schedules).Append("\n");
        sb.Append("  Stacks: ").Append(Stacks).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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