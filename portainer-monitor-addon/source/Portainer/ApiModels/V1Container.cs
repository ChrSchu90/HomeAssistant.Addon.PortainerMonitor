#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1Container {
    /// <summary>
    /// Arguments to the entrypoint. The container image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \"$$(VAR_NAME)\" will produce the string literal \"$(VAR_NAME)\". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell +optional
    /// </summary>
    /// <value>Arguments to the entrypoint. The container image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \"$$(VAR_NAME)\" will produce the string literal \"$(VAR_NAME)\". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell +optional</value>
    [JsonPropertyName("args")]
    public List<string> Args { get; set; }

    /// <summary>
    /// Entrypoint array. Not executed within a shell. The container image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \"$$(VAR_NAME)\" will produce the string literal \"$(VAR_NAME)\". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell +optional
    /// </summary>
    /// <value>Entrypoint array. Not executed within a shell. The container image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \"$$(VAR_NAME)\" will produce the string literal \"$(VAR_NAME)\". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell +optional</value>
    [JsonPropertyName("command")]
    public List<string> Command { get; set; }

    /// <summary>
    /// List of environment variables to set in the container. Cannot be updated. +optional +patchMergeKey=name +patchStrategy=merge
    /// </summary>
    /// <value>List of environment variables to set in the container. Cannot be updated. +optional +patchMergeKey=name +patchStrategy=merge</value>
    [JsonPropertyName("env")]
    public List<V1EnvVar> Env { get; set; }

    /// <summary>
    /// List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated. +optional
    /// </summary>
    /// <value>List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated. +optional</value>
    [JsonPropertyName("envFrom")]
    public List<V1EnvFromSource> EnvFrom { get; set; }

    /// <summary>
    /// Container image name. More info: https://kubernetes.io/docs/concepts/containers/images This field is optional to allow higher level config management to default or override container images in workload controllers like Deployments and StatefulSets. +optional
    /// </summary>
    /// <value>Container image name. More info: https://kubernetes.io/docs/concepts/containers/images This field is optional to allow higher level config management to default or override container images in workload controllers like Deployments and StatefulSets. +optional</value>
    [JsonPropertyName("image")]
    public string Image { get; set; }

    /// <summary>
    /// Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images +optional
    /// </summary>
    /// <value>Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images +optional</value>
    [JsonPropertyName("imagePullPolicy")]
    public string ImagePullPolicy { get; set; }

    /// <summary>
    /// Actions that the management system should take in response to container lifecycle events. Cannot be updated. +optional
    /// </summary>
    /// <value>Actions that the management system should take in response to container lifecycle events. Cannot be updated. +optional</value>
    [JsonPropertyName("lifecycle")]
    public V1Lifecycle Lifecycle { get; set; }

    /// <summary>
    /// Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes +optional
    /// </summary>
    /// <value>Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes +optional</value>
    [JsonPropertyName("livenessProbe")]
    public V1Probe LivenessProbe { get; set; }

    /// <summary>
    /// Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.
    /// </summary>
    /// <value>Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// List of ports to expose from the container. Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default \"0.0.0.0\" address inside a container will be accessible from the network. Modifying this array with strategic merge patch may corrupt the data. For more information See https://github.com/kubernetes/kubernetes/issues/108255. Cannot be updated. +optional +patchMergeKey=containerPort +patchStrategy=merge +listType=map +listMapKey=containerPort +listMapKey=protocol
    /// </summary>
    /// <value>List of ports to expose from the container. Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default \"0.0.0.0\" address inside a container will be accessible from the network. Modifying this array with strategic merge patch may corrupt the data. For more information See https://github.com/kubernetes/kubernetes/issues/108255. Cannot be updated. +optional +patchMergeKey=containerPort +patchStrategy=merge +listType=map +listMapKey=containerPort +listMapKey=protocol</value>
    [JsonPropertyName("ports")]
    public List<V1ContainerPort> Ports { get; set; }

    /// <summary>
    /// Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes +optional
    /// </summary>
    /// <value>Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes +optional</value>
    [JsonPropertyName("readinessProbe")]
    public V1Probe ReadinessProbe { get; set; }

    /// <summary>
    /// Resources resize policy for the container. +featureGate=InPlacePodVerticalScaling +optional +listType=atomic
    /// </summary>
    /// <value>Resources resize policy for the container. +featureGate=InPlacePodVerticalScaling +optional +listType=atomic</value>
    [JsonPropertyName("resizePolicy")]
    public List<V1ContainerResizePolicy> ResizePolicy { get; set; }

    /// <summary>
    /// Compute Resources required by this container. Cannot be updated. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/ +optional
    /// </summary>
    /// <value>Compute Resources required by this container. Cannot be updated. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/ +optional</value>
    [JsonPropertyName("resources")]
    public V1ResourceRequirements Resources { get; set; }

    /// <summary>
    /// RestartPolicy defines the restart behavior of individual containers in a pod. This field may only be set for init containers, and the only allowed value is \"Always\". For non-init containers or when this field is not specified, the restart behavior is defined by the Pod's restart policy and the container type. Setting the RestartPolicy as \"Always\" for the init container will have the following effect: this init container will be continually restarted on exit until all regular containers have terminated. Once all regular containers have completed, all init containers with restartPolicy \"Always\" will be shut down. This lifecycle differs from normal init containers and is often referred to as a \"sidecar\" container. Although this init container still starts in the init container sequence, it does not wait for the container to complete before proceeding to the next init container. Instead, the next init container starts immediately after this init container is started, or after any startupProbe has successfully completed. +featureGate=SidecarContainers +optional
    /// </summary>
    /// <value>RestartPolicy defines the restart behavior of individual containers in a pod. This field may only be set for init containers, and the only allowed value is \"Always\". For non-init containers or when this field is not specified, the restart behavior is defined by the Pod's restart policy and the container type. Setting the RestartPolicy as \"Always\" for the init container will have the following effect: this init container will be continually restarted on exit until all regular containers have terminated. Once all regular containers have completed, all init containers with restartPolicy \"Always\" will be shut down. This lifecycle differs from normal init containers and is often referred to as a \"sidecar\" container. Although this init container still starts in the init container sequence, it does not wait for the container to complete before proceeding to the next init container. Instead, the next init container starts immediately after this init container is started, or after any startupProbe has successfully completed. +featureGate=SidecarContainers +optional</value>
    [JsonPropertyName("restartPolicy")]
    public string RestartPolicy { get; set; }

    /// <summary>
    /// SecurityContext defines the security options the container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext. More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/ +optional
    /// </summary>
    /// <value>SecurityContext defines the security options the container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext. More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/ +optional</value>
    [JsonPropertyName("securityContext")]
    public V1SecurityContext SecurityContext { get; set; }

    /// <summary>
    /// StartupProbe indicates that the Pod has successfully initialized. If specified, no other probes are executed until this completes successfully. If this probe fails, the Pod will be restarted, just as if the livenessProbe failed. This can be used to provide different probe parameters at the beginning of a Pod's lifecycle, when it might take a long time to load data or warm a cache, than during steady-state operation. This cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes +optional
    /// </summary>
    /// <value>StartupProbe indicates that the Pod has successfully initialized. If specified, no other probes are executed until this completes successfully. If this probe fails, the Pod will be restarted, just as if the livenessProbe failed. This can be used to provide different probe parameters at the beginning of a Pod's lifecycle, when it might take a long time to load data or warm a cache, than during steady-state operation. This cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes +optional</value>
    [JsonPropertyName("startupProbe")]
    public V1Probe StartupProbe { get; set; }

    /// <summary>
    /// Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false. +optional
    /// </summary>
    /// <value>Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false. +optional</value>
    [JsonPropertyName("stdin")]
    public bool? Stdin { get; set; }

    /// <summary>
    /// Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false +optional
    /// </summary>
    /// <value>Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false +optional</value>
    [JsonPropertyName("stdinOnce")]
    public bool? StdinOnce { get; set; }

    /// <summary>
    /// Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated. +optional
    /// </summary>
    /// <value>Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated. +optional</value>
    [JsonPropertyName("terminationMessagePath")]
    public string TerminationMessagePath { get; set; }

    /// <summary>
    /// Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated. +optional
    /// </summary>
    /// <value>Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated. +optional</value>
    [JsonPropertyName("terminationMessagePolicy")]
    public string TerminationMessagePolicy { get; set; }

    /// <summary>
    /// Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false. +optional
    /// </summary>
    /// <value>Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false. +optional</value>
    [JsonPropertyName("tty")]
    public bool? Tty { get; set; }

    /// <summary>
    /// volumeDevices is the list of block devices to be used by the container. +patchMergeKey=devicePath +patchStrategy=merge +optional
    /// </summary>
    /// <value>volumeDevices is the list of block devices to be used by the container. +patchMergeKey=devicePath +patchStrategy=merge +optional</value>
    [JsonPropertyName("volumeDevices")]
    public List<V1VolumeDevice> VolumeDevices { get; set; }

    /// <summary>
    /// Pod volumes to mount into the container's filesystem. Cannot be updated. +optional +patchMergeKey=mountPath +patchStrategy=merge
    /// </summary>
    /// <value>Pod volumes to mount into the container's filesystem. Cannot be updated. +optional +patchMergeKey=mountPath +patchStrategy=merge</value>
    [JsonPropertyName("volumeMounts")]
    public List<V1VolumeMount> VolumeMounts { get; set; }

    /// <summary>
    /// Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated. +optional
    /// </summary>
    /// <value>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated. +optional</value>
    [JsonPropertyName("workingDir")]
    public string WorkingDir { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1Container {\n");
        sb.Append("  Args: ").Append(Args).Append("\n");
        sb.Append("  Command: ").Append(Command).Append("\n");
        sb.Append("  Env: ").Append(Env).Append("\n");
        sb.Append("  EnvFrom: ").Append(EnvFrom).Append("\n");
        sb.Append("  Image: ").Append(Image).Append("\n");
        sb.Append("  ImagePullPolicy: ").Append(ImagePullPolicy).Append("\n");
        sb.Append("  Lifecycle: ").Append(Lifecycle).Append("\n");
        sb.Append("  LivenessProbe: ").Append(LivenessProbe).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Ports: ").Append(Ports).Append("\n");
        sb.Append("  ReadinessProbe: ").Append(ReadinessProbe).Append("\n");
        sb.Append("  ResizePolicy: ").Append(ResizePolicy).Append("\n");
        sb.Append("  Resources: ").Append(Resources).Append("\n");
        sb.Append("  RestartPolicy: ").Append(RestartPolicy).Append("\n");
        sb.Append("  SecurityContext: ").Append(SecurityContext).Append("\n");
        sb.Append("  StartupProbe: ").Append(StartupProbe).Append("\n");
        sb.Append("  Stdin: ").Append(Stdin).Append("\n");
        sb.Append("  StdinOnce: ").Append(StdinOnce).Append("\n");
        sb.Append("  TerminationMessagePath: ").Append(TerminationMessagePath).Append("\n");
        sb.Append("  TerminationMessagePolicy: ").Append(TerminationMessagePolicy).Append("\n");
        sb.Append("  Tty: ").Append(Tty).Append("\n");
        sb.Append("  VolumeDevices: ").Append(VolumeDevices).Append("\n");
        sb.Append("  VolumeMounts: ").Append(VolumeMounts).Append("\n");
        sb.Append("  WorkingDir: ").Append(WorkingDir).Append("\n");
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