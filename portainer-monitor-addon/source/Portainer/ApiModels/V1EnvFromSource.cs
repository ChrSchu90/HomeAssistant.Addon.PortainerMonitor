#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1EnvFromSource {
    /// <summary>
    /// The ConfigMap to select from +optional
    /// </summary>
    /// <value>The ConfigMap to select from +optional</value>
    [JsonPropertyName("configMapRef")]
    public V1ConfigMapEnvSource ConfigMapRef { get; set; }

    /// <summary>
    /// An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER. +optional
    /// </summary>
    /// <value>An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER. +optional</value>
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; }

    /// <summary>
    /// The Secret to select from +optional
    /// </summary>
    /// <value>The Secret to select from +optional</value>
    [JsonPropertyName("secretRef")]
    public V1SecretEnvSource SecretRef { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1EnvFromSource {\n");
        sb.Append("  ConfigMapRef: ").Append(ConfigMapRef).Append("\n");
        sb.Append("  Prefix: ").Append(Prefix).Append("\n");
        sb.Append("  SecretRef: ").Append(SecretRef).Append("\n");
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