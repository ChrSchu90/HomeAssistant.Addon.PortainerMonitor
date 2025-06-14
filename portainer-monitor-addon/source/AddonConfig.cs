﻿namespace HomeAssistant.Addon.PortainerMonitor;

using HomeAssistant.Addon.PortainerMonitor.Mqtt;
using HomeAssistant.Addon.PortainerMonitor.Portainer;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

/// <summary>
/// Addon YAML config
/// </summary>
public class AddonConfig : IMqttConfig
{
    #region Private Static Fields

    #endregion

    #region Private Fields

    #endregion

    #region Constructors

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the log level yaml sting, use <see cref="LogEventLevel"/> for converted value.
    /// </summary>
    public LogEventLevel LogLevel { get; set; } = LogEventLevel.Information;

    /// <summary>
    /// Gets or sets the update interval in seconds.
    /// </summary>
    public ushort UpdateInterval { get; set; } = 5;

    /// <inheritdoc />
    public string MqttHost { get; set; } = "127.0.0.1";

    /// <inheritdoc />
    public ushort MqttPort { get; set; } = 1883;

    /// <inheritdoc />
    public string MqttUser { get; set; } = string.Empty;

    /// <inheritdoc />
    public string MqttPassword { get; set; } = string.Empty;

    /// <inheritdoc />
    public bool MqttTlsEnabled { get; set; } = false;

    /// <inheritdoc />
    public bool MqttTlsValidate { get; set; } = false;

    /// <summary>
    /// Gets or sets the portainer configurations.
    /// </summary>
    public List<PortainerConfig> PortainerConfigs { get; set; } = [];
    
    /// <summary>
    /// Gets or sets the portainer agent configurations.
    /// </summary>
    public List<AgentConfig> AgentConfigs { get; set; } = [];
    
    #endregion

    #region Public Methods

    /// <summary>
    /// Loads the configuration from a file.
    /// </summary>
    /// <param name="fullFileName">Full name of the file.</param>
    /// <returns>The configuration</returns>
    public static AddonConfig FromFile(string fullFileName)
    {
        return FromText(File.ReadAllText(fullFileName));
    }

    /// <summary>
    /// Loads the configuration from a <see cref="string"/>.
    /// </summary>
    /// <param name="content">The yaml string.</param>
    /// <returns>The configuration</returns>
    public static AddonConfig FromText(string content)
    {
        var config = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build()
            .Deserialize<AddonConfig>(content);

        return config;
    }

    /// <summary>
    /// Converts the configuration into a yaml <see cref="string"/>.
    /// </summary>
    /// <returns>The yaml string</returns>
    public string ToYaml()
    {
        return new SerializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build()
            .Serialize(this);
    }

    /// <summary>
    /// Converts the configuration into a json <see cref="string"/>.
    /// </summary>
    /// <returns>The yaml string</returns>
    public string ToJson()
    {
        return new SerializerBuilder()
            .JsonCompatible()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build()
            .Serialize(this);
    }

    /// <summary>
    /// Validates the configuration and throws a <see cref="ConfigException"/> if invalid with error information.
    /// </summary>
    public void Validate()
    {
        // General Settings
        if (UpdateInterval < 1) throw new ConfigException("`update_interval` needs to be at least `1` second");

        // MQTT Settings
        if (string.IsNullOrWhiteSpace(MqttHost)) throw new ConfigException("`mqtt_host` needs to be defined by IP or hostname");
        if (MqttPort < 1) throw new ConfigException("`mqtt_port` needs to be at least `1`");

        // Portainer/Agent configs
        if(!PortainerConfigs.Any() && !AgentConfigs.Any()) throw new ConfigException("`portainer_configs` and `agent_configs` is empty, at least `1` has to be defined");
        foreach (var config in PortainerConfigs) { config.Validate(); }
        foreach (var config in AgentConfigs) { config.Validate(); }
    }

    #endregion

    #region Private Methods

    #endregion
}

/// <summary>
/// Portainer configuration
/// </summary>
public class PortainerConfig : IPortainerConfig
{
    #region Private Static Fields

    #endregion

    #region Private Fields

    #endregion

    #region Constructors

    #endregion

    #region Properties

