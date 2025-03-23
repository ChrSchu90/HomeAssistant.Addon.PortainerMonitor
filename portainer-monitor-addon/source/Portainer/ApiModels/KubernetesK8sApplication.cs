#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class KubernetesK8sApplication {
    /// <summary>
    /// Gets or Sets ApplicationOwner
    /// </summary>
    [JsonPropertyName("ApplicationOwner")]
    public string ApplicationOwner { get; set; }

    /// <summary>
    /// Gets or Sets ApplicationType
    /// </summary>
    [JsonPropertyName("ApplicationType")]
    public string ApplicationType { get; set; }

    /// <summary>
    /// Gets or Sets Configurations
    /// </summary>
    [JsonPropertyName("Configurations")]
    public List<KubernetesConfiguration> Configurations { get; set; }

    /// <summary>
    /// Gets or Sets Containers
    /// </summary>
    [JsonPropertyName("Containers")]
    public List<Object> Containers { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [JsonPropertyName("CreationDate")]
    public string CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets DeploymentType
    /// </summary>
    [JsonPropertyName("DeploymentType")]
    public string DeploymentType { get; set; }

    /// <summary>
    /// Gets or Sets HorizontalPodAutoscaler
    /// </summary>
    [JsonPropertyName("HorizontalPodAutoscaler")]
    public V2HorizontalPodAutoscaler HorizontalPodAutoscaler { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("Id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Image
    /// </summary>
    [JsonPropertyName("Image")]
    public string Image { get; set; }

    /// <summary>
    /// Gets or Sets Kind
    /// </summary>
    [JsonPropertyName("Kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Gets or Sets Labels
    /// </summary>
    [JsonPropertyName("Labels")]
    public Dictionary<string, string> Labels { get; set; }

    /// <summary>
    /// Gets or Sets LoadBalancerIPAddress
    /// </summary>
    [JsonPropertyName("LoadBalancerIPAddress")]
    public string LoadBalancerIPAddress { get; set; }

    /// <summary>
    /// Gets or Sets MatchLabels
    /// </summary>
    [JsonPropertyName("MatchLabels")]
    public Dictionary<string, string> MatchLabels { get; set; }

    /// <summary>
    /// Gets or Sets Metadata
    /// </summary>
    [JsonPropertyName("Metadata")]
    public KubernetesMetadata Metadata { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    [JsonPropertyName("Namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Gets or Sets Pods
    /// </summary>
    [JsonPropertyName("Pods")]
    public List<KubernetesPod> Pods { get; set; }

    /// <summary>
    /// Gets or Sets PublishedPorts
    /// </summary>
    [JsonPropertyName("PublishedPorts")]
    public List<KubernetesPublishedPort> PublishedPorts { get; set; }

    /// <summary>
    /// Gets or Sets Resource
    /// </summary>
    [JsonPropertyName("Resource")]
    public KubernetesK8sApplicationResource Resource { get; set; }

    /// <summary>
    /// Gets or Sets ResourcePool
    /// </summary>
    [JsonPropertyName("ResourcePool")]
    public string ResourcePool { get; set; }

    /// <summary>
    /// Gets or Sets RunningPodsCount
    /// </summary>
    [JsonPropertyName("RunningPodsCount")]
    public int? RunningPodsCount { get; set; }

    /// <summary>
    /// Gets or Sets ServiceId
    /// </summary>
    [JsonPropertyName("ServiceId")]
    public string ServiceId { get; set; }

    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>
    [JsonPropertyName("ServiceName")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Gets or Sets ServiceType
    /// </summary>
    [JsonPropertyName("ServiceType")]
    public string ServiceType { get; set; }

    /// <summary>
    /// Gets or Sets Services
    /// </summary>
    [JsonPropertyName("Services")]
    public List<V1Service> Services { get; set; }

    /// <summary>
    /// Gets or Sets StackId
    /// </summary>
    [JsonPropertyName("StackId")]
    public string StackId { get; set; }

    /// <summary>
    /// Gets or Sets StackName
    /// </summary>
    [JsonPropertyName("StackName")]
    public string StackName { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("Status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets TotalPodsCount
    /// </summary>
    [JsonPropertyName("TotalPodsCount")]
    public int? TotalPodsCount { get; set; }

    /// <summary>
    /// Gets or Sets Uid
    /// </summary>
    [JsonPropertyName("Uid")]
    public string Uid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class KubernetesK8sApplication {\n");
        sb.Append("  ApplicationOwner: ").Append(ApplicationOwner).Append("\n");
        sb.Append("  ApplicationType: ").Append(ApplicationType).Append("\n");
        sb.Append("  Configurations: ").Append(Configurations).Append("\n");
        sb.Append("  Containers: ").Append(Containers).Append("\n");
        sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
        sb.Append("  DeploymentType: ").Append(DeploymentType).Append("\n");
        sb.Append("  HorizontalPodAutoscaler: ").Append(HorizontalPodAutoscaler).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Image: ").Append(Image).Append("\n");
        sb.Append("  Kind: ").Append(Kind).Append("\n");
        sb.Append("  Labels: ").Append(Labels).Append("\n");
        sb.Append("  LoadBalancerIPAddress: ").Append(LoadBalancerIPAddress).Append("\n");
        sb.Append("  MatchLabels: ").Append(MatchLabels).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  Pods: ").Append(Pods).Append("\n");
        sb.Append("  PublishedPorts: ").Append(PublishedPorts).Append("\n");
        sb.Append("  Resource: ").Append(Resource).Append("\n");
        sb.Append("  ResourcePool: ").Append(ResourcePool).Append("\n");
        sb.Append("  RunningPodsCount: ").Append(RunningPodsCount).Append("\n");
        sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
        sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
        sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
        sb.Append("  Services: ").Append(Services).Append("\n");
        sb.Append("  StackId: ").Append(StackId).Append("\n");
        sb.Append("  StackName: ").Append(StackName).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  TotalPodsCount: ").Append(TotalPodsCount).Append("\n");
        sb.Append("  Uid: ").Append(Uid).Append("\n");
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