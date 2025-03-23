#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerKubernetesStorageClassConfig {
    /// <summary>
    /// Gets or Sets AccessModes
    /// </summary>
    [JsonPropertyName("AccessModes")]
    public List<string> AccessModes { get; set; }

    /// <summary>
    /// Gets or Sets AllowVolumeExpansion
    /// </summary>
    [JsonPropertyName("AllowVolumeExpansion")]
    public bool? AllowVolumeExpansion { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Provisioner
    /// </summary>
    [JsonPropertyName("Provisioner")]
    public string Provisioner { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerKubernetesStorageClassConfig {\n");
        sb.Append("  AccessModes: ").Append(AccessModes).Append("\n");
        sb.Append("  AllowVolumeExpansion: ").Append(AllowVolumeExpansion).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Provisioner: ").Append(Provisioner).Append("\n");
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