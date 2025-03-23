#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1EnvVarSource {
    /// <summary>
    /// Selects a key of a ConfigMap. +optional
    /// </summary>
    /// <value>Selects a key of a ConfigMap. +optional</value>
    [JsonPropertyName("configMapKeyRef")]
    public V1ConfigMapKeySelector ConfigMapKeyRef { get; set; }

    /// <summary>
    /// Selects a field of the pod: supports metadata.name, metadata.namespace, `metadata.labels['<KEY>']`, `metadata.annotations['<KEY>']`, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs. +optional
    /// </summary>
    /// <value>Selects a field of the pod: supports metadata.name, metadata.namespace, `metadata.labels['<KEY>']`, `metadata.annotations['<KEY>']`, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs. +optional</value>
    [JsonPropertyName("fieldRef")]
    public V1ObjectFieldSelector FieldRef { get; set; }

    /// <summary>
    /// Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported. +optional
    /// </summary>
    /// <value>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported. +optional</value>
    [JsonPropertyName("resourceFieldRef")]
    public V1ResourceFieldSelector ResourceFieldRef { get; set; }

    /// <summary>
    /// Selects a key of a secret in the pod's namespace +optional
    /// </summary>
    /// <value>Selects a key of a secret in the pod's namespace +optional</value>
    [JsonPropertyName("secretKeyRef")]
    public V1SecretKeySelector SecretKeyRef { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1EnvVarSource {\n");
        sb.Append("  ConfigMapKeyRef: ").Append(ConfigMapKeyRef).Append("\n");
        sb.Append("  FieldRef: ").Append(FieldRef).Append("\n");
        sb.Append("  ResourceFieldRef: ").Append(ResourceFieldRef).Append("\n");
        sb.Append("  SecretKeyRef: ").Append(SecretKeyRef).Append("\n");
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