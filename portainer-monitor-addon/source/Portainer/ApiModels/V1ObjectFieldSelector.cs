#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1ObjectFieldSelector {
    /// <summary>
    /// Version of the schema the FieldPath is written in terms of, defaults to \"v1\". +optional
    /// </summary>
    /// <value>Version of the schema the FieldPath is written in terms of, defaults to \"v1\". +optional</value>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>
    /// Path of the field to select in the specified API version.
    /// </summary>
    /// <value>Path of the field to select in the specified API version.</value>
    [JsonPropertyName("fieldPath")]
    public string FieldPath { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1ObjectFieldSelector {\n");
        sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
        sb.Append("  FieldPath: ").Append(FieldPath).Append("\n");
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