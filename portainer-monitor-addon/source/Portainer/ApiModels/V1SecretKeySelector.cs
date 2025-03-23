#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1SecretKeySelector {
    /// <summary>
    /// The key of the secret to select from.  Must be a valid secret key.
    /// </summary>
    /// <value>The key of the secret to select from.  Must be a valid secret key.</value>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>
    /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid? +optional
    /// </summary>
    /// <value>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid? +optional</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Specify whether the Secret or its key must be defined +optional
    /// </summary>
    /// <value>Specify whether the Secret or its key must be defined +optional</value>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1SecretKeySelector {\n");
        sb.Append("  Key: ").Append(Key).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Optional: ").Append(Optional).Append("\n");
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