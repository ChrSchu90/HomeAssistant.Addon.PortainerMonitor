namespace HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;

using System;
using System.Text;
using System.Text.Json.Serialization;

/// <summary>
/// Portainer System Version Response
/// </summary>
public class SystemVersionResponse
{
    /// <summary>
    /// Gets or Sets ServerEdition
    /// </summary>
    [JsonPropertyName("ServerEdition")]
    public string ServerEdition { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets ServerVersion
    /// </summary>
    [JsonPropertyName("serverVersion")]
    public Version ServerVersion { get; set; } = new(0, 0, 0);

    /// <summary>
    /// The latest version available
    /// </summary>
    /// <value>The latest version available</value>
    [JsonPropertyName("LatestVersion")]
    public string? LatestVersion { get; set; }

    /// <summary>
    /// Whether portainer has an update available
    /// </summary>
    /// <value>Whether portainer has an update available</value>
    [JsonPropertyName("UpdateAvailable")]
    public bool? UpdateAvailable { get; set; }

    /// <inheritdoc />
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("SystemVersionResponse {\n");
        sb.Append("  ServerEdition: ").Append(ServerEdition).Append("\n");
        sb.Append("  ServerVersion: ").Append(ServerVersion).Append("\n");
        sb.Append("  LatestVersion: ").Append(LatestVersion).Append("\n");
        sb.Append("  UpdateAvailable: ").Append(UpdateAvailable ?? false).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}