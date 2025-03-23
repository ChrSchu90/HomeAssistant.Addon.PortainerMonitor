#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;

/// <summary>
/// 
/// </summary>
public class AuthOauthPayload {
    /// <summary>
    /// OAuth code returned from OAuth Provided
    /// </summary>
    /// <value>OAuth code returned from OAuth Provided</value>
    [JsonPropertyName("code")]
    public string Code { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class AuthOauthPayload {\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}