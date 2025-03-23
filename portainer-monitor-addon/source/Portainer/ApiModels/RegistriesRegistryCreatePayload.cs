#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class RegistriesRegistryCreatePayload {
    /// <summary>
    /// Is authentication against this registry enabled
    /// </summary>
    /// <value>Is authentication against this registry enabled</value>
    [JsonPropertyName("authentication")]
    public bool? Authentication { get; set; }

    /// <summary>
    /// BaseURL required for ProGet registry
    /// </summary>
    /// <value>BaseURL required for ProGet registry</value>
    [JsonPropertyName("baseURL")]
    public string BaseURL { get; set; }

    /// <summary>
    /// ECR specific details, required when type = 7
    /// </summary>
    /// <value>ECR specific details, required when type = 7</value>
    [JsonPropertyName("ecr")]
    public PortainerEcrData Ecr { get; set; }

    /// <summary>
    /// Gitlab specific details, required when type = 4
    /// </summary>
    /// <value>Gitlab specific details, required when type = 4</value>
    [JsonPropertyName("gitlab")]
    public PortainerGitlabRegistryData Gitlab { get; set; }

    /// <summary>
    /// Name that will be used to identify this registry
    /// </summary>
    /// <value>Name that will be used to identify this registry</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Password used to authenticate against this registry. required when Authentication is true
    /// </summary>
    /// <value>Password used to authenticate against this registry. required when Authentication is true</value>
    [JsonPropertyName("password")]
    public string Password { get; set; }

    /// <summary>
    /// Quay specific details, required when type = 1
    /// </summary>
    /// <value>Quay specific details, required when type = 1</value>
    [JsonPropertyName("quay")]
    public PortainerQuayRegistryData Quay { get; set; }

    /// <summary>
    /// Registry Type. Valid values are:  1 (Quay.io),  2 (Azure container registry),  3 (custom registry),  4 (Gitlab registry),  5 (ProGet registry),  6 (DockerHub)  7 (ECR)
    /// </summary>
    /// <value>Registry Type. Valid values are:  1 (Quay.io),  2 (Azure container registry),  3 (custom registry),  4 (Gitlab registry),  5 (ProGet registry),  6 (DockerHub)  7 (ECR)</value>
    [JsonPropertyName("type")]
    public int? Type { get; set; }

    /// <summary>
    /// URL or IP address of the Docker registry
    /// </summary>
    /// <value>URL or IP address of the Docker registry</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>
    /// Username used to authenticate against this registry. Required when Authentication is true
    /// </summary>
    /// <value>Username used to authenticate against this registry. Required when Authentication is true</value>
    [JsonPropertyName("username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class RegistriesRegistryCreatePayload {\n");
        sb.Append("  Authentication: ").Append(Authentication).Append("\n");
        sb.Append("  BaseURL: ").Append(BaseURL).Append("\n");
        sb.Append("  Ecr: ").Append(Ecr).Append("\n");
        sb.Append("  Gitlab: ").Append(Gitlab).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  Quay: ").Append(Quay).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
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