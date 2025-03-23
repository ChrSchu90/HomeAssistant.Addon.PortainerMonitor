namespace HomeAssistant.Addon.PortainerMonitor.Mqtt;

/// <summary>
/// Home Assistant States see:
/// <see href="https://github.com/home-assistant/core/blob/d7ac4bd65379e11461c7ce0893d3533d8d8b8cbf/homeassistant/const.py#L384"/>
/// </summary>
public static class HaStates
{
    public const string STATE_ON = "on";
    public const string STATE_OFF = "off";
    public const string STATE_HOME = "home";
    public const string STATE_NOT_HOME = "not_home";
    public const string STATE_UNKNOWN = "unknown";
    public const string STATE_OPEN = "open";
    public const string STATE_OPENING = "opening";
    public const string STATE_CLOSED = "closed";
    public const string STATE_CLOSING = "closing";
    public const string STATE_PLAYING = "playing";
    public const string STATE_PAUSED = "paused";
    public const string STATE_IDLE = "idle";
    public const string STATE_STANDBY = "standby";
    public const string STATE_ALARM_DISARMED = "disarmed";
    public const string STATE_ALARM_ARMED_HOME = "armed_home";
    public const string STATE_ALARM_ARMED_AWAY = "armed_away";
    public const string STATE_ALARM_ARMED_NIGHT = "armed_night";
    public const string STATE_ALARM_ARMED_CUSTOM_BYPASS = "armed_custom_bypass";
    public const string STATE_ALARM_PENDING = "pending";
    public const string STATE_ALARM_ARMING = "arming";
    public const string STATE_ALARM_DISARMING = "disarming";
    public const string STATE_ALARM_TRIGGERED = "triggered";
    public const string STATE_LOCKED = "locked";
    public const string STATE_UNLOCKED = "unlocked";
    public const string STATE_UNAVAILABLE = "unavailable";
    public const string STATE_OK = "ok";
    public const string STATE_PROBLEM = "problem";
}