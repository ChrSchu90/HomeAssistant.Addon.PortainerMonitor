#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1Probe {
    /// <summary>
    /// Exec specifies the action to take. +optional
    /// </summary>
    /// <value>Exec specifies the action to take. +optional</value>
    [JsonPropertyName("exec")]
    public V1ExecAction Exec { get; set; }

    /// <summary>
    /// Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1. +optional
    /// </summary>
    /// <value>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1. +optional</value>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>
    /// GRPC specifies an action involving a GRPC port. +optional
    /// </summary>
    /// <value>GRPC specifies an action involving a GRPC port. +optional</value>
    [JsonPropertyName("grpc")]
    public V1GRPCAction Grpc { get; set; }

    /// <summary>
    /// HTTPGet specifies the http request to perform. +optional
    /// </summary>
    /// <value>HTTPGet specifies the http request to perform. +optional</value>
    [JsonPropertyName("httpGet")]
    public V1HTTPGetAction HttpGet { get; set; }

    /// <summary>
    /// Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes +optional
    /// </summary>
    /// <value>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes +optional</value>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>
    /// How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. +optional
    /// </summary>
    /// <value>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. +optional</value>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>
    /// Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1. +optional
    /// </summary>
    /// <value>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1. +optional</value>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>
    /// TCPSocket specifies an action involving a TCP port. +optional
    /// </summary>
    /// <value>TCPSocket specifies an action involving a TCP port. +optional</value>
    [JsonPropertyName("tcpSocket")]
    public V1TCPSocketAction TcpSocket { get; set; }

    /// <summary>
    /// Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset. +optional
    /// </summary>
    /// <value>Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset. +optional</value>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>
    /// Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes +optional
    /// </summary>
    /// <value>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes +optional</value>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1Probe {\n");
        sb.Append("  Exec: ").Append(Exec).Append("\n");
        sb.Append("  FailureThreshold: ").Append(FailureThreshold).Append("\n");
        sb.Append("  Grpc: ").Append(Grpc).Append("\n");
        sb.Append("  HttpGet: ").Append(HttpGet).Append("\n");
        sb.Append("  InitialDelaySeconds: ").Append(InitialDelaySeconds).Append("\n");
        sb.Append("  PeriodSeconds: ").Append(PeriodSeconds).Append("\n");
        sb.Append("  SuccessThreshold: ").Append(SuccessThreshold).Append("\n");
        sb.Append("  TcpSocket: ").Append(TcpSocket).Append("\n");
        sb.Append("  TerminationGracePeriodSeconds: ").Append(TerminationGracePeriodSeconds).Append("\n");
        sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
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