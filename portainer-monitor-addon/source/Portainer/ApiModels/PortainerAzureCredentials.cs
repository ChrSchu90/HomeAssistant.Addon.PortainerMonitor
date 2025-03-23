#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerAzureCredentials {
    /// <summary>
    /// Azure application ID
    /// </summary>
    /// <value>Azure application ID</value>
    [JsonPropertyName("ApplicationID")]
    public string ApplicationID { get; set; }

    /// <summary>
    /// Azure authentication key
    /// </summary>
    /// <value>Azure authentication key</value>
    [JsonPropertyName("AuthenticationKey")]
    public string AuthenticationKey { get; set; }

    /// <summary>
    /// Azure tenant ID
    /// </summary>
    /// <value>Azure tenant ID</value>
    [JsonPropertyName("TenantID")]
    public string TenantID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerAzureCredentials {\n");
        sb.Append("  ApplicationID: ").Append(ApplicationID).Append("\n");
        sb.Append("  AuthenticationKey: ").Append(AuthenticationKey).Append("\n");
        sb.Append("  TenantID: ").Append(TenantID).Append("\n");
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