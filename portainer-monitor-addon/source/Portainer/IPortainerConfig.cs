namespace HomeAssistant.Addon.PortainerMonitor.Portainer;

/// <summary>
/// Portainer Configuration
/// </summary>
interface IPortainerConfig
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
    /// Gets the portainer API token.
    /// </summary>
    string Token { get; }

    /// <summary>
    /// Gets a value indicating whether TLS is enabled.
    /// </summary>
    bool TlsEnabled { get; }

    /// <summary>
    /// Gets a value indicating whether TLS cert needs to be valid.
    /// </summary>
    bool TlsValidate { get; }

    #endregion

    #region Methods

    #endregion
}