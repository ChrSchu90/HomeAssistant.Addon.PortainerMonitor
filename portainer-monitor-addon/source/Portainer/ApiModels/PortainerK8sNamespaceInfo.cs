#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerK8sNamespaceInfo {
    /// <summary>
    /// Gets or Sets Annotations
    /// </summary>
    [JsonPropertyName("Annotations")]
    public Dictionary<string, string> Annotations { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [JsonPropertyName("CreationDate")]
    public string CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("Id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets IsDefault
    /// </summary>
    [JsonPropertyName("IsDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>
    /// Gets or Sets IsSystem
    /// </summary>
    [JsonPropertyName("IsSystem")]
    public bool? IsSystem { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets NamespaceOwner
    /// </summary>
    [JsonPropertyName("NamespaceOwner")]
    public string NamespaceOwner { get; set; }

    /// <summary>
    /// Gets or Sets ResourceQuota
    /// </summary>
    [JsonPropertyName("ResourceQuota")]
    public V1ResourceQuota ResourceQuota { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("Status")]
    public V1NamespaceStatus Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerK8sNamespaceInfo {\n");
        sb.Append("  Annotations: ").Append(Annotations).Append("\n");
        sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
        sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  NamespaceOwner: ").Append(NamespaceOwner).Append("\n");
        sb.Append("  ResourceQuota: ").Append(ResourceQuota).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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