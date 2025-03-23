#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class DockerDashboardResponse {
    /// <summary>
    /// Gets or Sets Containers
    /// </summary>
    [JsonPropertyName("containers")]
    public DockerContainerStats Containers { get; set; }

    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    [JsonPropertyName("images")]
    public DockerImagesCounters Images { get; set; }

    /// <summary>
    /// Gets or Sets Networks
    /// </summary>
    [JsonPropertyName("networks")]
    public int? Networks { get; set; }

    /// <summary>
    /// Gets or Sets Services
    /// </summary>
    [JsonPropertyName("services")]
    public int? Services { get; set; }

    /// <summary>
    /// Gets or Sets Stacks
    /// </summary>
    [JsonPropertyName("stacks")]
    public int? Stacks { get; set; }

    /// <summary>
    /// Gets or Sets Volumes
    /// </summary>
    [JsonPropertyName("volumes")]
    public int? Volumes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class DockerDashboardResponse {\n");
        sb.Append("  Containers: ").Append(Containers).Append("\n");
        sb.Append("  Images: ").Append(Images).Append("\n");
        sb.Append("  Networks: ").Append(Networks).Append("\n");
        sb.Append("  Services: ").Append(Services).Append("\n");
        sb.Append("  Stacks: ").Append(Stacks).Append("\n");
        sb.Append("  Volumes: ").Append(Volumes).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}