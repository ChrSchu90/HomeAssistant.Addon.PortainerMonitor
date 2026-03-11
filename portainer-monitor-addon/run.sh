#!/usr/bin/with-contenv bashio

if [[ -v PORTAINER_MONITOR_CONFIG ]]; then
    echo "Portainer Monitor is starting in standalone mode..."
    exec /HomeAssistant.Addon.PortainerMonitor
else
    echo "Portainer Monitor is starting in supervised mode..."
    MqttUser=$(bashio::services "mqtt" "username")
    MqttPw=$(bashio::services "mqtt" "password")
    MqttHost=$(bashio::services "mqtt" "host")
    MqttPort=$(bashio::services "mqtt" "port")
    exec /HomeAssistant.Addon.PortainerMonitor --mqtt-user "${MqttUser}" --mqtt-password "${MqttPw}" --mqtt-host "${MqttHost}" --mqtt-port "${MqttPort}"
fi
