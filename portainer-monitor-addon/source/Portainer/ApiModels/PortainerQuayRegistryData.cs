#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerQuayRegistryData {
    /// <summary>
    /// Gets or Sets OrganisationName
    /// </summary>
    [JsonPropertyName("OrganisationName")]
    public string OrganisationName { get; set; }

    /// <summary>
    /// Gets or Sets UseOrganisation
    /// </summary>
    [JsonPropertyName("UseOrganisation")]
    public bool? UseOrganisation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerQuayRegistryData {\n");
        sb.Append("  OrganisationName: ").Append(OrganisationName).Append("\n");
        sb.Append("  UseOrganisation: ").Append(UseOrganisation).Append("\n");
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