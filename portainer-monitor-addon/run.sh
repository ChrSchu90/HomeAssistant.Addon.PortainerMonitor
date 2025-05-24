#!/usr/bin/with-contenv bashio

if [[ -v PORTAINER_MONITOR_CONFIG ]]; then
    echo "Portainer Monitor is starting in standalone mode..."
    ./HomeAssistant.Addon.PortainerMonitor
else
    echo "Portainer Monitor is starting in supervised mode..."
    MqttUser=$(bashio::services "mqtt" "username")
    MqttPw=$(bashio::services "mqtt" "password")
    MqttHost=$(bashio::services "mqtt" "host")
    MqttPort=$(bashio::services "mqtt" "port")
    ./HomeAssistant.Addon.PortainerMonitor --mqttuser "${MqttUser}" --mqttpw "${MqttPw}" --mqtthost "${MqttHost}" --mqttport "${MqttPort}"
fi