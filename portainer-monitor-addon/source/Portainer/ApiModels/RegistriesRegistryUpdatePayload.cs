#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class RegistriesRegistryUpdatePayload {
    /// <summary>
    /// Is authentication against this registry enabled
    /// </summary>
    /// <value>Is authentication against this registry enabled</value>
    [JsonPropertyName("authentication")]
    public bool? Authentication { get; set; }

    /// <summary>
    /// BaseURL is used for quay registry
    /// </summary>
    /// <value>BaseURL is used for quay registry</value>
    [JsonPropertyName("baseURL")]
    public string BaseURL { get; set; }

    /// <summary>
    /// ECR data
    /// </summary>
    /// <value>ECR data</value>
    [JsonPropertyName("ecr")]
    public PortainerEcrData Ecr { get; set; }

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
    /// Quay data
    /// </summary>
    /// <value>Quay data</value>
    [JsonPropertyName("quay")]
    public PortainerQuayRegistryData Quay { get; set; }

    /// <summary>
    /// Registry access control
    /// </summary>
    /// <value>Registry access control</value>
    [JsonPropertyName("registryAccesses")]
    public PortainerRegistryAccesses RegistryAccesses { get; set; }

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
        sb.Append("class RegistriesRegistryUpdatePayload {\n");
        sb.Append("  Authentication: ").Append(Authentication).Append("\n");
        sb.Append("  BaseURL: ").Append(BaseURL).Append("\n");
        sb.Append("  Ecr: ").Append(Ecr).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  Quay: ").Append(Quay).Append("\n");
        sb.Append("  RegistryAccesses: ").Append(RegistryAccesses).Append("\n");
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