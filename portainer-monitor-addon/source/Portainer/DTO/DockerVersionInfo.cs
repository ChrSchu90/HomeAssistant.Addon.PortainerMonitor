namespace HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;

using System;
using System.Text.Json.Serialization;

/// <summary>
/// Docker version information
/// </summary>
public record DockerVersionInfo
{
    /// <summary>
    /// Gets the docker version.
    /// </summary>
    [JsonPropertyName("Version"), JsonConverter(typeof(JsonVersionConverter))]
    public Version Version { get; init; } = null!;

    /// <summary>
    /// Gets the docker API version.
    /// </summary>
    [JsonPropertyName("ApiVersion"), JsonConverter(typeof(JsonVersionConverter))]
    public Version ApiVersion { get; init; } = null!;
}