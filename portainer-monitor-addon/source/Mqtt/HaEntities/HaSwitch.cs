namespace HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MQTTnet.Internal;
using YamlDotNet.Core.Tokens;

/// <summary>
/// Home Assistant toggle switch entity
/// </summary>
internal class HaSwitch : HaEntityBase
{
    #region Static Fields

    private const string SwitchStateTopic = "homeassistant/switch/{0}/state";
    private const string SwitchCommandTopic = "homeassistant/switch/{0}/set";
    private const string SwitchConfigTopic = "homeassistant/switch/{0}/config";

    #endregion

    #region Private Fields

    private readonly AsyncEvent<SwitchCommandReceivedEventArgs> _switchCommandReceived = new();
    private bool? _isChecked;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="HaSwitch" /> class.
    /// </summary>
    /// <param name="id">The full qualified entity id (e.g. abc_def_ghi_jkl).</param>
    /// <param name="displayName">The display name (e.g. Outdoor Temperature).</param>
    /// <param name="device">The root device.</param>
    /// <param name="mqttClient">The MQTT client.</param>
    internal HaSwitch(string id, string displayName, HaDevice device, IMqttClient mqttClient)
        : base(id, displayName, device, mqttClient)
    {
        ConfigTopic = string.Format(SwitchConfigTopic, ID);
        StateTopic = string.Format(SwitchStateTopic, ID);
        CommandTopic = string.Format(SwitchCommandTopic, ID);
    }

    #endregion

    #region Events

    /// <summary>
    /// Occurs when a switch command has been sent from Home Assistant (toggle).
    /// </summary>
    internal event Func<SwitchCommandReceivedEventArgs, Task> SwitchCommandReceived
    {
        add => _switchCommandReceived.AddHandler(value);
        remove => _switchCommandReceived.RemoveHandler(value);
    }

    #endregion

    #region Properties

    /// <summary>
    /// The payload that represents on state.
    /// If specified, will be used for both comparing to the value in the state_topic (see value_template and state_on for details) and sending as on command to the command_topic.
    /// </summary>
    [JsonPropertyName("payload_on"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string PayloadOn { get; set; } = HaStates.STATE_ON;

    /// <summary>
    /// The payload that represents off state.
    /// If specified, will be used for both comparing to the value in the state_topic (see value_template and state_off for details) and sending as off command to the command_topic.
    /// </summary>
    [JsonPropertyName("payload_off"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string PayloadOff { get; set; } = HaStates.STATE_OFF;

    /// <summary>
    /// The payload that represents the on state.
    /// Used when value that represents on state in the state_topic is different from value that should be sent to the command_topic to turn the device on.
    /// </summary>
    [JsonPropertyName("state_on"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string StateOn { get; set; } = HaStates.STATE_ON;

    /// <summary>
    /// The payload that represents the off state.
    /// Used when value that represents off state in the state_topic is different from value that should be sent to the command_topic to turn the device off.
    /// </summary>
    [JsonPropertyName("state_off"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string StateOff { get; set; } = HaStates.STATE_OFF;

    /// <summary>
    /// Flag that defines if switch works in optimistic mode.
    /// </summary>
    [JsonPropertyName("optimistic"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? IsOptimistic { get; set; }

    /// <summary>
    /// Gets or sets the state of the switch.
    /// </summary>
    [JsonIgnore]
    internal bool IsChecked
    {
        get => _isChecked.GetValueOrDefault(false);
        set
        {
            if (_isChecked == value || IsCommandProcessingActive) return;
            _isChecked = value;
            OnStateChanged();
        }
    }

    /// <summary>
    /// Gets a value indicating whether the switch has a <see cref="SwitchCommandReceived"/>
    /// and is blocking the setting of <seealso cref="IsChecked"/> to prevent unwanted toggles.
    /// </summary>
    [JsonIgnore]
    internal bool IsCommandProcessingActive { get; private set; }

    #endregion

    #region Public Methods

    /// <inheritdoc />
    protected override string GetConfigMqttPayload() => JsonSerializer.Serialize(this);

    /// <inheritdoc />
    protected override string GetStateMqttPayload() => IsChecked ? StateOn : StateOff;

    /// <inheritdoc />
    protected override string GetCommandMqttPayload() => IsChecked ? PayloadOn : PayloadOff;

    /// <inheritdoc />
    protected override async Task OnCommandMessageReceivedAsync(MqttMessageEventArgs e)
    {
        try
        {
            if (IsCommandProcessingActive)
            {
                await SendStateAsync(true).ConfigureAwait(false);
                return;
            }

            IsCommandProcessingActive = true;
            await base.OnCommandMessageReceivedAsync(e).ConfigureAwait(false);
            var isChecked = string.Equals(e.MessageContent, PayloadOn, StringComparison.OrdinalIgnoreCase);
            _isChecked = isChecked;
            await SendStateAsync(true).ConfigureAwait(false);
            await OnSwitchCommandReceived(this, isChecked).ConfigureAwait(false);
        }
        finally
        {
            IsCommandProcessingActive = false;
        }
    }

    /// <summary>
    /// Raises the <see cref="SwitchCommandReceived"/> event.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="commandValue">The new command value (<see cref="IsChecked"/>).</param>
    /// <returns></returns>
    protected virtual Task OnSwitchCommandReceived(HaSwitch sender, bool commandValue)
    {
        return _switchCommandReceived.HasHandlers ?
                   _switchCommandReceived.InvokeAsync(new SwitchCommandReceivedEventArgs(sender, commandValue)) :
                   Task.CompletedTask;
    }

    /// <inheritdoc />
    protected override void OnMqttConnectionStateChanged(object? sender, bool e)
    {
        base.OnMqttConnectionStateChanged(sender, e);
        if (!IsDisposed & e)
        {
            _isChecked = null;
        }
    }

    /// <inheritdoc />
    protected override void OnHomeAssistantAvailabilityChanged(object? sender, bool e)
    {
        base.OnHomeAssistantAvailabilityChanged(sender, e);
        if (!IsDisposed && e)
        {
            _isChecked = null;
        }
    }

    #endregion

    #region Private Methods

    #endregion
}

/// <summary>
/// Switch Command Received EventArgs
/// </summary>
internal class SwitchCommandReceivedEventArgs(HaSwitch _switch, bool _commandValue) : EventArgs
{
    /// <summary>
    /// Gets the switch.
    /// </summary>
    internal HaSwitch Switch => _switch;

    /// <summary>
    /// Gets the command value.
    /// </summary>
    internal bool CommandValue => _commandValue;
}