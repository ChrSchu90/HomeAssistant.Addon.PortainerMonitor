namespace HomeAssistant.Addon.PortainerMonitor;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Cocona;
using HomeAssistant.Addon.PortainerMonitor.AddonModels;
using HomeAssistant.Addon.PortainerMonitor.Mqtt;
using HomeAssistant.Addon.PortainerMonitor.Portainer;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;

/// <summary>
/// App entry point
/// </summary>
public class Program
{
    /// <summary>
    /// The prefix for the HA MQTT entity unique identifier
    /// </summary>
    private const string AddonPrefix = "ptmt";

    /// <summary>
    /// The addon manufacturer
    /// </summary>
    private const string AddonManufacturer = "Portainer Monitor";

    /// <summary>
    /// The default full file name for the config inside a Home Assistant addon container
    /// </summary>
    private const string DefaultConfigFullFileName = "./data/options.json";

    /// <summary>
    /// The environment variable key which contains the configuration
    /// </summary>
    private const string ConfigEnvVariable = "PORTAINER_MONITOR_CONFIG";

    /// <summary>
    /// The MQTT client ID
    /// </summary>
    private static readonly string MqttClientID = $"PortainerMonitor-{Guid.NewGuid().ToString("N")[..5]}";

    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    /// <param name="args">The arguments.</param>
    public static Task Main(string[] args)
    {
        // Force english exception messages
        CultureInfo.CurrentCulture = CultureInfo.DefaultThreadCurrentCulture = CultureInfo.DefaultThreadCurrentUICulture = Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;

        // Init logging
        var logLevelSwitch = new LoggingLevelSwitch { MinimumLevel = LogEventLevel.Information };
        Log.Logger = new LoggerConfiguration().MinimumLevel.ControlledBy(logLevelSwitch)
            .WriteTo.Console(outputTemplate: "[{Timestamp:dd.MM.yyyy HH:mm:ss.fff} {Level:u3}] {Message:lj}{NewLine}{Exception}", theme: AnsiConsoleTheme.Sixteen, applyThemeToRedirectedOutput: true)
            .CreateLogger();

        Log.Information($"Starting Portainer Monitor v{Assembly.GetExecutingAssembly().GetName().Version?.ToString(3)}");

        return CoconaLiteApp.RunAsync(async
        ([Option("config", Description = $"Path to the config.yaml or config.json, defaults to `{DefaultConfigFullFileName}` if not configured")] string? configFullFileName,
         [Option("mqttuser", Description = "Override MQTT User")] string? mqttUser,
         [Option("mqttpw", Description = "Override MQTT Password")] string? mqttPassword,
         [Option("mqtthost", Description = "Override MQTT Host")] string? mqttHost,
         [Option("mqttport", Description = "Override MQTT Port")] ushort? mqttPort,
         CoconaAppContext ctx) =>
        {
            var ct = ctx.CancellationToken;

            // Load config
            AddonConfig? addonCfg = null;
            configFullFileName ??= DefaultConfigFullFileName;
            if (File.Exists(configFullFileName))
            {
                addonCfg = AddonConfig.FromFile(configFullFileName);
            }
            else
            {
                var envCfg = Environment.GetEnvironmentVariable(ConfigEnvVariable);
                if (!string.IsNullOrWhiteSpace(envCfg))
                {
                    addonCfg = AddonConfig.FromText(envCfg);
                }
            }

            if (addonCfg == null)
            {
                Log.Fatal("Unable to get configuration, addon startup not possible!");
                return;
            }

            // Handle argument Overrides
            if (!string.IsNullOrWhiteSpace(mqttUser))
                addonCfg.MqttUser = mqttUser;
            if (!string.IsNullOrWhiteSpace(mqttPassword))
                addonCfg.MqttPassword = mqttPassword;
            if (!string.IsNullOrWhiteSpace(mqttHost))
                addonCfg.MqttHost = mqttHost;
            if (mqttPort.HasValue)
                addonCfg.MqttPort = mqttPort.Value;

            // Update log level by config
            logLevelSwitch.MinimumLevel = addonCfg.LogLevel;
            Log.Verbose($"Config:\n{addonCfg.ToJson()}");
            addonCfg.Validate();

            // Init MQTT
            var mqttClient = new MqttClient(addonCfg, MqttClientID, ct);
            await mqttClient.ConnectAsync(true).ConfigureAwait(false);

            // Init Portainer instances
            var portainerConnections = new List<PortainerApi>();
            var portainerModels = new List<PortainerHostModel>();
            foreach (var portainerCfg in addonCfg.PortainerConfigs)
            {
                // Init portainer API connection
                var portainerConnection = new PortainerApi(portainerCfg, ct);
                portainerConnections.Add(portainerConnection);
                
                // Init portainer addon model that will sync the information to Home Assistant
                var portainerHost = new PortainerHostModel(portainerCfg, portainerConnection, mqttClient, AddonPrefix, AddonManufacturer);
                portainerModels.Add(portainerHost);
            }

            // Init Agent instances
            var agentConnections = new List<AgentApi>();
            var agentModels = new List<AgentHostModel>();
            foreach (var agentCfg in addonCfg.AgentConfigs)
            {
                // Init agent API connection
                var agentConnection = new AgentApi(agentCfg, ct);
                agentConnections.Add(agentConnection);

                // Init agent addon model that will sync the information to Home Assistant
                var agentModel = new AgentHostModel(agentCfg, agentConnection, mqttClient, AddonPrefix, AddonManufacturer);
                agentModels.Add(agentModel);
            }

            // Update loop
            var sw = new Stopwatch();
            while (!ct.IsCancellationRequested)
            {
                try
                {
                    if (!mqttClient.IsConnected)
                    {
                        Log.Debug("Skipped update since MQTT is disconnected");
                        await Task.Delay(addonCfg.UpdateInterval * 1000, ct).ConfigureAwait(false);
                        continue;
                    }

                    if (!mqttClient.IsHomeAssistantAvailable)
                    {
                        Log.Debug("Skipped update since Home Assistant is not available");
                        await Task.Delay(addonCfg.UpdateInterval * 1000, ct).ConfigureAwait(false);
                        continue;
                    }

                    sw.Restart();

                    // Update Portainer models
                    foreach (var portainerModel in portainerModels)
                        _ = await portainerModel.UpdateAsync().ConfigureAwait(false);

                    // Update Agent models
                    foreach (var agentModel in agentModels)
                        _ = await agentModel.UpdateAsync().ConfigureAwait(false);

                    sw.Stop();
                    Log.Debug($"Updated in {sw.Elapsed.TotalSeconds:0.000}s");
                    var wait = addonCfg.UpdateInterval * 1000 - (int)sw.Elapsed.TotalMilliseconds;
                    if (wait > 5) await Task.Delay(wait, ct).ConfigureAwait(false);
                }
                catch (OperationCanceledException) { /* ignore */ }
                catch (Exception err)
                {
                    Log.Fatal(err, "Unhanded error");
                }
            }

            Log.Information("Shutting down...");
            portainerModels.ForEach(m => m.Dispose());
            agentModels.ForEach(m => m.Dispose());
            portainerConnections.ForEach(c => c.Dispose());
            agentConnections.ForEach(c => c.Dispose());

            // Wait for MQTT entity delete publishes send during disposal  
            await Task.Delay(1500, CancellationToken.None).ConfigureAwait(false);
            mqttClient.Dispose();
            Log.Information("Shutdown completed!");
        });
    }
}