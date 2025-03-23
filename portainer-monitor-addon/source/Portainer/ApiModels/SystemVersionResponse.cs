#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

/// <summary>
/// 
/// </summary>
public class SystemVersionResponse
{
    /// <summary>
    /// The latest version available
    /// </summary>
    /// <value>The latest version available</value>
    [DataMember(Name = "LatestVersion", EmitDefaultValue = false)]
    [JsonPropertyName("LatestVersion")]
    public string? LatestVersion { get; set; }

    /// <summary>
    /// Gets or Sets ServerEdition
    /// </summary>
    [DataMember(Name = "ServerEdition", EmitDefaultValue = false)]
    [JsonPropertyName("ServerEdition")]
    public string ServerEdition { get; set; }

    /// <summary>
    /// Whether portainer has an update available
    /// </summary>
    /// <value>Whether portainer has an update available</value>
    [DataMember(Name = "UpdateAvailable", EmitDefaultValue = false)]
    [JsonPropertyName("UpdateAvailable")]
    public bool? UpdateAvailable { get; set; }

    /// <summary>
    /// Gets or Sets VersionSupport
    /// </summary>
    [DataMember(Name = "VersionSupport", EmitDefaultValue = false)]
    [JsonPropertyName("VersionSupport")]
    public string VersionSupport { get; set; }

    /// <summary>
    /// Gets or Sets Build
    /// </summary>
    [DataMember(Name = "build", EmitDefaultValue = false)]
    [JsonPropertyName("build")]
    public BuildBuildInfo Build { get; set; }

    /// <summary>
    /// Gets or Sets DatabaseVersion
    /// </summary>
    [DataMember(Name = "databaseVersion", EmitDefaultValue = false)]
    [JsonPropertyName("databaseVersion")]
    public string DatabaseVersion { get; set; }

    /// <summary>
    /// Gets or Sets Dependencies
    /// </summary>
    [DataMember(Name = "dependencies", EmitDefaultValue = false)]
    [JsonPropertyName("dependencies")]
    public BuildDependenciesInfo Dependencies { get; set; }

    /// <summary>
    /// Gets or Sets Runtime
    /// </summary>
    [DataMember(Name = "runtime", EmitDefaultValue = false)]
    [JsonPropertyName("runtime")]
    public BuildRuntimeInfo Runtime { get; set; }

    /// <summary>
    /// Gets or Sets ServerVersion
    /// </summary>
    [DataMember(Name = "serverVersion", EmitDefaultValue = false)]
    [JsonPropertyName("serverVersion")]
    public Version ServerVersion { get; set; }
}