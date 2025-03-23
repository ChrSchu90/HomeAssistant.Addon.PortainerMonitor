#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerEdgeStackStatusDetails {
    /// <summary>
    /// Gets or Sets Acknowledged
    /// </summary>
    [JsonPropertyName("acknowledged")]
    public bool? Acknowledged { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [JsonPropertyName("error")]
    public bool? Error { get; set; }

    /// <summary>
    /// Gets or Sets ImagesPulled
    /// </summary>
    [JsonPropertyName("imagesPulled")]
    public bool? ImagesPulled { get; set; }

    /// <summary>
    /// Gets or Sets Ok
    /// </summary>
    [JsonPropertyName("ok")]
    public bool? Ok { get; set; }

    /// <summary>
    /// Gets or Sets Pending
    /// </summary>
    [JsonPropertyName("pending")]
    public bool? Pending { get; set; }

    /// <summary>
    /// Gets or Sets RemoteUpdateSuccess
    /// </summary>
    [JsonPropertyName("remoteUpdateSuccess")]
    public bool? RemoteUpdateSuccess { get; set; }

    /// <summary>
    /// Gets or Sets Remove
    /// </summary>
    [JsonPropertyName("remove")]
    public bool? Remove { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerEdgeStackStatusDetails {\n");
        sb.Append("  Acknowledged: ").Append(Acknowledged).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  ImagesPulled: ").Append(ImagesPulled).Append("\n");
        sb.Append("  Ok: ").Append(Ok).Append("\n");
        sb.Append("  Pending: ").Append(Pending).Append("\n");
        sb.Append("  RemoteUpdateSuccess: ").Append(RemoteUpdateSuccess).Append("\n");
        sb.Append("  Remove: ").Append(Remove).Append("\n");
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