#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerKubernetesSnapshot {
    /// <summary>
    /// Gets or Sets DiagnosticsData
    /// </summary>
    [JsonPropertyName("DiagnosticsData")]
    public PortainerDiagnosticsData DiagnosticsData { get; set; }

    /// <summary>
    /// Gets or Sets KubernetesVersion
    /// </summary>
    [JsonPropertyName("KubernetesVersion")]
    public string KubernetesVersion { get; set; }

    /// <summary>
    /// Gets or Sets NodeCount
    /// </summary>
    [JsonPropertyName("NodeCount")]
    public int? NodeCount { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerKubernetesSnapshot {\n");
        sb.Append("  DiagnosticsData: ").Append(DiagnosticsData).Append("\n");
        sb.Append("  KubernetesVersion: ").Append(KubernetesVersion).Append("\n");
        sb.Append("  NodeCount: ").Append(NodeCount).Append("\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
        sb.Append("  TotalCPU: ").Append(TotalCPU).Append("\n");
        sb.Append("  TotalMemory: ").Append(TotalMemory).Append("\n");
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