namespace HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;

using System;
using System.Text.Json.Serialization;

/// <summary>
/// Portainer System Status Response
/// </summary>
public record SystemStatusResponse
{
    /// <summary>
    /// Gets the portainer version
    /// </summary>
    [JsonPropertyName("Version"), JsonConverter(typeof(JsonVersionConverter))]
    public Version Version { get; init; } = new(0, 0, 0);
}