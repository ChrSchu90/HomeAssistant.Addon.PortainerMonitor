namespace HomeAssistant.Addon.PortainerMonitor.Portainer;

/// <summary>
/// Portainer Agent Configuration
/// </summary>
public interface IAgentConfig
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
    /// Gets the agent secret.
    /// </summary>
    string? Secret { get; }

    /// <summary>
    /// Gets a value indicating whether TLS cert needs to be valid.
    /// </summary>
    bool TlsValidate { get; }

    #endregion

    #region Methods

    #endregion
}