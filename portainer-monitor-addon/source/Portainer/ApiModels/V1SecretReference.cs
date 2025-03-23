#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1SecretReference {
    /// <summary>
    /// name is unique within a namespace to reference a secret resource. +optional
    /// </summary>
    /// <value>name is unique within a namespace to reference a secret resource. +optional</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// namespace defines the space within which the secret name must be unique. +optional
    /// </summary>
    /// <value>namespace defines the space within which the secret name must be unique. +optional</value>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1SecretReference {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
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