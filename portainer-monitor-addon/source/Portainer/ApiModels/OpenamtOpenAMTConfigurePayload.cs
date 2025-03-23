#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class OpenamtOpenAMTConfigurePayload {
    /// <summary>
    /// Gets or Sets CertFileContent
    /// </summary>
    [JsonPropertyName("certFileContent")]
    public string CertFileContent { get; set; }

    /// <summary>
    /// Gets or Sets CertFileName
    /// </summary>
    [JsonPropertyName("certFileName")]
    public string CertFileName { get; set; }

    /// <summary>
    /// Gets or Sets CertFilePassword
    /// </summary>
    [JsonPropertyName("certFilePassword")]
    public string CertFilePassword { get; set; }

    /// <summary>
    /// Gets or Sets DomainName
    /// </summary>
    [JsonPropertyName("domainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets Mpspassword
    /// </summary>
    [JsonPropertyName("mpspassword")]
    public string Mpspassword { get; set; }

    /// <summary>
    /// Gets or Sets Mpsserver
    /// </summary>
    [JsonPropertyName("mpsserver")]
    public string Mpsserver { get; set; }

    /// <summary>
    /// Gets or Sets Mpsuser
    /// </summary>
    [JsonPropertyName("mpsuser")]
    public string Mpsuser { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class OpenamtOpenAMTConfigurePayload {\n");
        sb.Append("  CertFileContent: ").Append(CertFileContent).Append("\n");
        sb.Append("  CertFileName: ").Append(CertFileName).Append("\n");
        sb.Append("  CertFilePassword: ").Append(CertFilePassword).Append("\n");
        sb.Append("  DomainName: ").Append(DomainName).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Mpspassword: ").Append(Mpspassword).Append("\n");
        sb.Append("  Mpsserver: ").Append(Mpsserver).Append("\n");
        sb.Append("  Mpsuser: ").Append(Mpsuser).Append("\n");
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