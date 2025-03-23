#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerTemplateRepository {
    /// <summary>
    /// Path to the stack file inside the git repository
    /// </summary>
    /// <value>Path to the stack file inside the git repository</value>
    [JsonPropertyName("stackfile")]
    public string Stackfile { get; set; }

    /// <summary>
    /// URL of a git repository used to deploy a stack template. Mandatory for a Swarm/Compose stack template
    /// </summary>
    /// <value>URL of a git repository used to deploy a stack template. Mandatory for a Swarm/Compose stack template</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerTemplateRepository {\n");
        sb.Append("  Stackfile: ").Append(Stackfile).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
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