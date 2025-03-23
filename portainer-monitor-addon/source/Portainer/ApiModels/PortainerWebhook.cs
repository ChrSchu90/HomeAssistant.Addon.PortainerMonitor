#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerWebhook {
    /// <summary>
    /// Environment(Endpoint) identifier. Reference the environment(endpoint) that will be used for deployment
    /// </summary>
    /// <value>Environment(Endpoint) identifier. Reference the environment(endpoint) that will be used for deployment</value>
    [JsonPropertyName("EndpointId")]
    public int? EndpointId { get; set; }

    /// <summary>
    /// Webhook Identifier
    /// </summary>
    /// <value>Webhook Identifier</value>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Registry Identifier
    /// </summary>
    /// <value>Registry Identifier</value>
    [JsonPropertyName("RegistryId")]
    public int? RegistryId { get; set; }

    /// <summary>
    /// Gets or Sets ResourceId
    /// </summary>
    [JsonPropertyName("ResourceId")]
    public string ResourceId { get; set; }

    /// <summary>
    /// Gets or Sets Token
    /// </summary>
    [JsonPropertyName("Token")]
    public string Token { get; set; }

    /// <summary>
    /// Type of webhook (1 - service)
    /// </summary>
    /// <value>Type of webhook (1 - service)</value>
    [JsonPropertyName("Type")]
    public int? Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerWebhook {\n");
        sb.Append("  EndpointId: ").Append(EndpointId).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  RegistryId: ").Append(RegistryId).Append("\n");
        sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
        sb.Append("  Token: ").Append(Token).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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