#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1Capabilities {
    /// <summary>
    /// Added capabilities +optional
    /// </summary>
    /// <value>Added capabilities +optional</value>
    [JsonPropertyName("add")]
    public List<string> Add { get; set; }

    /// <summary>
    /// Removed capabilities +optional
    /// </summary>
    /// <value>Removed capabilities +optional</value>
    [JsonPropertyName("drop")]
    public List<string> Drop { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1Capabilities {\n");
        sb.Append("  Add: ").Append(Add).Append("\n");
        sb.Append("  Drop: ").Append(Drop).Append("\n");
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