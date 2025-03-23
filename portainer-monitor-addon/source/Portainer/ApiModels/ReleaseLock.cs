#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class ReleaseLock {
    /// <summary>
    /// Dependencies is the list of dependencies that this lock file has locked.
    /// </summary>
    /// <value>Dependencies is the list of dependencies that this lock file has locked.</value>
    [JsonPropertyName("dependencies")]
    public List<ReleaseDependency> Dependencies { get; set; }

    /// <summary>
    /// Digest is a hash of the dependencies in Chart.yaml.
    /// </summary>
    /// <value>Digest is a hash of the dependencies in Chart.yaml.</value>
    [JsonPropertyName("digest")]
    public string Digest { get; set; }

    /// <summary>
    /// Generated is the date the lock file was last generated.
    /// </summary>
    /// <value>Generated is the date the lock file was last generated.</value>
    [JsonPropertyName("generated")]
    public string Generated { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class ReleaseLock {\n");
        sb.Append("  Dependencies: ").Append(Dependencies).Append("\n");
        sb.Append("  Digest: ").Append(Digest).Append("\n");
        sb.Append("  Generated: ").Append(Generated).Append("\n");
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