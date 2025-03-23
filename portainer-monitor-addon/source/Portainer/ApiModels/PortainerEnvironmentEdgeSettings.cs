#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerEnvironmentEdgeSettings {
    /// <summary>
    /// The command list interval for edge agent - used in edge async mode [seconds]
    /// </summary>
    /// <value>The command list interval for edge agent - used in edge async mode [seconds]</value>
    [JsonPropertyName("CommandInterval")]
    public int? CommandInterval { get; set; }

    /// <summary>
    /// The ping interval for edge agent - used in edge async mode [seconds]
    /// </summary>
    /// <value>The ping interval for edge agent - used in edge async mode [seconds]</value>
    [JsonPropertyName("PingInterval")]
    public int? PingInterval { get; set; }

    /// <summary>
    /// The snapshot interval for edge agent - used in edge async mode [seconds]
    /// </summary>
    /// <value>The snapshot interval for edge agent - used in edge async mode [seconds]</value>
    [JsonPropertyName("SnapshotInterval")]
    public int? SnapshotInterval { get; set; }

    /// <summary>
    /// Whether the device has been started in edge async mode
    /// </summary>
    /// <value>Whether the device has been started in edge async mode</value>
    [JsonPropertyName("asyncMode")]
    public bool? AsyncMode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerEnvironmentEdgeSettings {\n");
        sb.Append("  CommandInterval: ").Append(CommandInterval).Append("\n");
        sb.Append("  PingInterval: ").Append(PingInterval).Append("\n");
        sb.Append("  SnapshotInterval: ").Append(SnapshotInterval).Append("\n");
        sb.Append("  AsyncMode: ").Append(AsyncMode).Append("\n");
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