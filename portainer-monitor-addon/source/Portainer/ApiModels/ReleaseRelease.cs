#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class ReleaseRelease {
    /// <summary>
    /// Info provides information about a release Info *Info `json:\"info,omitempty\"` Chart is the chart that was released.
    /// </summary>
    /// <value>Info provides information about a release Info *Info `json:\"info,omitempty\"` Chart is the chart that was released.</value>
    [JsonPropertyName("chart")]
    public ReleaseChart Chart { get; set; }

    /// <summary>
    /// Config is the set of extra Values added to the chart. These values override the default values inside of the chart.
    /// </summary>
    /// <value>Config is the set of extra Values added to the chart. These values override the default values inside of the chart.</value>
    [JsonPropertyName("config")]
    public Dictionary<string, Object> Config { get; set; }

    /// <summary>
    /// Hooks are all of the hooks declared for this release.
    /// </summary>
    /// <value>Hooks are all of the hooks declared for this release.</value>
    [JsonPropertyName("hooks")]
    public List<ReleaseHook> Hooks { get; set; }

    /// <summary>
    /// Manifest is the string representation of the rendered template.
    /// </summary>
    /// <value>Manifest is the string representation of the rendered template.</value>
    [JsonPropertyName("manifest")]
    public string Manifest { get; set; }

    /// <summary>
    /// Name is the name of the release
    /// </summary>
    /// <value>Name is the name of the release</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Namespace is the kubernetes namespace of the release.
    /// </summary>
    /// <value>Namespace is the kubernetes namespace of the release.</value>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Version is an int which represents the revision of the release.
    /// </summary>
    /// <value>Version is an int which represents the revision of the release.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class ReleaseRelease {\n");
        sb.Append("  Chart: ").Append(Chart).Append("\n");
        sb.Append("  Config: ").Append(Config).Append("\n");
        sb.Append("  Hooks: ").Append(Hooks).Append("\n");
        sb.Append("  Manifest: ").Append(Manifest).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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