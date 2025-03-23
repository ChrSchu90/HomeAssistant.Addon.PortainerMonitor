#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text.Json.Serialization;

/// <summary>
/// 
/// </summary>
public class KubernetesConfiguration {
    /// <summary>
    /// Gets or Sets ConfigurationOwner
    /// </summary>
    [JsonPropertyName("ConfigurationOwner")]
    public string ConfigurationOwner { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [JsonPropertyName("Data")]
    public Dictionary<string, string> Data { get; set; }

    /// <summary>
    /// Gets or Sets Kind
    /// </summary>
    [JsonPropertyName("Kind")]
    public string Kind { get; set; }
}