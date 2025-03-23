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
public class ReleaseDependency {
    /// <summary>
    /// Alias usable alias to be used for the chart
    /// </summary>
    /// <value>Alias usable alias to be used for the chart</value>
    [JsonPropertyName("alias")]
    public string Alias { get; set; }

    /// <summary>
    /// A yaml path that resolves to a boolean, used for enabling/disabling charts (e.g. subchart1.enabled )
    /// </summary>
    /// <value>A yaml path that resolves to a boolean, used for enabling/disabling charts (e.g. subchart1.enabled )</value>
    [JsonPropertyName("condition")]
    public string Condition { get; set; }

    /// <summary>
    /// Enabled bool determines if chart should be loaded
    /// </summary>
    /// <value>Enabled bool determines if chart should be loaded</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// ImportValues holds the mapping of source values to parent key to be imported. Each item can be a string or pair of child/parent sublist items.
    /// </summary>
    /// <value>ImportValues holds the mapping of source values to parent key to be imported. Each item can be a string or pair of child/parent sublist items.</value>
    [JsonPropertyName("import-values")]
    public List<Object> ImportValues { get; set; }

    /// <summary>
    /// Name is the name of the dependency.  This must mach the name in the dependency's Chart.yaml.
    /// </summary>
    /// <value>Name is the name of the dependency.  This must mach the name in the dependency's Chart.yaml.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The URL to the repository.  Appending `index.yaml` to this string should result in a URL that can be used to fetch the repository index.
    /// </summary>
    /// <value>The URL to the repository.  Appending `index.yaml` to this string should result in a URL that can be used to fetch the repository index.</value>
    [JsonPropertyName("repository")]
    public string Repository { get; set; }

    /// <summary>
    /// Tags can be used to group charts for enabling/disabling together
    /// </summary>
    /// <value>Tags can be used to group charts for enabling/disabling together</value>
    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Version is the version (range) of this chart.  A lock file will always produce a single version, while a dependency may contain a semantic version range.
    /// </summary>
    /// <value>Version is the version (range) of this chart.  A lock file will always produce a single version, while a dependency may contain a semantic version range.</value>
    [JsonPropertyName("version")]
    public string Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class ReleaseDependency {\n");
        sb.Append("  Alias: ").Append(Alias).Append("\n");
        sb.Append("  Condition: ").Append(Condition).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  ImportValues: ").Append(ImportValues).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Repository: ").Append(Repository).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
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