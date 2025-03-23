#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerDockerSnapshot {
    /// <summary>
    /// Gets or Sets ContainerCount
    /// </summary>
    [JsonPropertyName("ContainerCount")]
    public int? ContainerCount { get; set; }

    /// <summary>
    /// Gets or Sets DiagnosticsData
    /// </summary>
    [JsonPropertyName("DiagnosticsData")]
    public PortainerDiagnosticsData DiagnosticsData { get; set; }

    /// <summary>
    /// Gets or Sets DockerSnapshotRaw
    /// </summary>
    [JsonPropertyName("DockerSnapshotRaw")]
    public PortainerDockerSnapshotRaw DockerSnapshotRaw { get; set; }

    /// <summary>
    /// Gets or Sets DockerVersion
    /// </summary>
    [JsonPropertyName("DockerVersion")]
    public string DockerVersion { get; set; }

    /// <summary>
    /// Gets or Sets GpuUseAll
    /// </summary>
    [JsonPropertyName("GpuUseAll")]
    public bool? GpuUseAll { get; set; }

    /// <summary>
    /// Gets or Sets GpuUseList
    /// </summary>
    [JsonPropertyName("GpuUseList")]
    public List<string> GpuUseList { get; set; }

    /// <summary>
    /// Gets or Sets HealthyContainerCount
    /// </summary>
    [JsonPropertyName("HealthyContainerCount")]
    public int? HealthyContainerCount { get; set; }

    /// <summary>
    /// Gets or Sets ImageCount
    /// </summary>
    [JsonPropertyName("ImageCount")]
    public int? ImageCount { get; set; }

    /// <summary>
    /// Gets or Sets IsPodman
    /// </summary>
    [JsonPropertyName("IsPodman")]
    public bool? IsPodman { get; set; }

    /// <summary>
    /// Gets or Sets NodeCount
    /// </summary>
    [JsonPropertyName("NodeCount")]
    public int? NodeCount { get; set; }

    /// <summary>
    /// Gets or Sets RunningContainerCount
    /// </summary>
    [JsonPropertyName("RunningContainerCount")]
    public int? RunningContainerCount { get; set; }

    /// <summary>
    /// Gets or Sets ServiceCount
    /// </summary>
    [JsonPropertyName("ServiceCount")]
    public int? ServiceCount { get; set; }

    /// <summary>
    /// Gets or Sets StackCount
    /// </summary>
    [JsonPropertyName("StackCount")]
    public int? StackCount { get; set; }

    /// <summary>
    /// Gets or Sets StoppedContainerCount
    /// </summary>
    [JsonPropertyName("StoppedContainerCount")]
    public int? StoppedContainerCount { get; set; }

    /// <summary>
    /// Gets or Sets Swarm
    /// </summary>
    [JsonPropertyName("Swarm")]
    public bool? Swarm { get; set; }

    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [JsonPropertyName("Time")]
    public int? Time { get; set; }

    /// <summary>
    /// Gets or Sets TotalCPU
    /// </summary>
    [JsonPropertyName("TotalCPU")]
    public int? TotalCPU { get; set; }

    /// <summary>
    /// Gets or Sets TotalMemory
    /// </summary>
    [JsonPropertyName("TotalMemory")]
    public int? TotalMemory { get; set; }

    /// <summary>
    /// Gets or Sets UnhealthyContainerCount
    /// </summary>
    [JsonPropertyName("UnhealthyContainerCount")]
    public int? UnhealthyContainerCount { get; set; }

    /// <summary>
    /// Gets or Sets VolumeCount
    /// </summary>
    [JsonPropertyName("VolumeCount")]
    public int? VolumeCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerDockerSnapshot {\n");
        sb.Append("  ContainerCount: ").Append(ContainerCount).Append("\n");
        sb.Append("  DiagnosticsData: ").Append(DiagnosticsData).Append("\n");
        sb.Append("  DockerSnapshotRaw: ").Append(DockerSnapshotRaw).Append("\n");
        sb.Append("  DockerVersion: ").Append(DockerVersion).Append("\n");
        sb.Append("  GpuUseAll: ").Append(GpuUseAll).Append("\n");
        sb.Append("  GpuUseList: ").Append(GpuUseList).Append("\n");
        sb.Append("  HealthyContainerCount: ").Append(HealthyContainerCount).Append("\n");
        sb.Append("  ImageCount: ").Append(ImageCount).Append("\n");
        sb.Append("  IsPodman: ").Append(IsPodman).Append("\n");
        sb.Append("  NodeCount: ").Append(NodeCount).Append("\n");
        sb.Append("  RunningContainerCount: ").Append(RunningContainerCount).Append("\n");
        sb.Append("  ServiceCount: ").Append(ServiceCount).Append("\n");
        sb.Append("  StackCount: ").Append(StackCount).Append("\n");
        sb.Append("  StoppedContainerCount: ").Append(StoppedContainerCount).Append("\n");
        sb.Append("  Swarm: ").Append(Swarm).Append("\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
        sb.Append("  TotalCPU: ").Append(TotalCPU).Append("\n");
        sb.Append("  TotalMemory: ").Append(TotalMemory).Append("\n");
        sb.Append("  UnhealthyContainerCount: ").Append(UnhealthyContainerCount).Append("\n");
        sb.Append("  VolumeCount: ").Append(VolumeCount).Append("\n");
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