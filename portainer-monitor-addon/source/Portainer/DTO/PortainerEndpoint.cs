namespace HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;

using System.Text;
using System.Text.Json.Serialization;

/// <summary>
/// Portainer endpoint response
/// </summary>
public class PortainerEndpoint
{
    /// <summary>
    /// Environment(Endpoint) Identifier
    /// </summary>
    /// <value>Environment(Endpoint) Identifier</value>
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    /// <summary>
    /// Environment(Endpoint) name
    /// </summary>
    /// <value>Environment(Endpoint) name</value>
    [JsonPropertyName("Name")]
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("PortainerEndpoint {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}