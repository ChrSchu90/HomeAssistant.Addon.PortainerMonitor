#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class StacksStackMigratePayload {
    /// <summary>
    /// Environment(Endpoint) identifier of the target environment(endpoint) where the stack will be relocated
    /// </summary>
    /// <value>Environment(Endpoint) identifier of the target environment(endpoint) where the stack will be relocated</value>
    [JsonPropertyName("endpointID")]
    public int? EndpointID { get; set; }

    /// <summary>
    /// If provided will rename the migrated stack
    /// </summary>
    /// <value>If provided will rename the migrated stack</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Swarm cluster identifier, must match the identifier of the cluster where the stack will be relocated
    /// </summary>
    /// <value>Swarm cluster identifier, must match the identifier of the cluster where the stack will be relocated</value>
    [JsonPropertyName("swarmID")]
    public string SwarmID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class StacksStackMigratePayload {\n");
        sb.Append("  EndpointID: ").Append(EndpointID).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SwarmID: ").Append(SwarmID).Append("\n");
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