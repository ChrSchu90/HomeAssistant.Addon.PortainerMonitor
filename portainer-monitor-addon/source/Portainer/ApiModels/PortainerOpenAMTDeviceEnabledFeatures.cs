#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerOpenAMTDeviceEnabledFeatures {
    /// <summary>
    /// Gets or Sets IDER
    /// </summary>
    [JsonPropertyName("IDER")]
    public bool? IDER { get; set; }

    /// <summary>
    /// Gets or Sets KVM
    /// </summary>
    [JsonPropertyName("KVM")]
    public bool? KVM { get; set; }

    /// <summary>
    /// Gets or Sets SOL
    /// </summary>
    [JsonPropertyName("SOL")]
    public bool? SOL { get; set; }

    /// <summary>
    /// Gets or Sets Redirection
    /// </summary>
    [JsonPropertyName("redirection")]
    public bool? Redirection { get; set; }

    /// <summary>
    /// Gets or Sets UserConsent
    /// </summary>
    [JsonPropertyName("userConsent")]
    public string UserConsent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerOpenAMTDeviceEnabledFeatures {\n");
        sb.Append("  IDER: ").Append(IDER).Append("\n");
        sb.Append("  KVM: ").Append(KVM).Append("\n");
        sb.Append("  SOL: ").Append(SOL).Append("\n");
        sb.Append("  Redirection: ").Append(Redirection).Append("\n");
        sb.Append("  UserConsent: ").Append(UserConsent).Append("\n");
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