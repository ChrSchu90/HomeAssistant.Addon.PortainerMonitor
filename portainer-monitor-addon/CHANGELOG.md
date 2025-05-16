## Changelog 🚀
### 1.0.11
- Fixed possible `BadRequest` API errors on `Start`, `Stop`, `Pause` and `Restart` command execution
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
- Improved entity label naming

### 1.0.4
- Add Sensors with amount of `running`, `stopped`, `paused` and `total` containers per Endpoint

### 1.0.3
- Update sensor, switch and button icons

### 1.0.2
- Add `Docker Version` sensor for each Endpoint
- Changed update label of Portainer update sensor from `Update Available` to `Update`
- Improved removal of MQTT entities on addon stop

### 1.0.1
- Fixed value type error inside Endpoint API

### 1.0.0
- Initial release