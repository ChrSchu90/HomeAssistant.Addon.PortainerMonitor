#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1CSIPersistentVolumeSource {
    /// <summary>
    /// controllerExpandSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI ControllerExpandVolume call. This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed. +optional
    /// </summary>
    /// <value>controllerExpandSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI ControllerExpandVolume call. This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed. +optional</value>
    [JsonPropertyName("controllerExpandSecretRef")]
    public V1SecretReference ControllerExpandSecretRef { get; set; }

    /// <summary>
    /// controllerPublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI ControllerPublishVolume and ControllerUnpublishVolume calls. This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed. +optional
    /// </summary>
    /// <value>controllerPublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI ControllerPublishVolume and ControllerUnpublishVolume calls. This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed. +optional</value>
    [JsonPropertyName("controllerPublishSecretRef")]
    public V1SecretReference ControllerPublishSecretRef { get; set; }

    /// <summary>
    /// driver is the name of the driver to use for this volume. Required.
    /// </summary>
    /// <value>driver is the name of the driver to use for this volume. Required.</value>
    [JsonPropertyName("driver")]
    public string Driver { get; set; }

    /// <summary>
    /// fsType to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". +optional
    /// </summary>
    /// <value>fsType to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". +optional</value>
    [JsonPropertyName("fsType")]
    public string FsType { get; set; }

    /// <summary>
    /// nodeExpandSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodeExpandVolume call. This field is optional, may be omitted if no secret is required. If the secret object contains more than one secret, all secrets are passed. +optional
    /// </summary>
    /// <value>nodeExpandSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodeExpandVolume call. This field is optional, may be omitted if no secret is required. If the secret object contains more than one secret, all secrets are passed. +optional</value>
    [JsonPropertyName("nodeExpandSecretRef")]
    public V1SecretReference NodeExpandSecretRef { get; set; }

    /// <summary>
    /// nodePublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume calls. This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed. +optional
    /// </summary>
    /// <value>nodePublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume calls. This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed. +optional</value>
    [JsonPropertyName("nodePublishSecretRef")]
    public V1SecretReference NodePublishSecretRef { get; set; }

    /// <summary>
    /// nodeStageSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodeStageVolume and NodeStageVolume and NodeUnstageVolume calls. This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed. +optional
    /// </summary>
    /// <value>nodeStageSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodeStageVolume and NodeStageVolume and NodeUnstageVolume calls. This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed. +optional</value>
    [JsonPropertyName("nodeStageSecretRef")]
    public V1SecretReference NodeStageSecretRef { get; set; }

    /// <summary>
    /// readOnly value to pass to ControllerPublishVolumeRequest. Defaults to false (read/write). +optional
    /// </summary>
    /// <value>readOnly value to pass to ControllerPublishVolumeRequest. Defaults to false (read/write). +optional</value>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// volumeAttributes of the volume to publish. +optional
    /// </summary>
    /// <value>volumeAttributes of the volume to publish. +optional</value>
    [JsonPropertyName("volumeAttributes")]
    public Dictionary<string, string> VolumeAttributes { get; set; }

    /// <summary>
    /// volumeHandle is the unique volume name returned by the CSI volume plugin’s CreateVolume to refer to the volume on all subsequent calls. Required.
    /// </summary>
    /// <value>volumeHandle is the unique volume name returned by the CSI volume plugin’s CreateVolume to refer to the volume on all subsequent calls. Required.</value>
    [JsonPropertyName("volumeHandle")]
    public string VolumeHandle { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1CSIPersistentVolumeSource {\n");
        sb.Append("  ControllerExpandSecretRef: ").Append(ControllerExpandSecretRef).Append("\n");
        sb.Append("  ControllerPublishSecretRef: ").Append(ControllerPublishSecretRef).Append("\n");
        sb.Append("  Driver: ").Append(Driver).Append("\n");
        sb.Append("  FsType: ").Append(FsType).Append("\n");
        sb.Append("  NodeExpandSecretRef: ").Append(NodeExpandSecretRef).Append("\n");
        sb.Append("  NodePublishSecretRef: ").Append(NodePublishSecretRef).Append("\n");
        sb.Append("  NodeStageSecretRef: ").Append(NodeStageSecretRef).Append("\n");
        sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
        sb.Append("  VolumeAttributes: ").Append(VolumeAttributes).Append("\n");
        sb.Append("  VolumeHandle: ").Append(VolumeHandle).Append("\n");
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