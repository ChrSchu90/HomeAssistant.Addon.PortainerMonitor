namespace HomeAssistant.Addon.PortainerMonitor.Portainer;

/// <summary>
/// Shared Portainer connection config for <see cref="IPortainerConfig"/> and <see cref="IAgentConfig"/>
/// </summary>
public interface IConnectionConfig
{
    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets the name of the portainer instance.
    /// </summary>
    string Id { get; }

    /// <summary>
    /// Gets the display name.
    /// </summary>
    string DisplayName { get; }

    /// <summary>
    /// Gets the host.
    /// </summary>
    string Host { get; }

    /// <summary>
    /// Gets the port.
    /// </summary>
    ushort Port { get; }

    /// <summary>
    /// Gets a value indicating whether TLS is enabled.
    /// </summary>
    bool TlsEnabled { get; }

    /// <summary>
    /// Gets a value indicating whether TLS cert needs to be valid.
    /// </summary>
    bool TlsValidate { get; }

    /// <summary>
    /// Gets a value indicating whether container commands (start, stop etc.) should be available.
    /// </summary>
    bool ContainerCommands { get; }

    /// <summary>
    /// Gets a value indicating whether container state should be available.
    /// </summary>
    bool ContainerStateMonitoring { get; }

    /// <summary>
    /// Gets a value indicating whether container CPU monitoring should be available.
    /// </summary>
    bool ContainerCpuMonitoring { get; }

    /// <summary>
    /// Gets a value indicating whether container RAM monitoring should be available.
    /// </summary>
    bool ContainerRamMonitoring { get; }

    /// <summary>
    /// Gets a value indicating whether container network monitoring should be available.
    /// </summary>
    bool ContainerNetworkMonitoring { get; }

    #endregion

    #region Methods

    #endregion
}

/// <summary>
/// Portainer connection configuration
/// </summary>
public interface IPortainerConfig : IConnectionConfig
{
    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets the portainer API token.
    /// </summary>
    string Token { get; }

    #endregion

    #region Methods

    #endregion
}

/// <summary>
/// Portainer Agent connection configuration
/// </summary>
public interface IAgentConfig : IConnectionConfig
{
    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets the agent secret.
    /// </summary>
    string? Secret { get; }

    #endregion

    #region Methods

    #endregion
}