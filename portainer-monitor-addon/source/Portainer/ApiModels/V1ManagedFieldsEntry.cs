#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class V1ManagedFieldsEntry {
    /// <summary>
    /// APIVersion defines the version of this resource that this field set applies to. The format is \"group/version\" just like the top-level APIVersion field. It is necessary to track the version of a field set because it cannot be automatically converted.
    /// </summary>
    /// <value>APIVersion defines the version of this resource that this field set applies to. The format is \"group/version\" just like the top-level APIVersion field. It is necessary to track the version of a field set because it cannot be automatically converted.</value>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>
    /// FieldsType is the discriminator for the different fields format and version. There is currently only one possible value: \"FieldsV1\"
    /// </summary>
    /// <value>FieldsType is the discriminator for the different fields format and version. There is currently only one possible value: \"FieldsV1\"</value>
    [JsonPropertyName("fieldsType")]
    public string FieldsType { get; set; }

    /// <summary>
    /// FieldsV1 holds the first JSON version format as described in the \"FieldsV1\" type. +optional
    /// </summary>
    /// <value>FieldsV1 holds the first JSON version format as described in the \"FieldsV1\" type. +optional</value>
    [JsonPropertyName("fieldsV1")]
    public V1FieldsV1 FieldsV1 { get; set; }

    /// <summary>
    /// Manager is an identifier of the workflow managing these fields.
    /// </summary>
    /// <value>Manager is an identifier of the workflow managing these fields.</value>
    [JsonPropertyName("manager")]
    public string Manager { get; set; }

    /// <summary>
    /// Operation is the type of operation which lead to this ManagedFieldsEntry being created. The only valid values for this field are 'Apply' and 'Update'.
    /// </summary>
    /// <value>Operation is the type of operation which lead to this ManagedFieldsEntry being created. The only valid values for this field are 'Apply' and 'Update'.</value>
    [JsonPropertyName("operation")]
    public string Operation { get; set; }

    /// <summary>
    /// Subresource is the name of the subresource used to update that object, or empty string if the object was updated through the main resource. The value of this field is used to distinguish between managers, even if they share the same name. For example, a status update will be distinct from a regular update using the same manager name. Note that the APIVersion field is not related to the Subresource field and it always corresponds to the version of the main resource.
    /// </summary>
    /// <value>Subresource is the name of the subresource used to update that object, or empty string if the object was updated through the main resource. The value of this field is used to distinguish between managers, even if they share the same name. For example, a status update will be distinct from a regular update using the same manager name. Note that the APIVersion field is not related to the Subresource field and it always corresponds to the version of the main resource.</value>
    [JsonPropertyName("subresource")]
    public string Subresource { get; set; }

    /// <summary>
    /// Time is the timestamp of when the ManagedFields entry was added. The timestamp will also be updated if a field is added, the manager changes any of the owned fields value or removes a field. The timestamp does not update when a field is removed from the entry because another manager took it over. +optional
    /// </summary>
    /// <value>Time is the timestamp of when the ManagedFields entry was added. The timestamp will also be updated if a field is added, the manager changes any of the owned fields value or removes a field. The timestamp does not update when a field is removed from the entry because another manager took it over. +optional</value>
    [JsonPropertyName("time")]
    public string Time { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class V1ManagedFieldsEntry {\n");
        sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
        sb.Append("  FieldsType: ").Append(FieldsType).Append("\n");
        sb.Append("  FieldsV1: ").Append(FieldsV1).Append("\n");
        sb.Append("  Manager: ").Append(Manager).Append("\n");
        sb.Append("  Operation: ").Append(Operation).Append("\n");
        sb.Append("  Subresource: ").Append(Subresource).Append("\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
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