namespace HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

/// <summary>
/// Container resource stats
/// </summary>
public record ContainerStats
{
    /// <summary>
    /// Gets the current CPU stats.
    /// </summary>
    [JsonPropertyName("cpu_stats")]
    public CpuStats CurrentCpuStats { get; init; } = null!;

    /// <summary>
    /// Gets the read timestamp.
    /// </summary>
    [JsonPropertyName("read")]
    public DateTimeOffset Read { get; init; }

    /// <summary>
    /// Gets the memory stats.
    /// </summary>
    [JsonPropertyName("memory_stats")]
    public MemoryStats MemoryStats { get; init; } = null!;

    /// <summary>
    /// Gets the network stats.
    /// </summary>
    [JsonPropertyName("networks")]
    public Dictionary<string, NetworkStats> NetworkStats { get; init; } = new();
}

/// <summary>
/// Container CPU stats
/// </summary>
public record CpuStats
{
    /// <summary>
    /// Gets the container CPU usage information.
    /// </summary>
    [JsonPropertyName("cpu_usage")]
    public CpuUsage CpuUsage { get; init; } = null!;

    /// <summary>
    /// Gets the CPU core count.
    /// </summary>
    [JsonPropertyName("online_cpus")]
    public ushort CoreCount { get; init; }

    /// <summary>
    /// Gets the system usage.
    /// </summary>
    [JsonPropertyName("system_cpu_usage")]
    public ulong SystemUsage { get; init; }
}

/// <summary>
/// CPU usage information
/// </summary>
public record CpuUsage
{
    /// <summary>
    /// Gets the total usage.
    /// </summary>
    [JsonPropertyName("total_usage")]
    public ulong Total { get; init; }

    /// <summary>
    /// Gets the kernel usage.
    /// </summary>
    [JsonPropertyName("usage_in_kernelmode")]
    public ulong Kernel { get; init; }

    /// <summary>
    /// Gets the user usage.
    /// </summary>
    [JsonPropertyName("usage_in_usermode")]
    public ulong User { get; init; }
}

/// <summary>
/// Container memory stats
/// </summary>
public record MemoryStats
{
    /// <summary>
    /// Gets the available memory.
    /// </summary>
    [JsonPropertyName("limit")]
    public ulong MaxMemoryBytes { get; init; }

    /// <summary>
    /// Gets the used memory.
    /// </summary>
    [JsonPropertyName("usage")]
    public ulong UsedMemoryBytes { get; init; }
}

/// <summary>
/// Container network stats
/// </summary>
public record NetworkStats
{
    /// <summary>
    /// Gets the RX bytes (downloaded).
    /// </summary>
    [JsonPropertyName("rx_bytes")]
    public ulong RxBytes { get; init; }

    /// <summary>
    /// Gets the TX bytes (uploaded).
    /// </summary>
    [JsonPropertyName("tx_bytes")]
    public ulong TxBytes { get; init; }
}