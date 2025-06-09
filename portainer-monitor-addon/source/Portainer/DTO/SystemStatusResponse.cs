namespace HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;

using System;
using System.Text.Json.Serialization;

/// <summary>
/// Portainer System Status Response
/// </summary>
public class SystemStatusResponse
{
    /// <summary>
    /// Gets or sets the portainer version
    /// </summary>
    [JsonPropertyName("Version")]
    public Version Version { get; set; } = new(0, 0, 0);
}