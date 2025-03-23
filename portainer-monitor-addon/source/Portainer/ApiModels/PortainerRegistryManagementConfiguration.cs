#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerRegistryManagementConfiguration {
    /// <summary>
    /// Gets or Sets AccessToken
    /// </summary>
    [JsonPropertyName("AccessToken")]
    public string AccessToken { get; set; }

    /// <summary>
    /// Gets or Sets AccessTokenExpiry
    /// </summary>
    [JsonPropertyName("AccessTokenExpiry")]
    public int? AccessTokenExpiry { get; set; }

    /// <summary>
    /// Gets or Sets Authentication
    /// </summary>
    [JsonPropertyName("Authentication")]
    public bool? Authentication { get; set; }

    /// <summary>
    /// Gets or Sets Ecr
    /// </summary>
    [JsonPropertyName("Ecr")]
    public PortainerEcrData Ecr { get; set; }

    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [JsonPropertyName("Password")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or Sets TLSConfig
    /// </summary>
    [JsonPropertyName("TLSConfig")]
    public PortainerTLSConfiguration TLSConfig { get; set; }

    /// <summary>
    /// Registry Type (1 - Quay, 2 - Azure, 3 - Custom, 4 - Gitlab, 5 - ProGet, 6 - DockerHub, 7 - ECR)
    /// </summary>
    /// <value>Registry Type (1 - Quay, 2 - Azure, 3 - Custom, 4 - Gitlab, 5 - ProGet, 6 - DockerHub, 7 - ECR)</value>
    [JsonPropertyName("Type")]
    public int? Type { get; set; }

    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [JsonPropertyName("Username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerRegistryManagementConfiguration {\n");
        sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
        sb.Append("  AccessTokenExpiry: ").Append(AccessTokenExpiry).Append("\n");
        sb.Append("  Authentication: ").Append(Authentication).Append("\n");
        sb.Append("  Ecr: ").Append(Ecr).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  TLSConfig: ").Append(TLSConfig).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Username: ").Append(Username).Append("\n");
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