    /// <inheritdoc />
    public string Id { get; set; } = null!;

    /// <inheritdoc />
    public string DisplayName { get; set; } = "Portainer";

    /// <inheritdoc />
    public string Host { get; set; } = "127.0.0.1";

    /// <inheritdoc />
    public ushort Port { get; set; } = 9443;

    /// <inheritdoc />
    public string Token { get; set; } = string.Empty;

    /// <inheritdoc />
    public bool TlsEnabled { get; set; } = true;

    /// <inheritdoc />
    public bool TlsValidate { get; set; } = false;

    /// <inheritdoc />
    public bool ContainerCommands { get; set; } = true;

    /// <inheritdoc />
    public bool ContainerStateMonitoring { get; set; } = true;

    /// <inheritdoc />
    public bool ContainerCpuMonitoring { get; set; } = true;

    /// <inheritdoc />
    public bool ContainerRamMonitoring { get; set; } = true;

    /// <inheritdoc />
    public bool ContainerNetworkMonitoring { get; set; } = true;

    #endregion

    #region Public Methods

    /// <summary>
    /// Validates the configuration and throws a <see cref="ConfigException"/> if invalid with error information.
    /// </summary>
    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(Id)) throw new ConfigException($"Portainer `id` of `{Id}` needs to be defined for identification");
        if (string.IsNullOrWhiteSpace(Host)) throw new ConfigException($"Portainer `host` of `{Id}` needs to be defined");
        if (string.IsNullOrWhiteSpace(DisplayName)) throw new ConfigException($"Portainer `display_name` of `{Id}` needs to be defined");
        if (Port < 1) throw new ConfigException($"Portainer `port` of `{Id}` needs to be at least `1`");
        if (string.IsNullOrWhiteSpace(Token)) throw new ConfigException($"Portainer `token` of `{Id}` needs to be defined");
    }

    #endregion

    #region Private Methods

    #endregion
}

/// <summary>
/// Portainer Agent configuration
/// </summary>
public class AgentConfig : IAgentConfig
{
    #region Private Static Fields

    #endregion

    #region Private Fields

    #endregion

    #region Constructors

    #endregion

    #region Properties

    /// <inheritdoc />
    public string Id { get; set; } = null!;

    /// <inheritdoc />
    public string DisplayName { get; set; } = "Agent";

    /// <inheritdoc />
    public string Host { get; set; } = "127.0.0.1";

    /// <inheritdoc />
    public ushort Port { get; set; } = 9001;

    /// <inheritdoc />
    public string Secret { get; set; } = null!;

    /// <inheritdoc />
    public bool TlsEnabled { get; set; } = true;

    /// <inheritdoc />
    public bool TlsValidate { get; set; } = false;

    /// <inheritdoc />
    public bool ContainerCommands { get; set; } = true;

    /// <inheritdoc />
    public bool ContainerStateMonitoring { get; set; } = true;

    /// <inheritdoc />
    public bool ContainerCpuMonitoring { get; set; } = true;

    /// <inheritdoc />
    public bool ContainerRamMonitoring { get; set; } = true;

    /// <inheritdoc />
    public bool ContainerNetworkMonitoring { get; set; } = true;

    #endregion

    #region Public Methods

    /// <summary>
    /// Validates the configuration and throws a <see cref="ConfigException"/> if invalid with error information.
    /// </summary>
    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(Id)) throw new ConfigException($"Agent `id` of `{DisplayName}` needs to be defined");
        if (string.IsNullOrWhiteSpace(Host)) throw new ConfigException($"Agent `host` of `{Id}` needs to be defined");
        if (string.IsNullOrWhiteSpace(DisplayName)) throw new ConfigException($"Agent `display_name` of `{Id}` needs to be defined");
        if (string.IsNullOrWhiteSpace(Secret)) throw new ConfigException($"Agent `secret` of `{Id}` needs to be defined");
        if (Port < 1) throw new ConfigException($"Agent `port` of `{Id}` needs to be at least `1`");
    }

    #endregion

    #region Private Methods

    #endregion
}

/// <summary>
/// Config exception
/// </summary>
/// <seealso cref="Exception" />
public class ConfigException(string message) : Exception(message);