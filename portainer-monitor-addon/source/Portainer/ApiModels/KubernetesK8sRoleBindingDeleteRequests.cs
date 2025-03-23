#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sRoleBindingDeleteRequests : Dictionary<String, List<string>> {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sRoleBindingDeleteRequests {\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}