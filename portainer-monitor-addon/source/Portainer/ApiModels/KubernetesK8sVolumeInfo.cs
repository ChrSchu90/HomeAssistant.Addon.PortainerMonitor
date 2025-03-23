#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sVolumeInfo {
    /// <summary>
    /// Gets or Sets PersistentVolume
    /// </summary>
    [JsonPropertyName("persistentVolume")]
    public KubernetesK8sPersistentVolume PersistentVolume { get; set; }

    /// <summary>
    /// Gets or Sets PersistentVolumeClaim
    /// </summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public KubernetesK8sPersistentVolumeClaim PersistentVolumeClaim { get; set; }

    /// <summary>
    /// Gets or Sets StorageClass
    /// </summary>
    [JsonPropertyName("storageClass")]
    public KubernetesK8sStorageClass StorageClass { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sVolumeInfo {\n");
        sb.Append("  PersistentVolume: ").Append(PersistentVolume).Append("\n");
        sb.Append("  PersistentVolumeClaim: ").Append(PersistentVolumeClaim).Append("\n");
        sb.Append("  StorageClass: ").Append(StorageClass).Append("\n");
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