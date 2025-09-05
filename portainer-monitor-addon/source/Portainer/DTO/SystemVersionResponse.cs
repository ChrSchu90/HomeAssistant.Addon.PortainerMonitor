namespace HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;

using System;
using System.Text.Json.Serialization;

/// <summary>
/// Portainer System Version Response
/// </summary>
public record SystemVersionResponse
{
    /// <summary>
    /// Gets ServerEdition
    /// </summary>
    [JsonPropertyName("ServerEdition")]
    public string ServerEdition { get; init; } = string.Empty;

    /// <summary>
    /// Gets ServerVersion
    /// </summary>
    [JsonPropertyName("serverVersion"), JsonConverter(typeof(JsonVersionConverter))]
    public Version ServerVersion { get; init; } = new(0, 0, 0);

    /// <summary>
    /// Gets the latest version available
    /// </summary>
    [JsonPropertyName("LatestVersion"), JsonConverter(typeof(JsonVersionConverter))]
    public Version? LatestVersion { get; init; } = null;

    /// <summary>
    /// Gets a value whether portainer has an update available
    /// </summary>
    [JsonPropertyName("UpdateAvailable")]
    public bool? UpdateAvailable { get; init; }
}