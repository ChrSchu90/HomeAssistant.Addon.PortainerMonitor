#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class StacksSwarmStackFromFileContentPayload {
    /// <summary>
    /// A list of environment variables used during stack deployment
    /// </summary>
    /// <value>A list of environment variables used during stack deployment</value>
    [JsonPropertyName("env")]
    public List<PortainerPair> Env { get; set; }

    /// <summary>
    /// Whether the stack is from a app template
    /// </summary>
    /// <value>Whether the stack is from a app template</value>
    [JsonPropertyName("fromAppTemplate")]
    public bool? FromAppTemplate { get; set; }

    /// <summary>
    /// Name of the stack
    /// </summary>
    /// <value>Name of the stack</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Content of the Stack file
    /// </summary>
    /// <value>Content of the Stack file</value>
    [JsonPropertyName("stackFileContent")]
    public string StackFileContent { get; set; }

    /// <summary>
    /// Swarm cluster identifier
    /// </summary>
    /// <value>Swarm cluster identifier</value>
    [JsonPropertyName("swarmID")]
    public string SwarmID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class StacksSwarmStackFromFileContentPayload {\n");
        sb.Append("  Env: ").Append(Env).Append("\n");
        sb.Append("  FromAppTemplate: ").Append(FromAppTemplate).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  StackFileContent: ").Append(StackFileContent).Append("\n");
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