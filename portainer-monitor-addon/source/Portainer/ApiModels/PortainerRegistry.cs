#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerRegistry {
    /// <summary>
    /// Stores temporary access token
    /// </summary>
    /// <value>Stores temporary access token</value>
    [JsonPropertyName("AccessToken")]
    public string AccessToken { get; set; }

    /// <summary>
    /// Gets or Sets AccessTokenExpiry
    /// </summary>
    [JsonPropertyName("AccessTokenExpiry")]
    public int? AccessTokenExpiry { get; set; }

    /// <summary>
    /// Is authentication against this registry enabled
    /// </summary>
    /// <value>Is authentication against this registry enabled</value>
    [JsonPropertyName("Authentication")]
    public bool? Authentication { get; set; }

    /// <summary>
    /// Deprecated in DBVersion == 18
    /// </summary>
    /// <value>Deprecated in DBVersion == 18</value>
    [JsonPropertyName("AuthorizedTeams")]
    public List<int?> AuthorizedTeams { get; set; }

    /// <summary>
    /// Deprecated in DBVersion == 18
    /// </summary>
    /// <value>Deprecated in DBVersion == 18</value>
    [JsonPropertyName("AuthorizedUsers")]
    public List<int?> AuthorizedUsers { get; set; }

    /// <summary>
    /// Base URL, introduced for ProGet registry
    /// </summary>
    /// <value>Base URL, introduced for ProGet registry</value>
    [JsonPropertyName("BaseURL")]
    public string BaseURL { get; set; }

    /// <summary>
    /// Gets or Sets Ecr
    /// </summary>
    [JsonPropertyName("Ecr")]
    public PortainerEcrData Ecr { get; set; }

    /// <summary>
    /// Gets or Sets Gitlab
    /// </summary>
    [JsonPropertyName("Gitlab")]
    public PortainerGitlabRegistryData Gitlab { get; set; }

    /// <summary>
    /// Registry Identifier
    /// </summary>
    /// <value>Registry Identifier</value>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets ManagementConfiguration
    /// </summary>
    [JsonPropertyName("ManagementConfiguration")]
    public PortainerRegistryManagementConfiguration ManagementConfiguration { get; set; }

    /// <summary>
    /// Registry Name
    /// </summary>
    /// <value>Registry Name</value>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Password or SecretAccessKey used to authenticate against this registry
    /// </summary>
    /// <value>Password or SecretAccessKey used to authenticate against this registry</value>
    [JsonPropertyName("Password")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or Sets Quay
    /// </summary>
    [JsonPropertyName("Quay")]
    public PortainerQuayRegistryData Quay { get; set; }

    /// <summary>
    /// Gets or Sets RegistryAccesses
    /// </summary>
    [JsonPropertyName("RegistryAccesses")]
    public PortainerRegistryAccesses RegistryAccesses { get; set; }

    /// <summary>
    /// Deprecated in DBVersion == 31
    /// </summary>
    /// <value>Deprecated in DBVersion == 31</value>
    [JsonPropertyName("TeamAccessPolicies")]
    public PortainerTeamAccessPolicies TeamAccessPolicies { get; set; }

    /// <summary>
    /// Registry Type (1 - Quay, 2 - Azure, 3 - Custom, 4 - Gitlab, 5 - ProGet, 6 - DockerHub, 7 - ECR)
    /// </summary>
    /// <value>Registry Type (1 - Quay, 2 - Azure, 3 - Custom, 4 - Gitlab, 5 - ProGet, 6 - DockerHub, 7 - ECR)</value>
    [JsonPropertyName("Type")]
    public int? Type { get; set; }

    /// <summary>
    /// URL or IP address of the Docker registry
    /// </summary>
    /// <value>URL or IP address of the Docker registry</value>
    [JsonPropertyName("URL")]
    public string URL { get; set; }

    /// <summary>
    /// Deprecated fields Deprecated in DBVersion == 31
    /// </summary>
    /// <value>Deprecated fields Deprecated in DBVersion == 31</value>
    [JsonPropertyName("UserAccessPolicies")]
    public PortainerUserAccessPolicies UserAccessPolicies { get; set; }

    /// <summary>
    /// Username or AccessKeyID used to authenticate against this registry
    /// </summary>
    /// <value>Username or AccessKeyID used to authenticate against this registry</value>
    [JsonPropertyName("Username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerRegistry {\n");
        sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
        sb.Append("  AccessTokenExpiry: ").Append(AccessTokenExpiry).Append("\n");
        sb.Append("  Authentication: ").Append(Authentication).Append("\n");
        sb.Append("  AuthorizedTeams: ").Append(AuthorizedTeams).Append("\n");
        sb.Append("  AuthorizedUsers: ").Append(AuthorizedUsers).Append("\n");
        sb.Append("  BaseURL: ").Append(BaseURL).Append("\n");
        sb.Append("  Ecr: ").Append(Ecr).Append("\n");
        sb.Append("  Gitlab: ").Append(Gitlab).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ManagementConfiguration: ").Append(ManagementConfiguration).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  Quay: ").Append(Quay).Append("\n");
        sb.Append("  RegistryAccesses: ").Append(RegistryAccesses).Append("\n");
        sb.Append("  TeamAccessPolicies: ").Append(TeamAccessPolicies).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  URL: ").Append(URL).Append("\n");
        sb.Append("  UserAccessPolicies: ").Append(UserAccessPolicies).Append("\n");
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