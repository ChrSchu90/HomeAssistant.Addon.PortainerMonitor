#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EndpointsForceUpdateServicePayload {
    /// <summary>
    /// PullImage if true will pull the image
    /// </summary>
    /// <value>PullImage if true will pull the image</value>
    [JsonPropertyName("pullImage")]
    public bool? PullImage { get; set; }

    /// <summary>
    /// ServiceId to update
    /// </summary>
    /// <value>ServiceId to update</value>
    [JsonPropertyName("serviceID")]
    public string ServiceID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class EndpointsForceUpdateServicePayload {\n");
        sb.Append("  PullImage: ").Append(PullImage).Append("\n");
        sb.Append("  ServiceID: ").Append(ServiceID).Append("\n");
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