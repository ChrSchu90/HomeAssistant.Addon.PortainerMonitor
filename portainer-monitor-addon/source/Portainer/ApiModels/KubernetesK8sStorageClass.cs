#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sStorageClass {
    /// <summary>
    /// Gets or Sets AllowVolumeExpansion
    /// </summary>
    [JsonPropertyName("allowVolumeExpansion")]
    public bool? AllowVolumeExpansion { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Provisioner
    /// </summary>
    [JsonPropertyName("provisioner")]
    public string Provisioner { get; set; }

    /// <summary>
    /// Gets or Sets ReclaimPolicy
    /// </summary>
    [JsonPropertyName("reclaimPolicy")]
    public string ReclaimPolicy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sStorageClass {\n");
        sb.Append("  AllowVolumeExpansion: ").Append(AllowVolumeExpansion).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Provisioner: ").Append(Provisioner).Append("\n");
        sb.Append("  ReclaimPolicy: ").Append(ReclaimPolicy).Append("\n");
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