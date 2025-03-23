#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1SELinuxOptions {
    /// <summary>
    /// Level is SELinux level label that applies to the container. +optional
    /// </summary>
    /// <value>Level is SELinux level label that applies to the container. +optional</value>
    [JsonPropertyName("level")]
    public string Level { get; set; }

    /// <summary>
    /// Role is a SELinux role label that applies to the container. +optional
    /// </summary>
    /// <value>Role is a SELinux role label that applies to the container. +optional</value>
    [JsonPropertyName("role")]
    public string Role { get; set; }

    /// <summary>
    /// Type is a SELinux type label that applies to the container. +optional
    /// </summary>
    /// <value>Type is a SELinux type label that applies to the container. +optional</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// User is a SELinux user label that applies to the container. +optional
    /// </summary>
    /// <value>User is a SELinux user label that applies to the container. +optional</value>
    [JsonPropertyName("user")]
    public string User { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1SELinuxOptions {\n");
        sb.Append("  Level: ").Append(Level).Append("\n");
        sb.Append("  Role: ").Append(Role).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
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