#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1EnvVar {
    /// <summary>
    /// Name of the environment variable. Must be a C_IDENTIFIER.
    /// </summary>
    /// <value>Name of the environment variable. Must be a C_IDENTIFIER.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Variable references $(VAR_NAME) are expanded using the previously defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \"$$(VAR_NAME)\" will produce the string literal \"$(VAR_NAME)\". Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to \"\". +optional
    /// </summary>
    /// <value>Variable references $(VAR_NAME) are expanded using the previously defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \"$$(VAR_NAME)\" will produce the string literal \"$(VAR_NAME)\". Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to \"\". +optional</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }

    /// <summary>
    /// Source for the environment variable's value. Cannot be used if value is not empty. +optional
    /// </summary>
    /// <value>Source for the environment variable's value. Cannot be used if value is not empty. +optional</value>
    [JsonPropertyName("valueFrom")]
    public V1EnvVarSource ValueFrom { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1EnvVar {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  ValueFrom: ").Append(ValueFrom).Append("\n");
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