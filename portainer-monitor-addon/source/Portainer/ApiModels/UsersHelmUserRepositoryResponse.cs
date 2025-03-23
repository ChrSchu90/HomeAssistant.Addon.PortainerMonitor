#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class UsersHelmUserRepositoryResponse {
    /// <summary>
    /// Gets or Sets GlobalRepository
    /// </summary>
    [JsonPropertyName("GlobalRepository")]
    public string GlobalRepository { get; set; }

    /// <summary>
    /// Gets or Sets UserRepositories
    /// </summary>
    [JsonPropertyName("UserRepositories")]
    public List<PortainerHelmUserRepository> UserRepositories { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class UsersHelmUserRepositoryResponse {\n");
        sb.Append("  GlobalRepository: ").Append(GlobalRepository).Append("\n");
        sb.Append("  UserRepositories: ").Append(UserRepositories).Append("\n");
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