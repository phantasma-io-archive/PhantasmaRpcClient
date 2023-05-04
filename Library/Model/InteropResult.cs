using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class InteropResult {
    /// <summary>
    /// Gets or Sets Local
    /// </summary>
    [DataMember(Name="local", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "local")]
    public string Local { get; set; }

    /// <summary>
    /// Gets or Sets External
    /// </summary>
    [DataMember(Name="external", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "external")]
    public string External { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InteropResult {\n");
      sb.Append("  Local: ").Append(Local).Append("\n");
      sb.Append("  External: ").Append(External).Append("\n");
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
