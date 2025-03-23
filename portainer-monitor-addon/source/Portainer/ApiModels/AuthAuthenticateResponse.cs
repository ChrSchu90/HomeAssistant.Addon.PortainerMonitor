#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;

/// <summary>
/// 
/// </summary>
public class AuthAuthenticateResponse {
    /// <summary>
    /// JWT token used to authenticate against the API
    /// </summary>
    /// <value>JWT token used to authenticate against the API</value>
    [JsonPropertyName("jwt")]
    public string Jwt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class AuthAuthenticateResponse {\n");
        sb.Append("  Jwt: ").Append(Jwt).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}