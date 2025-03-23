#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1VolumeDevice {
    /// <summary>
    /// devicePath is the path inside of the container that the device will be mapped to.
    /// </summary>
    /// <value>devicePath is the path inside of the container that the device will be mapped to.</value>
    [JsonPropertyName("devicePath")]
    public string DevicePath { get; set; }

    /// <summary>
    /// name must match the name of a persistentVolumeClaim in the pod
    /// </summary>
    /// <value>name must match the name of a persistentVolumeClaim in the pod</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1VolumeDevice {\n");
        sb.Append("  DevicePath: ").Append(DevicePath).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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