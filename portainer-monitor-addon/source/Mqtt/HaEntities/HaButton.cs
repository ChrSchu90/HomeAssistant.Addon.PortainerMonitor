namespace HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;

using System;
using System.Text.Json;
using System.Threading.Tasks;
using MQTTnet.Internal;

/// <summary>
/// Home Assistant toggle switch entity
/// </summary>
internal class HaButton : HaEntityBase
{
    #region Static Fields

    private const string ButtonCommandTopic = "homeassistant/button/{0}/set";
    private const string ButtonConfigTopic = "homeassistant/button/{0}/config";

    #endregion

    #region Private Fields

    private readonly AsyncEvent<ButtonCommandReceivedEventArgs> _buttonCommandReceived = new();

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="HaButton" /> class.
    /// </summary>
    /// <param name="id">The full qualified entity id (e.g. abc_def_ghi_jkl).</param>
    /// <param name="displayName">The display name (e.g. Outdoor Temperature).</param>
    /// <param name="device">The root device.</param>
    /// <param name="mqttClient">The MQTT client.</param>
    internal HaButton(string id, string displayName, HaDevice device, IMqttClient mqttClient)
        : base(id, displayName, device, mqttClient)
    {
        ConfigTopic = string.Format(ButtonConfigTopic, ID);
        CommandTopic = string.Format(ButtonCommandTopic, ID);
    }

    #endregion

    #region Events

    /// <summary>
    /// Occurs when a button command has been sent from Home Assistant (click).
    /// </summary>
    internal event Func<ButtonCommandReceivedEventArgs, Task> ButtonCommandReceived
    {
        add => _buttonCommandReceived.AddHandler(value);
        remove => _buttonCommandReceived.RemoveHandler(value);
    }

    #endregion

    #region Properties

    #endregion

    #region Public Methods

    /// <inheritdoc />
    protected override string GetConfigMqttPayload() => JsonSerializer.Serialize(this);

    /// <inheritdoc />
    protected override string? GetCommandMqttPayload() => null;

    /// <inheritdoc />
    protected override async Task OnCommandMessageReceivedAsync(MqttMessageEventArgs e)
    {
        await base.OnCommandMessageReceivedAsync(e).ConfigureAwait(false);
        await OnSwitchCommandReceived(this, e.MessageContent!).ConfigureAwait(false);
    }

    /// <summary>
    /// Raises the <see cref="ButtonCommandReceived" /> event.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="message">The message.</param>
    protected virtual Task OnSwitchCommandReceived(HaButton sender, string message)
    {
        return _buttonCommandReceived.HasHandlers ?
                   _buttonCommandReceived.InvokeAsync(new ButtonCommandReceivedEventArgs(sender, message)) :
                   Task.CompletedTask;
    }

    #endregion

    #region Private Methods

    #endregion
}

/// <summary>
/// Button Command Received EventArgs
/// </summary>
internal class ButtonCommandReceivedEventArgs(HaButton _button, string _command) : EventArgs
{
    /// <summary>
    /// Gets the button.
    /// </summary>
    internal HaButton Button => _button;

    /// <summary>
    /// Gets the command message.
    /// </summary>
    internal string Command => _command;
}