#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class IntstrIntOrString {
    /// <summary>
    /// Gets or Sets IntVal
    /// </summary>
    [JsonPropertyName("intVal")]
    public int? IntVal { get; set; }

    /// <summary>
    /// Gets or Sets StrVal
    /// </summary>
    [JsonPropertyName("strVal")]
    public string StrVal { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class IntstrIntOrString {\n");
        sb.Append("  IntVal: ").Append(IntVal).Append("\n");
        sb.Append("  StrVal: ").Append(StrVal).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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