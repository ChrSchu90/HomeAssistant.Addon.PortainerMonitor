#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class SystemStatus {
    /// <summary>
    /// Portainer API version
    /// </summary>
    /// <value>Portainer API version</value>
    [JsonPropertyName("Version")]
    public string Version { get; set; }

    /// <summary>
    /// Server Instance ID
    /// </summary>
    /// <value>Server Instance ID</value>
    [JsonPropertyName("instanceID")]
    public string InstanceID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class SystemStatus {\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  InstanceID: ").Append(InstanceID).Append("\n");
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