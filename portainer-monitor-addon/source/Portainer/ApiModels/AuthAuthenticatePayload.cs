#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text.Json.Serialization;

/// <summary>
/// 
/// </summary>
public class AuthAuthenticatePayload {
    /// <summary>
    /// Password
    /// </summary>
    /// <value>Password</value>
    [JsonPropertyName("password")]
    public string Password { get; set; }

    /// <summary>
    /// Username
    /// </summary>
    /// <value>Username</value>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}