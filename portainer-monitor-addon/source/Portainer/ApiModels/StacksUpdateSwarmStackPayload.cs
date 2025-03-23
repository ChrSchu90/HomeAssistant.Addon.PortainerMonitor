#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class StacksUpdateSwarmStackPayload {
    /// <summary>
    /// A list of environment(endpoint) variables used during stack deployment
    /// </summary>
    /// <value>A list of environment(endpoint) variables used during stack deployment</value>
    [JsonPropertyName("env")]
    public List<PortainerPair> Env { get; set; }

    /// <summary>
    /// Prune services that are no longer referenced (only available for Swarm stacks)
    /// </summary>
    /// <value>Prune services that are no longer referenced (only available for Swarm stacks)</value>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary>
    /// Force a pulling to current image with the original tag though the image is already the latest
    /// </summary>
    /// <value>Force a pulling to current image with the original tag though the image is already the latest</value>
    [JsonPropertyName("pullImage")]
    public bool? PullImage { get; set; }

    /// <summary>
    /// New content of the Stack file
    /// </summary>
    /// <value>New content of the Stack file</value>
    [JsonPropertyName("stackFileContent")]
    public string StackFileContent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class StacksUpdateSwarmStackPayload {\n");
        sb.Append("  Env: ").Append(Env).Append("\n");
        sb.Append("  Prune: ").Append(Prune).Append("\n");
        sb.Append("  PullImage: ").Append(PullImage).Append("\n");
        sb.Append("  StackFileContent: ").Append(StackFileContent).Append("\n");
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