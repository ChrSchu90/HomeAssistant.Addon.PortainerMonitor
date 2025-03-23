namespace HomeAssistant.Addon.PortainerMonitor.Mqtt;

/// <summary>
/// MQTT Configuration
/// </summary>
public interface IMqttConfig
{
    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets the host address or name.
    /// </summary>
    public string MqttHost { get; }

    /// <summary>
    /// Gets the port.
    /// </summary>
    public ushort MqttPort { get; }

    /// <summary>
    /// Gets the user.
    /// </summary>
    public string MqttUser { get; }

    /// <summary>
    /// Gets the password.
    /// </summary>
    public string MqttPassword { get; }

    /// <summary>
    /// Gets a value indicating whether TLS is enabled.
    /// </summary>
    public bool MqttTlsEnabled { get; }

    /// <summary>
    /// Gets a value indicating whether TLS cert needs to be valid.
    /// </summary>
    public bool MqttTlsValidate { get; }

    #endregion

    #region Methods

    #endregion
}