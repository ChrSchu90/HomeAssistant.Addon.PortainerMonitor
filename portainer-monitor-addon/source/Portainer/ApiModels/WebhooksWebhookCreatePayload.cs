#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class WebhooksWebhookCreatePayload {
    /// <summary>
    /// Environment(Endpoint) identifier. Reference the environment(endpoint) that will be used for deployment
    /// </summary>
    /// <value>Environment(Endpoint) identifier. Reference the environment(endpoint) that will be used for deployment</value>
    [JsonPropertyName("endpointID")]
    public int? EndpointID { get; set; }

    /// <summary>
    /// Registry Identifier
    /// </summary>
    /// <value>Registry Identifier</value>
    [JsonPropertyName("registryID")]
    public int? RegistryID { get; set; }

    /// <summary>
    /// Gets or Sets ResourceID
    /// </summary>
    [JsonPropertyName("resourceID")]
    public string ResourceID { get; set; }

    /// <summary>
    /// Type of webhook (1 - service)
    /// </summary>
    /// <value>Type of webhook (1 - service)</value>
    [JsonPropertyName("webhookType")]
    public int? WebhookType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class WebhooksWebhookCreatePayload {\n");
        sb.Append("  EndpointID: ").Append(EndpointID).Append("\n");
        sb.Append("  RegistryID: ").Append(RegistryID).Append("\n");
        sb.Append("  ResourceID: ").Append(ResourceID).Append("\n");
        sb.Append("  WebhookType: ").Append(WebhookType).Append("\n");
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