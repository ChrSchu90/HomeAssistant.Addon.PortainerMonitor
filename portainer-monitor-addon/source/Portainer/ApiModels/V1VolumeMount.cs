#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1VolumeMount {
    /// <summary>
    /// Path within the container at which the volume should be mounted.  Must not contain ':'.
    /// </summary>
    /// <value>Path within the container at which the volume should be mounted.  Must not contain ':'.</value>
    [JsonPropertyName("mountPath")]
    public string MountPath { get; set; }

    /// <summary>
    /// mountPropagation determines how mounts are propagated from the host to container and the other way around. When not set, MountPropagationNone is used. This field is beta in 1.10. +optional
    /// </summary>
    /// <value>mountPropagation determines how mounts are propagated from the host to container and the other way around. When not set, MountPropagationNone is used. This field is beta in 1.10. +optional</value>
    [JsonPropertyName("mountPropagation")]
    public string MountPropagation { get; set; }

    /// <summary>
    /// This must match the Name of a Volume.
    /// </summary>
    /// <value>This must match the Name of a Volume.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false. +optional
    /// </summary>
    /// <value>Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false. +optional</value>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// Path within the volume from which the container's volume should be mounted. Defaults to \"\" (volume's root). +optional
    /// </summary>
    /// <value>Path within the volume from which the container's volume should be mounted. Defaults to \"\" (volume's root). +optional</value>
    [JsonPropertyName("subPath")]
    public string SubPath { get; set; }

    /// <summary>
    /// Expanded path within the volume from which the container's volume should be mounted. Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to \"\" (volume's root). SubPathExpr and SubPath are mutually exclusive. +optional
    /// </summary>
    /// <value>Expanded path within the volume from which the container's volume should be mounted. Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to \"\" (volume's root). SubPathExpr and SubPath are mutually exclusive. +optional</value>
    [JsonPropertyName("subPathExpr")]
    public string SubPathExpr { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1VolumeMount {\n");
        sb.Append("  MountPath: ").Append(MountPath).Append("\n");
        sb.Append("  MountPropagation: ").Append(MountPropagation).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
        sb.Append("  SubPath: ").Append(SubPath).Append("\n");
        sb.Append("  SubPathExpr: ").Append(SubPathExpr).Append("\n");
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