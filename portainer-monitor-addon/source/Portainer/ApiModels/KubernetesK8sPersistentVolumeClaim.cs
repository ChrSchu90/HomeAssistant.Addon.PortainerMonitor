#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sPersistentVolumeClaim {
    /// <summary>
    /// Gets or Sets AccessModes
    /// </summary>
    [JsonPropertyName("accessModes")]
    public List<string> AccessModes { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [JsonPropertyName("creationDate")]
    public string CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Labels
    /// </summary>
    [JsonPropertyName("labels")]
    public Dictionary<string, string> Labels { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Gets or Sets OwningApplications
    /// </summary>
    [JsonPropertyName("owningApplications")]
    public List<KubernetesK8sApplication> OwningApplications { get; set; }

    /// <summary>
    /// Gets or Sets Phase
    /// </summary>
    [JsonPropertyName("phase")]
    public string Phase { get; set; }

    /// <summary>
    /// Gets or Sets ResourcesRequests
    /// </summary>
    [JsonPropertyName("resourcesRequests")]
    public V1ResourceList ResourcesRequests { get; set; }

    /// <summary>
    /// Gets or Sets Storage
    /// </summary>
    [JsonPropertyName("storage")]
    public int? Storage { get; set; }

    /// <summary>
    /// Gets or Sets StorageClass
    /// </summary>
    [JsonPropertyName("storageClass")]
    public string StorageClass { get; set; }

    /// <summary>
    /// Gets or Sets VolumeMode
    /// </summary>
    [JsonPropertyName("volumeMode")]
    public string VolumeMode { get; set; }

    /// <summary>
    /// Gets or Sets VolumeName
    /// </summary>
    [JsonPropertyName("volumeName")]
    public string VolumeName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sPersistentVolumeClaim {\n");
        sb.Append("  AccessModes: ").Append(AccessModes).Append("\n");
        sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Labels: ").Append(Labels).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  OwningApplications: ").Append(OwningApplications).Append("\n");
        sb.Append("  Phase: ").Append(Phase).Append("\n");
        sb.Append("  ResourcesRequests: ").Append(ResourcesRequests).Append("\n");
        sb.Append("  Storage: ").Append(Storage).Append("\n");
        sb.Append("  StorageClass: ").Append(StorageClass).Append("\n");
        sb.Append("  VolumeMode: ").Append(VolumeMode).Append("\n");
        sb.Append("  VolumeName: ").Append(VolumeName).Append("\n");
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