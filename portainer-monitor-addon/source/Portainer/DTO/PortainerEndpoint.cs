namespace HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;

using System.Text.Json.Serialization;

/// <summary>
/// Portainer endpoint response
/// </summary>
public record PortainerEndpoint
{
    /// <summary>
    /// Gets the endpoint ID
    /// </summary>
    [JsonPropertyName("Id")]
    public int Id { get; init; }

    /// <summary>
    /// Gets the endpoint name
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; init; } = string.Empty;
}