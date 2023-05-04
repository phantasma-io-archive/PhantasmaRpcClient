using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PlatformResult {
    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    [DataMember(Name="platform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platform")]
    public string Platform { get; set; }

    /// <summary>
    /// Gets or Sets Chain
    /// </summary>
    [DataMember(Name="chain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chain")]
    public string Chain { get; set; }

    /// <summary>
    /// Gets or Sets Fuel
    /// </summary>
    [DataMember(Name="fuel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fuel")]
    public string Fuel { get; set; }

    /// <summary>
    /// Gets or Sets Tokens
    /// </summary>
    [DataMember(Name="tokens", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tokens")]
    public List<string> Tokens { get; set; }

    /// <summary>
    /// Gets or Sets Interop
    /// </summary>
    [DataMember(Name="interop", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interop")]
    public List<InteropResult> Interop { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PlatformResult {\n");
      sb.Append("  Platform: ").Append(Platform).Append("\n");
      sb.Append("  Chain: ").Append(Chain).Append("\n");
      sb.Append("  Fuel: ").Append(Fuel).Append("\n");
      sb.Append("  Tokens: ").Append(Tokens).Append("\n");
      sb.Append("  Interop: ").Append(Interop).Append("\n");
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
