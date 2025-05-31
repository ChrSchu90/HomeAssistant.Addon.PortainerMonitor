namespace HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;

using System;
using System.Text.Json.Serialization;

/// <summary>
/// Docker version information
/// </summary>
public class DockerVersionInfo
{
    /// <summary>
    /// Gets the docker version.
    /// </summary>
    [JsonPropertyName("Version")]
    public Version Version { get; set; } = null!;

    /// <summary>
    /// Gets or sets the docker API version.
    /// </summary>
    [JsonPropertyName("ApiVersion")]
    public Version ApiVersion { get; set; } = null!;

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{nameof(DockerVersionInfo)}: v{Version} (API v{ApiVersion})";
    }
}