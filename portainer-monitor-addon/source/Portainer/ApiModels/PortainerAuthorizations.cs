namespace HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;

using System.Collections.Generic;
using System.Text;
using System.Xml;

/// <summary>
/// 
/// </summary>
public class PortainerAuthorizations : Dictionary<string, bool?> {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
        var sb = new StringBuilder();
        sb.Append("class PortainerAuthorizations {\n");
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