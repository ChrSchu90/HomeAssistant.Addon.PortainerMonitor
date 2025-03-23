#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class ReleaseMetadata {
    /// <summary>
    /// Annotations are additional mappings uninterpreted by Helm, made available for inspection by other applications.
    /// </summary>
    /// <value>Annotations are additional mappings uninterpreted by Helm, made available for inspection by other applications.</value>
    [JsonPropertyName("annotations")]
    public Dictionary<string, string> Annotations { get; set; }

    /// <summary>
    /// The API Version of this chart. Required.
    /// </summary>
    /// <value>The API Version of this chart. Required.</value>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>
    /// The version of the application enclosed inside of this chart.
    /// </summary>
    /// <value>The version of the application enclosed inside of this chart.</value>
    [JsonPropertyName("appVersion")]
    public string AppVersion { get; set; }

    /// <summary>
    /// The condition to check to enable chart
    /// </summary>
    /// <value>The condition to check to enable chart</value>
    [JsonPropertyName("condition")]
    public string Condition { get; set; }

    /// <summary>
    /// Dependencies are a list of dependencies for a chart.
    /// </summary>
    /// <value>Dependencies are a list of dependencies for a chart.</value>
    [JsonPropertyName("dependencies")]
    public List<ReleaseDependency> Dependencies { get; set; }

    /// <summary>
    /// Whether or not this chart is deprecated
    /// </summary>
    /// <value>Whether or not this chart is deprecated</value>
    [JsonPropertyName("deprecated")]
    public bool? Deprecated { get; set; }

    /// <summary>
    /// A one-sentence description of the chart
    /// </summary>
    /// <value>A one-sentence description of the chart</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The URL to a relevant project page, git repo, or contact person
    /// </summary>
    /// <value>The URL to a relevant project page, git repo, or contact person</value>
    [JsonPropertyName("home")]
    public string Home { get; set; }

    /// <summary>
    /// The URL to an icon file.
    /// </summary>
    /// <value>The URL to an icon file.</value>
    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    /// <summary>
    /// A list of string keywords
    /// </summary>
    /// <value>A list of string keywords</value>
    [JsonPropertyName("keywords")]
    public List<string> Keywords { get; set; }

    /// <summary>
    /// KubeVersion is a SemVer constraint specifying the version of Kubernetes required.
    /// </summary>
    /// <value>KubeVersion is a SemVer constraint specifying the version of Kubernetes required.</value>
    [JsonPropertyName("kubeVersion")]
    public string KubeVersion { get; set; }

    /// <summary>
    /// A list of name and URL/email address combinations for the maintainer(s)
    /// </summary>
    /// <value>A list of name and URL/email address combinations for the maintainer(s)</value>
    [JsonPropertyName("maintainers")]
    public List<ReleaseMaintainer> Maintainers { get; set; }

    /// <summary>
    /// The name of the chart. Required.
    /// </summary>
    /// <value>The name of the chart. Required.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Source is the URL to the source code of this chart
    /// </summary>
    /// <value>Source is the URL to the source code of this chart</value>
    [JsonPropertyName("sources")]
    public List<string> Sources { get; set; }

    /// <summary>
    /// The tags to check to enable chart
    /// </summary>
    /// <value>The tags to check to enable chart</value>
    [JsonPropertyName("tags")]
    public string Tags { get; set; }

    /// <summary>
    /// Specifies the chart type: application or library
    /// </summary>
    /// <value>Specifies the chart type: application or library</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// A SemVer 2 conformant version string of the chart. Required.
    /// </summary>
    /// <value>A SemVer 2 conformant version string of the chart. Required.</value>
    [JsonPropertyName("version")]
    public string Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class ReleaseMetadata {\n");
        sb.Append("  Annotations: ").Append(Annotations).Append("\n");
        sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
        sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
        sb.Append("  Condition: ").Append(Condition).Append("\n");
        sb.Append("  Dependencies: ").Append(Dependencies).Append("\n");
        sb.Append("  Deprecated: ").Append(Deprecated).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Home: ").Append(Home).Append("\n");
        sb.Append("  Icon: ").Append(Icon).Append("\n");
        sb.Append("  Keywords: ").Append(Keywords).Append("\n");
        sb.Append("  KubeVersion: ").Append(KubeVersion).Append("\n");
        sb.Append("  Maintainers: ").Append(Maintainers).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Sources: ").Append(Sources).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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