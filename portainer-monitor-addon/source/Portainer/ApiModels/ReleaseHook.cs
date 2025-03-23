#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class ReleaseHook {
    /// <summary>
    /// DeletePolicies are the policies that indicate when to delete the hook
    /// </summary>
    /// <value>DeletePolicies are the policies that indicate when to delete the hook</value>
    [JsonPropertyName("delete_policies")]
    public List<string> DeletePolicies { get; set; }

    /// <summary>
    /// Events are the events that this hook fires on.
    /// </summary>
    /// <value>Events are the events that this hook fires on.</value>
    [JsonPropertyName("events")]
    public List<string> Events { get; set; }

    /// <summary>
    /// Kind is the Kubernetes kind.
    /// </summary>
    /// <value>Kind is the Kubernetes kind.</value>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>
    /// LastRun indicates the date/time this was last run.
    /// </summary>
    /// <value>LastRun indicates the date/time this was last run.</value>
    [JsonPropertyName("last_run")]
    public ReleaseHookExecution LastRun { get; set; }

    /// <summary>
    /// Manifest is the manifest contents.
    /// </summary>
    /// <value>Manifest is the manifest contents.</value>
    [JsonPropertyName("manifest")]
    public string Manifest { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Path is the chart-relative path to the template.
    /// </summary>
    /// <value>Path is the chart-relative path to the template.</value>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>
    /// Weight indicates the sort order for execution among similar Hook type
    /// </summary>
    /// <value>Weight indicates the sort order for execution among similar Hook type</value>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class ReleaseHook {\n");
        sb.Append("  DeletePolicies: ").Append(DeletePolicies).Append("\n");
        sb.Append("  Events: ").Append(Events).Append("\n");
        sb.Append("  Kind: ").Append(Kind).Append("\n");
        sb.Append("  LastRun: ").Append(LastRun).Append("\n");
        sb.Append("  Manifest: ").Append(Manifest).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Path: ").Append(Path).Append("\n");
        sb.Append("  Weight: ").Append(Weight).Append("\n");
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