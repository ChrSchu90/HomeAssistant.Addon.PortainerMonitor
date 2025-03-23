#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EndpointsEndpointSettingsUpdatePayload {
    /// <summary>
    /// Whether non-administrator should be able to use bind mounts when creating containers
    /// </summary>
    /// <value>Whether non-administrator should be able to use bind mounts when creating containers</value>
    [JsonPropertyName("allowBindMountsForRegularUsers")]
    public bool? AllowBindMountsForRegularUsers { get; set; }

    /// <summary>
    /// Whether non-administrator should be able to use container capabilities
    /// </summary>
    /// <value>Whether non-administrator should be able to use container capabilities</value>
    [JsonPropertyName("allowContainerCapabilitiesForRegularUsers")]
    public bool? AllowContainerCapabilitiesForRegularUsers { get; set; }

    /// <summary>
    /// Whether non-administrator should be able to use device mapping
    /// </summary>
    /// <value>Whether non-administrator should be able to use device mapping</value>
    [JsonPropertyName("allowDeviceMappingForRegularUsers")]
    public bool? AllowDeviceMappingForRegularUsers { get; set; }

    /// <summary>
    /// Whether non-administrator should be able to use the host pid
    /// </summary>
    /// <value>Whether non-administrator should be able to use the host pid</value>
    [JsonPropertyName("allowHostNamespaceForRegularUsers")]
    public bool? AllowHostNamespaceForRegularUsers { get; set; }

    /// <summary>
    /// Whether non-administrator should be able to use privileged mode when creating containers
    /// </summary>
    /// <value>Whether non-administrator should be able to use privileged mode when creating containers</value>
    [JsonPropertyName("allowPrivilegedModeForRegularUsers")]
    public bool? AllowPrivilegedModeForRegularUsers { get; set; }

    /// <summary>
    /// Whether non-administrator should be able to manage stacks
    /// </summary>
    /// <value>Whether non-administrator should be able to manage stacks</value>
    [JsonPropertyName("allowStackManagementForRegularUsers")]
    public bool? AllowStackManagementForRegularUsers { get; set; }

    /// <summary>
    /// Whether non-administrator should be able to use sysctl settings
    /// </summary>
    /// <value>Whether non-administrator should be able to use sysctl settings</value>
    [JsonPropertyName("allowSysctlSettingForRegularUsers")]
    public bool? AllowSysctlSettingForRegularUsers { get; set; }

    /// <summary>
    /// Whether non-administrator should be able to browse volumes
    /// </summary>
    /// <value>Whether non-administrator should be able to browse volumes</value>
    [JsonPropertyName("allowVolumeBrowserForRegularUsers")]
    public bool? AllowVolumeBrowserForRegularUsers { get; set; }

    /// <summary>
    /// Gets or Sets EnableGPUManagement
    /// </summary>
    [JsonPropertyName("enableGPUManagement")]
    public bool? EnableGPUManagement { get; set; }

    /// <summary>
    /// Whether host management features are enabled
    /// </summary>
    /// <value>Whether host management features are enabled</value>
    [JsonPropertyName("enableHostManagementFeatures")]
    public bool? EnableHostManagementFeatures { get; set; }

    /// <summary>
    /// Gets or Sets Gpus
    /// </summary>
    [JsonPropertyName("gpus")]
    public List<PortainerPair> Gpus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class EndpointsEndpointSettingsUpdatePayload {\n");
        sb.Append("  AllowBindMountsForRegularUsers: ").Append(AllowBindMountsForRegularUsers).Append("\n");
        sb.Append("  AllowContainerCapabilitiesForRegularUsers: ").Append(AllowContainerCapabilitiesForRegularUsers).Append("\n");
        sb.Append("  AllowDeviceMappingForRegularUsers: ").Append(AllowDeviceMappingForRegularUsers).Append("\n");
        sb.Append("  AllowHostNamespaceForRegularUsers: ").Append(AllowHostNamespaceForRegularUsers).Append("\n");
        sb.Append("  AllowPrivilegedModeForRegularUsers: ").Append(AllowPrivilegedModeForRegularUsers).Append("\n");
        sb.Append("  AllowStackManagementForRegularUsers: ").Append(AllowStackManagementForRegularUsers).Append("\n");
        sb.Append("  AllowSysctlSettingForRegularUsers: ").Append(AllowSysctlSettingForRegularUsers).Append("\n");
        sb.Append("  AllowVolumeBrowserForRegularUsers: ").Append(AllowVolumeBrowserForRegularUsers).Append("\n");
        sb.Append("  EnableGPUManagement: ").Append(EnableGPUManagement).Append("\n");
        sb.Append("  EnableHostManagementFeatures: ").Append(EnableHostManagementFeatures).Append("\n");
        sb.Append("  Gpus: ").Append(Gpus).Append("\n");
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