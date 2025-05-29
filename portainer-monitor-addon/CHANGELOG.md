## Changelog 🚀
### 1.1.1
- Improved perfomance for resource monitoring
- Update of icon for container CPU usage sensor
- Update format of logs for better identification of host, endpoint and container

### 1.1.0
- Add container resource monitoring for `CPU usage`, `RAM usage`, `Download` and `Upload`
- Add options to enable/disable container `commands (start, stop...)`, `state monitoring`, `CPU monitoring`, `RAM monitoring` and `network monitoring`
- Fixed error in standalone addon startup due to missing HA Supervisor API

### 1.0.12
- Fixed docker version sensor

### 1.0.11
- Fixed possible `BadRequest` API errors on `Start`, `Stop`, `Pause` and `Restart` command execution
- Fixed Portainer update state
- Adjustment of log levels for container commands

### 1.0.10
- Fixed unintended container command execution

### 1.0.9
- Improved internal handling for MQTT and HA online/offline notifications
- Improved log clarity by removing unavailable containers/endpoints before adding the new ones

### 1.0.8
- Implement per host and endpoint availability
- Refactoring and performance improvements

### 1.0.7
- Fixed unintended cyclic entity state updates
- Improved handling for unavailable Portainer host
- Improved start/stop toggle handling

### 1.0.6
- Fixed unavailable entities after HA soft restart

### 1.0.5
- Improved HA entity label naming

### 1.0.4
- Add Sensors with amount of `running`, `stopped`, `paused` and `total` containers per Endpoint

### 1.0.3
- Update sensor, switch and button icons

### 1.0.2
- Add `Docker Version` sensor for each Endpoint
- Changed update label of Portainer update sensor from `Update Available` to `Update`
- Improved removal of MQTT entities on addon stop

### 1.0.1
- Fixed value type error inside Portainer Endpoint API

### 1.0.0
- Initial release