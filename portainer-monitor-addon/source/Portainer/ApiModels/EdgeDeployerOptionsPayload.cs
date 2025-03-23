#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class EdgeDeployerOptionsPayload {
    /// <summary>
    /// Prune is a flag indicating if the agent must prune the containers or not when creating/updating an edge stack This flag drives `docker compose up - -remove-orphans` and `docker stack up - -prune` options Used only for EE
    /// </summary>
    /// <value>Prune is a flag indicating if the agent must prune the containers or not when creating/updating an edge stack This flag drives `docker compose up - -remove-orphans` and `docker stack up - -prune` options Used only for EE</value>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary>
    /// RemoveVolumes is a flag indicating if the agent must remove the named volumes declared in the compose file and anonymouse volumes attached to containers This flag drives `docker compose down - -volumes` option Used only for EE
    /// </summary>
    /// <value>RemoveVolumes is a flag indicating if the agent must remove the named volumes declared in the compose file and anonymouse volumes attached to containers This flag drives `docker compose down - -volumes` option Used only for EE</value>
    [JsonPropertyName("removeVolumes")]
    public bool? RemoveVolumes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class EdgeDeployerOptionsPayload {\n");
        sb.Append("  Prune: ").Append(Prune).Append("\n");
        sb.Append("  RemoveVolumes: ").Append(RemoveVolumes).Append("\n");
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