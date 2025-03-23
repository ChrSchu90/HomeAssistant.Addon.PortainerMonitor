#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerTemplateVolume {
    /// <summary>
    /// Path on the host
    /// </summary>
    /// <value>Path on the host</value>
    [JsonPropertyName("bind")]
    public string Bind { get; set; }

    /// <summary>
    /// Path inside the container
    /// </summary>
    /// <value>Path inside the container</value>
    [JsonPropertyName("container")]
    public string Container { get; set; }

    /// <summary>
    /// Whether the volume used should be readonly
    /// </summary>
    /// <value>Whether the volume used should be readonly</value>
    [JsonPropertyName("readonly")]
    public bool? Readonly { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerTemplateVolume {\n");
        sb.Append("  Bind: ").Append(Bind).Append("\n");
        sb.Append("  Container: ").Append(Container).Append("\n");
        sb.Append("  Readonly: ").Append(Readonly).Append("\n");
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