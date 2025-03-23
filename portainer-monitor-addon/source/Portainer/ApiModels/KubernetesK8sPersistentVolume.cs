#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sPersistentVolume {
    /// <summary>
    /// Gets or Sets AccessModes
    /// </summary>
    [JsonPropertyName("accessModes")]
    public List<string> AccessModes { get; set; }

    /// <summary>
    /// Gets or Sets Annotations
    /// </summary>
    [JsonPropertyName("annotations")]
    public Dictionary<string, string> Annotations { get; set; }

    /// <summary>
    /// Gets or Sets Capacity
    /// </summary>
    [JsonPropertyName("capacity")]
    public V1ResourceList Capacity { get; set; }

    /// <summary>
    /// Gets or Sets ClaimRef
    /// </summary>
    [JsonPropertyName("claimRef")]
    public V1ObjectReference ClaimRef { get; set; }

    /// <summary>
    /// Gets or Sets Csi
    /// </summary>
    [JsonPropertyName("csi")]
    public V1CSIPersistentVolumeSource Csi { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets PersistentVolumeReclaimPolicy
    /// </summary>
    [JsonPropertyName("persistentVolumeReclaimPolicy")]
    public string PersistentVolumeReclaimPolicy { get; set; }

    /// <summary>
    /// Gets or Sets StorageClassName
    /// </summary>
    [JsonPropertyName("storageClassName")]
    public string StorageClassName { get; set; }

    /// <summary>
    /// Gets or Sets VolumeMode
    /// </summary>
    [JsonPropertyName("volumeMode")]
    public string VolumeMode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sPersistentVolume {\n");
        sb.Append("  AccessModes: ").Append(AccessModes).Append("\n");
        sb.Append("  Annotations: ").Append(Annotations).Append("\n");
        sb.Append("  Capacity: ").Append(Capacity).Append("\n");
        sb.Append("  ClaimRef: ").Append(ClaimRef).Append("\n");
        sb.Append("  Csi: ").Append(Csi).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PersistentVolumeReclaimPolicy: ").Append(PersistentVolumeReclaimPolicy).Append("\n");
        sb.Append("  StorageClassName: ").Append(StorageClassName).Append("\n");
        sb.Append("  VolumeMode: ").Append(VolumeMode).Append("\n");
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