#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

public class DockerContainer
{
    [JsonPropertyName("Command")]
    public string Command { get; set; }

    [JsonPropertyName("Created")]
    public int? Created { get; set; }

    [JsonIgnore]
    public DateTimeOffset CreatedTime => DateTimeOffset.FromUnixTimeSeconds(Created ?? 0);

    //[JsonPropertyName("HostConfig")]
    //public HostConfig HostConfig { get; set; }

    [JsonPropertyName("Id")]
    public string Id { get; set; }

    [JsonPropertyName("Image")]
    public string Image { get; set; }

    [JsonPropertyName("ImageID")]
    public string ImageID { get; set; }

    [JsonPropertyName("IsPortainer")]
    public bool? IsPortainer { get; set; }

    [JsonPropertyName("Labels")]
    public Labels Labels { get; set; }

    //[JsonPropertyName("Mounts")]
    //public List<Mount> Mounts { get; set; }

    [JsonPropertyName("Names")]
    public List<string> Names { get; set; }

    //[JsonPropertyName("NetworkSettings")]
    //public NetworkSettings NetworkSettings { get; set; }

    //[JsonPropertyName("Ports")]
    //public List<Port> Ports { get; set; }

    [JsonPropertyName("State"), JsonConverter(typeof(JsonStringEnumConverter))]
    public ContainerState State { get; set; }

    [JsonPropertyName("Status")]
    public string Status { get; set; }
}

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

public class Bridge
{
    [JsonPropertyName("Aliases")]
    public object Aliases { get; set; }

    [JsonPropertyName("DNSNames")]
    public object DNSNames { get; set; }

    [JsonPropertyName("DriverOpts")]
    public object DriverOpts { get; set; }

    [JsonPropertyName("EndpointID")]
    public string EndpointID { get; set; }

    [JsonPropertyName("Gateway")]
    public string Gateway { get; set; }

    [JsonPropertyName("GlobalIPv6Address")]
    public string GlobalIPv6Address { get; set; }

    [JsonPropertyName("GlobalIPv6PrefixLen")]
    public int? GlobalIPv6PrefixLen { get; set; }

    [JsonPropertyName("IPAddress")]
    public string IPAddress { get; set; }

    [JsonPropertyName("IPAMConfig")]
    public object IPAMConfig { get; set; }

    [JsonPropertyName("IPPrefixLen")]
    public int? IPPrefixLen { get; set; }

    [JsonPropertyName("IPv6Gateway")]
    public string IPv6Gateway { get; set; }

    [JsonPropertyName("Links")]
    public object Links { get; set; }

    [JsonPropertyName("MacAddress")]
    public string MacAddress { get; set; }

    [JsonPropertyName("NetworkID")]
    public string NetworkID { get; set; }
}

public class HostConfig
{
    [JsonPropertyName("NetworkMode")]
    public string NetworkMode { get; set; }
}

public class Labels
{
    [JsonPropertyName("com.docker.desktop.extension.icon")]
    public string? Icon { get; set; }

    [JsonPropertyName("com.docker.extension.detailed-description")]
    public string? Description { get; set; }

    [JsonPropertyName("com.docker.extension.publisher-url")]
    public string? PublisherUrl { get; set; }

    [JsonPropertyName("io.portainer.server")]
    public string? IsPortainerServer { get; set; }

    [JsonPropertyName("org.opencontainers.image.description")]
    public string? ImageDescription { get; set; }

    [JsonPropertyName("org.opencontainers.image.title")]
    public string? ImageTitle { get; set; }

    [JsonPropertyName("org.opencontainers.image.vendor")]
    public string? ImageVendor { get; set; }
}

public class Mount
{
    [JsonPropertyName("Destination")]
    public string Destination { get; set; }

    [JsonPropertyName("Driver")]
    public string Driver { get; set; }

    [JsonPropertyName("Mode")]
    public string Mode { get; set; }

    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonPropertyName("Propagation")]
    public string? Propagation { get; set; }

    [JsonPropertyName("RW")]
    public bool? RW { get; set; }

    [JsonPropertyName("Source")]
    public string Source { get; set; }

    [JsonPropertyName("Type")]
    public string Type { get; set; }
}

public class Networks
{
    [JsonPropertyName("bridge")]
    public Bridge bridge { get; set; }
}

public class NetworkSettings
{
    [JsonPropertyName("Networks")]
    public Networks Networks { get; set; }
}

public class Port
{
    [JsonPropertyName("IP")]
    public string IP { get; set; }

    [JsonPropertyName("PrivatePort")]
    public int? PrivatePort { get; set; }

    [JsonPropertyName("PublicPort")]
    public int? PublicPort { get; set; }

    [JsonPropertyName("Type")]
    public string Type { get; set; }
}