#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1WindowsSecurityContextOptions {
    /// <summary>
    /// GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field. +optional
    /// </summary>
    /// <value>GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field. +optional</value>
    [JsonPropertyName("gmsaCredentialSpec")]
    public string GmsaCredentialSpec { get; set; }

    /// <summary>
    /// GMSACredentialSpecName is the name of the GMSA credential spec to use. +optional
    /// </summary>
    /// <value>GMSACredentialSpecName is the name of the GMSA credential spec to use. +optional</value>
    [JsonPropertyName("gmsaCredentialSpecName")]
    public string GmsaCredentialSpecName { get; set; }

    /// <summary>
    /// HostProcess determines if a container should be run as a 'Host Process' container. All of a Pod's containers must have the same effective HostProcess value (it is not allowed to have a mix of HostProcess containers and non-HostProcess containers). In addition, if HostProcess is true then HostNetwork must also be set to true. +optional
    /// </summary>
    /// <value>HostProcess determines if a container should be run as a 'Host Process' container. All of a Pod's containers must have the same effective HostProcess value (it is not allowed to have a mix of HostProcess containers and non-HostProcess containers). In addition, if HostProcess is true then HostNetwork must also be set to true. +optional</value>
    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    /// <summary>
    /// The UserName in Windows to run the entrypoint of the container process. Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. +optional
    /// </summary>
    /// <value>The UserName in Windows to run the entrypoint of the container process. Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. +optional</value>
    [JsonPropertyName("runAsUserName")]
    public string RunAsUserName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1WindowsSecurityContextOptions {\n");
        sb.Append("  GmsaCredentialSpec: ").Append(GmsaCredentialSpec).Append("\n");
        sb.Append("  GmsaCredentialSpecName: ").Append(GmsaCredentialSpecName).Append("\n");
        sb.Append("  HostProcess: ").Append(HostProcess).Append("\n");
        sb.Append("  RunAsUserName: ").Append(RunAsUserName).Append("\n");
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