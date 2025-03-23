#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sCronJob {
    /// <summary>
    /// Gets or Sets Command
    /// </summary>
    [JsonPropertyName("Command")]
    public string Command { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("Id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets IsSystem
    /// </summary>
    [JsonPropertyName("IsSystem")]
    public bool? IsSystem { get; set; }

    /// <summary>
    /// Gets or Sets Jobs
    /// </summary>
    [JsonPropertyName("Jobs")]
    public List<KubernetesK8sJob> Jobs { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    [JsonPropertyName("Namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Gets or Sets Schedule
    /// </summary>
    [JsonPropertyName("Schedule")]
    public string Schedule { get; set; }

    /// <summary>
    /// Gets or Sets Suspend
    /// </summary>
    [JsonPropertyName("Suspend")]
    public bool? Suspend { get; set; }

    /// <summary>
    /// Gets or Sets Timezone
    /// </summary>
    [JsonPropertyName("Timezone")]
    public string Timezone { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sCronJob {\n");
        sb.Append("  Command: ").Append(Command).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
        sb.Append("  Jobs: ").Append(Jobs).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  Schedule: ").Append(Schedule).Append("\n");
        sb.Append("  Suspend: ").Append(Suspend).Append("\n");
        sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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