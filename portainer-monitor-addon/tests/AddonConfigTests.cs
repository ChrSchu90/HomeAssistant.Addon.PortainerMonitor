namespace HomeAssistant.Addon.PortainerMonitor.Tests;

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serilog.Events;

/// <summary>
/// Test for <see cref="AddonConfig"/>
/// </summary>
[TestClass]
public sealed class AddonConfigTests
{
    [TestMethod]
    public void Deserialization()
    {
        var jsonCfg = AddonConfig.FromText(GetTestJson());
        var yamlCfg = AddonConfig.FromText(GetTestYaml());
        Assert.AreEqual(jsonCfg.ToYaml(), yamlCfg.ToYaml(), "Yaml to Json deserialization difference");
        Assert.AreEqual(jsonCfg.ToJson(), yamlCfg.ToJson(), "Json to Yaml deserialization difference");
        Assert.AreEqual(LogEventLevel.Debug, jsonCfg.LogLevel, "Wrong log level inside Json");
        Assert.AreEqual(LogEventLevel.Debug, yamlCfg.LogLevel, "Wrong log level inside Yaml");
    }

    [TestMethod]
    public void GeneralValidation()
    {
        var cfg = AddonConfig.FromText(GetTestJson());
        cfg.Validate(); // No Exception

        var oldUpdateInterval = cfg.UpdateInterval;
        cfg.UpdateInterval = 0;
        Assert.ThrowsException<ConfigException>(cfg.Validate, "Invalid update interval accepted");
        cfg.UpdateInterval = oldUpdateInterval;

        var oldPortainerConfigs = cfg.PortainerConfigs.ToArray();
        cfg.PortainerConfigs.Clear();
        Assert.ThrowsException<ConfigException>(cfg.Validate, "Empty portainer configs accepted");
        cfg.PortainerConfigs.AddRange(oldPortainerConfigs);
    }

    [TestMethod]
    public void MqttValidation()
    {
        var cfg = AddonConfig.FromText(GetTestJson());
        cfg.Validate(); // No Exception

        var oldHost = cfg.MqttHost;
        cfg.MqttHost = string.Empty;
        Assert.ThrowsException<ConfigException>(cfg.Validate, "Invalid MQTT host accepted");
        cfg.MqttHost = oldHost;

        var oldPort = cfg.MqttPort;
        cfg.MqttPort = 0;
        Assert.ThrowsException<ConfigException>(cfg.Validate, "Invalid MQTT port accepted");
        cfg.MqttPort = oldPort;
    }

    [TestMethod]
    public void PortainerValidation()
    {
        var cfg = AddonConfig.FromText(GetTestJson()).PortainerConfigs.First();
        cfg.Validate(); // No Exception

        var oldId = cfg.Id;
        cfg.Id = string.Empty;
        Assert.ThrowsException<ConfigException>(cfg.Validate, "Invalid Portainer ID accepted");
        cfg.Id = oldId;

        var oldDisplayName = cfg.DisplayName;
        cfg.DisplayName = string.Empty;
        Assert.ThrowsException<ConfigException>(cfg.Validate, "Invalid Portainer display name accepted");
        cfg.DisplayName = oldDisplayName;

        var oldHost = cfg.Host;
        cfg.Host = string.Empty;
        Assert.ThrowsException<ConfigException>(cfg.Validate, "Invalid Portainer host accepted");
        cfg.Host = oldHost;

        var oldPort = cfg.Port;
        cfg.Port = 0;
        Assert.ThrowsException<ConfigException>(cfg.Validate, "Invalid Portainer port accepted");
        cfg.Port = oldPort;

        var oldToken = cfg.Token;
        cfg.Token = string.Empty;
        Assert.ThrowsException<ConfigException>(cfg.Validate, "Invalid Portainer token accepted");
        cfg.Token = oldToken;
    }

    private static string GetTestYaml()
    {
        return """
               log_level: Debug
               update_interval: 5
               mqtt_host: 192.168.10.123
               mqtt_port: 1883
               mqtt_user: 'mqtt'
               mqtt_password: '123456'
               mqtt_tls_enabled: false
               mqtt_tls_validate: false
               portainer_configs:
                 - id: portainer1
                   display_name: 'Portainer 1'
                   host: 192.168.10.124
                   port: 9443
                   token: 'ptr_AsfasdASddasdasdoaisndaosndonASDN'
                   tls_enabled: true
                   tls_validate: false
                 - id: portainer2
                   display_name: 'Portainer 2'
                   host: 192.168.10.125
                   port: 9443
                   token: 'ptr_AsfasdASddasdasdoaisndaosndonASDN'
                   tls_enabled: true
                   tls_validate: false
               """;
    }

    private static string GetTestJson()
    {
        return """
               {
                 "log_level": "Debug",
                 "update_interval": 5,
                 "mqtt_host": "192.168.10.123",
                 "mqtt_port": 1883,
                 "mqtt_user": "mqtt",
                 "mqtt_password": "123456",
                 "mqtt_tls_enabled": false,
                 "mqtt_tls_validate": false,
                 "portainer_configs": [
                   {
                     "id": "portainer1",
                     "display_name": "Portainer 1",
                     "host": "192.168.10.124",
                     "port": 9443,
                     "token": "ptr_AsfasdASddasdasdoaisndaosndonASDN",
                     "tls_enabled": true,
                     "tls_validate": false
                   },
                   {
                     "id": "portainer2",
                     "display_name": "Portainer 2",
                     "host": "192.168.10.125",
                     "port": 9443,
                     "token": "ptr_AsfasdASddasdasdoaisndaosndonASDN",
                     "tls_enabled": true,
                     "tls_validate": false
                   },
                 ]
               }
               """;
    }
}