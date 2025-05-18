namespace HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

/// <summary>
/// Docker container information
/// </summary>
public class DockerContainer
{
    /// <summary>
    /// Gets the created unix timestamp.
    /// </summary>
    /// <remarks>Use the <see cref="CreatedTime"/> as parsed datetime</remarks>
    [JsonPropertyName("Created")]
    public int? Created { get; set; }

    /// <summary>
    /// Gets the container creation time.
    /// </summary>
    /// <remarks>Parsed timestamp from <see cref="Created"/> unix timestamp</remarks>
    [JsonIgnore]
    public DateTimeOffset CreatedTime => DateTimeOffset.FromUnixTimeSeconds(Created ?? 0);

    /// <summary>
    /// Gets the unique container identifier.
    /// </summary>
    [JsonPropertyName("Id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the container image.
    /// </summary>
    [JsonPropertyName("Image")]
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// Gets the container image identifier.
    /// </summary>
    [JsonPropertyName("ImageID")]
    public string ImageID { get; set; } = string.Empty;

    /// <summary>
    /// Gets the container names.
    /// </summary>
    [JsonPropertyName("Names")]
    public List<string> Names { get; set; } = new();

    /// <summary>
    /// Gets the container state.
    /// </summary>
    [JsonPropertyName("State"), JsonConverter(typeof(JsonStringEnumConverter))]
    public ContainerState State { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"Container {Names.FirstOrDefault(n => !string.IsNullOrWhiteSpace(n))} ({State}) [{Id}]";
    }
}

/// <summary>
/// Container state
/// </summary>
public enum ContainerState
{
    /// <summary>
    /// A container that has never been started.
    /// </summary>
    [EnumMember(Value = "created")] Created,

    /// <summary>
    /// A container which is starting due to the designated restart policy for that container.
    /// </summary>
    [EnumMember(Value = "restarting")] Restarting,

    /// <summary>
    /// A running container, started by either docker start or docker run.
    /// </summary>
    [EnumMember(Value = "running")] Running,

    /// <summary>
    /// A container which is in the process of being removed. See docker rm.
    /// </summary>
    [EnumMember(Value = "removing")] Removing,

    /// <summary>
    /// A paused container.
    /// </summary>
    [EnumMember(Value = "paused")] Paused,

    /// <summary>
    /// A container which is no longer running. For example, the process inside the container completed or the container was stopped using the docker stop command.
    /// </summary>
    [EnumMember(Value = "exited")] Exited,

    /// <summary>
    /// A "defunct" container; for example, a container that was only partially removed because resources were kept busy by an external process. dead containers cannot be (re)started, only removed.
    /// </summary>
    [EnumMember(Value = "dead")] Dead
}