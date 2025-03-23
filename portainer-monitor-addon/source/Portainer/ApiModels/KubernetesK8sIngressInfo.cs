#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sIngressInfo {
    /// <summary>
    /// Gets or Sets Annotations
    /// </summary>
    [JsonPropertyName("Annotations")]
    public Dictionary<string, string> Annotations { get; set; }

    /// <summary>
    /// Gets or Sets ClassName
    /// </summary>
    [JsonPropertyName("ClassName")]
    public string ClassName { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [JsonPropertyName("CreationDate")]
    public string CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets Hosts
    /// </summary>
    [JsonPropertyName("Hosts")]
    public List<string> Hosts { get; set; }

    /// <summary>
    /// Gets or Sets Labels
    /// </summary>
    [JsonPropertyName("Labels")]
    public Dictionary<string, string> Labels { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    [JsonPropertyName("Namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Gets or Sets Paths
    /// </summary>
    [JsonPropertyName("Paths")]
    public List<KubernetesK8sIngressPath> Paths { get; set; }

    /// <summary>
    /// Gets or Sets TLS
    /// </summary>
    [JsonPropertyName("TLS")]
    public List<KubernetesK8sIngressTLS> TLS { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("Type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets UID
    /// </summary>
    [JsonPropertyName("UID")]
    public string UID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sIngressInfo {\n");
        sb.Append("  Annotations: ").Append(Annotations).Append("\n");
        sb.Append("  ClassName: ").Append(ClassName).Append("\n");
        sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
        sb.Append("  Hosts: ").Append(Hosts).Append("\n");
        sb.Append("  Labels: ").Append(Labels).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  Paths: ").Append(Paths).Append("\n");
        sb.Append("  TLS: ").Append(TLS).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  UID: ").Append(UID).Append("\n");
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