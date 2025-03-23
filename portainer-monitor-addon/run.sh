#!/usr/bin/with-contenv bashio

MqttUser=$(bashio::services "mqtt" "username")
MqttPw=$(bashio::services "mqtt" "password")
MqttHost=$(bashio::services "mqtt" "host")
MqttPort=$(bashio::services "mqtt" "port")

./HomeAssistant.Addon.PortainerMonitor --mqttuser "${MqttUser}" --mqttpw "${MqttPw}" --mqtthost "${MqttHost}" --mqttport "${MqttPort}"