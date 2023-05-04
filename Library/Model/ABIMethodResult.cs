using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ABIMethodResult {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ReturnType
    /// </summary>
    [DataMember(Name="returnType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "returnType")]
    public string ReturnType { get; set; }

    /// <summary>
    /// Gets or Sets Parameters
    /// </summary>
    [DataMember(Name="parameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameters")]
    public List<ABIParameterResult> Parameters { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ABIMethodResult {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ReturnType: ").Append(ReturnType).Append("\n");
      sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
}
