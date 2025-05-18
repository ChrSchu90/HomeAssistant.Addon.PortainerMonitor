namespace HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

/// <summary>
/// Container resource stats
/// </summary>
public class ContainerStats
{
    /// <summary>
    /// Gets the current CPU stats.
    /// </summary>
    [JsonPropertyName("cpu_stats")]
    public CpuStats CurrentCpuStats { get; set; } = null!;

    /// <summary>
    /// Gets the read timestamp.
    /// </summary>
    [JsonPropertyName("read")]
    public DateTimeOffset Read { get; set; }

    /// <summary>
    /// Gets the memory stats.
    /// </summary>
    [JsonPropertyName("memory_stats")]
    public MemoryStats MemoryStats { get; set; } = null!;

    /// <summary>
    /// Gets the network stats.
    /// </summary>
    [JsonPropertyName("networks")]
    public Dictionary<string, NetworkStats> NetworkStats { get; set; } = new();
}

/// <summary>
/// Container CPU stats
/// </summary>
public class CpuStats
{
    /// <summary>
    /// Gets the container CPU usage information.
    /// </summary>
    [JsonPropertyName("cpu_usage")]
    public CpuUsage CpuUsage { get; set; } = null!;

    /// <summary>
    /// Gets the CPU core count.
    /// </summary>
    [JsonPropertyName("online_cpus")]
    public ushort CoreCount { get; set; }

    /// <summary>
    /// Gets the system usage.
    /// </summary>
    [JsonPropertyName("system_cpu_usage")]
    public ulong SystemUsage { get; set; }
}

/// <summary>
/// CPU usage information
/// </summary>
public class CpuUsage
{
    /// <summary>
    /// Gets the total usage.
    /// </summary>
    [JsonPropertyName("total_usage")]
    public ulong Total { get; set; }

    /// <summary>
    /// Gets the kernel usage.
    /// </summary>
    [JsonPropertyName("usage_in_kernelmode")]
    public ulong Kernel { get; set; }

    /// <summary>
    /// Gets the user usage.
    /// </summary>
    [JsonPropertyName("usage_in_usermode")]
    public ulong User { get; set; }
}

/// <summary>
/// Container memory stats
/// </summary>
public class MemoryStats
{
    /// <summary>
    /// Gets or sets the available memory.
    /// </summary>
    [JsonPropertyName("limit")]
    public ulong MaxMemoryBytes { get; set; }

    /// <summary>
    /// Gets or sets the used memory.
    /// </summary>
    [JsonPropertyName("usage")]
    public ulong UsedMemoryBytes { get; set; }
}

/// <summary>
/// Container network stats
/// </summary>
public class NetworkStats
{
    /// <summary>
    /// Gets the RX (downloaded).
    /// </summary>
    [JsonPropertyName("rx_bytes")]
    public ulong RxBytes { get; set; }

    /// <summary>
    /// Gets the TX (uploaded).
    /// </summary>
    [JsonPropertyName("tx_bytes")]
    public ulong TxBytes { get; set; }
}