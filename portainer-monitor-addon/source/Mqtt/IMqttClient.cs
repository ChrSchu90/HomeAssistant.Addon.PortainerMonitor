namespace HomeAssistant.Addon.PortainerMonitor.Mqtt;

using System.Threading.Tasks;
using System;

/// <summary>
/// MQTT client access for Home Assistant communication see:
/// <see href="https://github.com/dotnet/MQTTnet/wiki/"/>
/// </summary>
internal interface IMqttClient
{
    #region Events

    /// <summary>
    /// Occurs when MQTT <see cref="IsConnected"/>e has changed.
    /// </summary>
    event EventHandler<bool> ConnectionStateChanged;

    /// <summary>
    /// Occurs when <seealso cref="IsHomeAssistantAvailable"/>changed.
    /// </summary>
    event EventHandler<bool> HomeAssistantAvailabilityChanged;

    #endregion

    #region Properties

    /// <summary>
    /// Gets a value indicating whether the MQTT client is connected.
    /// </summary>
    bool IsConnected { get; }

    /// <summary>
    /// Gets a value indicating whether home assistant available by its availability state.
    /// </summary>
    bool IsHomeAssistantAvailable { get; }

    #endregion

    #region Methods

    /// <summary>
    /// Subscribes to a topic and invokes the callback if a message got send.
    /// </summary>
    /// <param name="topic">The MQTT topic.</param>
    /// <param name="callback">The message callback.</param>
    Task SubscribeAsync(string topic, Func<MqttMessageEventArgs, Task> callback);

    /// <summary>
    /// Unsubscribes from a topic.
    /// </summary>
    /// <param name="topic">The MQTT topic.</param>
    /// <param name="callback">The message callback.</param>
    Task UnsubscribeAsync(string topic, Func<MqttMessageEventArgs, Task> callback);

    /// <summary>
    /// Publishes the specified payload of the given topic.
    /// </summary>
    /// <param name="topic">The topic.</param>
    /// <param name="payload">The payload, if <c>null</c> topic gets deleted.</param>
    public Task<bool> PublishAsync(string topic, string? payload);

    #endregion
}