#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sConfigMap {
    /// <summary>
    /// Gets or Sets Annotations
    /// </summary>
    [JsonPropertyName("Annotations")]
    public Dictionary<string, string> Annotations { get; set; }

    /// <summary>
    /// Gets or Sets ConfigurationOwner
    /// </summary>
    [JsonPropertyName("ConfigurationOwner")]
    public string ConfigurationOwner { get; set; }

    /// <summary>
    /// Gets or Sets ConfigurationOwnerId
    /// </summary>
    [JsonPropertyName("ConfigurationOwnerId")]
    public string ConfigurationOwnerId { get; set; }

    /// <summary>
    /// Gets or Sets ConfigurationOwners
    /// </summary>
    [JsonPropertyName("ConfigurationOwners")]
    public List<KubernetesK8sConfigurationOwnerResource> ConfigurationOwners { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [JsonPropertyName("CreationDate")]
    public string CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [JsonPropertyName("Data")]
    public Dictionary<string, string> Data { get; set; }

    /// <summary>
    /// Gets or Sets IsUsed
    /// </summary>
    [JsonPropertyName("IsUsed")]
    public bool? IsUsed { get; set; }

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
        sb.Append("class KubernetesK8sConfigMap {\n");
        sb.Append("  Annotations: ").Append(Annotations).Append("\n");
        sb.Append("  ConfigurationOwner: ").Append(ConfigurationOwner).Append("\n");
        sb.Append("  ConfigurationOwnerId: ").Append(ConfigurationOwnerId).Append("\n");
        sb.Append("  ConfigurationOwners: ").Append(ConfigurationOwners).Append("\n");
        sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
        sb.Append("  IsUsed: ").Append(IsUsed).Append("\n");
        sb.Append("  Labels: ").Append(Labels).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
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