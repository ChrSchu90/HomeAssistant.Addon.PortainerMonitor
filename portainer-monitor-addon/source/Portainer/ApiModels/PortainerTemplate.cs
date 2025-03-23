#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerTemplate {
    /// <summary>
    /// Whether the template should be available to administrators only
    /// </summary>
    /// <value>Whether the template should be available to administrators only</value>
    [JsonPropertyName("administrator_only")]
    public bool? AdministratorOnly { get; set; }

    /// <summary>
    /// A list of categories associated to the template
    /// </summary>
    /// <value>A list of categories associated to the template</value>
    [JsonPropertyName("categories")]
    public List<string> Categories { get; set; }

    /// <summary>
    /// The command that will be executed in a container template
    /// </summary>
    /// <value>The command that will be executed in a container template</value>
    [JsonPropertyName("command")]
    public string Command { get; set; }

    /// <summary>
    /// Description of the template
    /// </summary>
    /// <value>Description of the template</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// A list of environment(endpoint) variables used during the template deployment
    /// </summary>
    /// <value>A list of environment(endpoint) variables used during the template deployment</value>
    [JsonPropertyName("env")]
    public List<PortainerTemplateEnv> Env { get; set; }

    /// <summary>
    /// Container hostname
    /// </summary>
    /// <value>Container hostname</value>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>
    /// Mandatory container/stack fields Template Identifier
    /// </summary>
    /// <value>Mandatory container/stack fields Template Identifier</value>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>
    /// Mandatory container fields Image associated to a container template. Mandatory for a container template
    /// </summary>
    /// <value>Mandatory container fields Image associated to a container template. Mandatory for a container template</value>
    [JsonPropertyName("image")]
    public string Image { get; set; }

    /// <summary>
    /// Whether the container should be started in interactive mode (-i -t equivalent on the CLI)
    /// </summary>
    /// <value>Whether the container should be started in interactive mode (-i -t equivalent on the CLI)</value>
    [JsonPropertyName("interactive")]
    public bool? Interactive { get; set; }

    /// <summary>
    /// Container labels
    /// </summary>
    /// <value>Container labels</value>
    [JsonPropertyName("labels")]
    public List<PortainerPair> Labels { get; set; }

    /// <summary>
    /// URL of the template's logo
    /// </summary>
    /// <value>URL of the template's logo</value>
    [JsonPropertyName("logo")]
    public string Logo { get; set; }

    /// <summary>
    /// Optional stack/container fields Default name for the stack/container to be used on deployment
    /// </summary>
    /// <value>Optional stack/container fields Default name for the stack/container to be used on deployment</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Name of a network that will be used on container deployment if it exists inside the environment(endpoint)
    /// </summary>
    /// <value>Name of a network that will be used on container deployment if it exists inside the environment(endpoint)</value>
    [JsonPropertyName("network")]
    public string Network { get; set; }

    /// <summary>
    /// A note that will be displayed in the UI. Supports HTML content
    /// </summary>
    /// <value>A note that will be displayed in the UI. Supports HTML content</value>
    [JsonPropertyName("note")]
    public string Note { get; set; }

    /// <summary>
    /// Platform associated to the template. Valid values are: 'linux', 'windows' or leave empty for multi-platform
    /// </summary>
    /// <value>Platform associated to the template. Valid values are: 'linux', 'windows' or leave empty for multi-platform</value>
    [JsonPropertyName("platform")]
    public string Platform { get; set; }

    /// <summary>
    /// A list of ports exposed by the container
    /// </summary>
    /// <value>A list of ports exposed by the container</value>
    [JsonPropertyName("ports")]
    public List<string> Ports { get; set; }

    /// <summary>
    /// Whether the container should be started in privileged mode
    /// </summary>
    /// <value>Whether the container should be started in privileged mode</value>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    /// <summary>
    /// Optional container fields The URL of a registry associated to the image for a container template
    /// </summary>
    /// <value>Optional container fields The URL of a registry associated to the image for a container template</value>
    [JsonPropertyName("registry")]
    public string Registry { get; set; }

    /// <summary>
    /// Mandatory stack fields
    /// </summary>
    /// <value>Mandatory stack fields</value>
    [JsonPropertyName("repository")]
    public PortainerTemplateRepository Repository { get; set; }

    /// <summary>
    /// Container restart policy
    /// </summary>
    /// <value>Container restart policy</value>
    [JsonPropertyName("restart_policy")]
    public string RestartPolicy { get; set; }

    /// <summary>
    /// Mandatory Edge stack fields Stack file used for this template
    /// </summary>
    /// <value>Mandatory Edge stack fields Stack file used for this template</value>
    [JsonPropertyName("stackFile")]
    public string StackFile { get; set; }

    /// <summary>
    /// Title of the template
    /// </summary>
    /// <value>Title of the template</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// Template type. Valid values are: 1 (container), 2 (Swarm stack), 3 (Compose stack), 4 (Compose edge stack)
    /// </summary>
    /// <value>Template type. Valid values are: 1 (container), 2 (Swarm stack), 3 (Compose stack), 4 (Compose edge stack)</value>
    [JsonPropertyName("type")]
    public int? Type { get; set; }

    /// <summary>
    /// A list of volumes used during the container template deployment
    /// </summary>
    /// <value>A list of volumes used during the container template deployment</value>
    [JsonPropertyName("volumes")]
    public List<PortainerTemplateVolume> Volumes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerTemplate {\n");
        sb.Append("  AdministratorOnly: ").Append(AdministratorOnly).Append("\n");
        sb.Append("  Categories: ").Append(Categories).Append("\n");
        sb.Append("  Command: ").Append(Command).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Env: ").Append(Env).Append("\n");
        sb.Append("  Hostname: ").Append(Hostname).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Image: ").Append(Image).Append("\n");
        sb.Append("  Interactive: ").Append(Interactive).Append("\n");
        sb.Append("  Labels: ").Append(Labels).Append("\n");
        sb.Append("  Logo: ").Append(Logo).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Network: ").Append(Network).Append("\n");
        sb.Append("  Note: ").Append(Note).Append("\n");
        sb.Append("  Platform: ").Append(Platform).Append("\n");
        sb.Append("  Ports: ").Append(Ports).Append("\n");
        sb.Append("  Privileged: ").Append(Privileged).Append("\n");
        sb.Append("  Registry: ").Append(Registry).Append("\n");
        sb.Append("  Repository: ").Append(Repository).Append("\n");
        sb.Append("  RestartPolicy: ").Append(RestartPolicy).Append("\n");
        sb.Append("  StackFile: ").Append(StackFile).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Volumes: ").Append(Volumes).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}