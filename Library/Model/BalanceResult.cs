using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class BalanceResult {
    /// <summary>
    /// Gets or Sets Chain
    /// </summary>
    [DataMember(Name="chain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chain")]
    public string Chain { get; set; }

    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// Gets or Sets Symbol
    /// </summary>
    [DataMember(Name="symbol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "symbol")]
    public string Symbol { get; set; }

    /// <summary>
    /// Gets or Sets Decimals
    /// </summary>
    [DataMember(Name="decimals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decimals")]
    public int? Decimals { get; set; }

    /// <summary>
    /// Gets or Sets Ids
    /// </summary>
    [DataMember(Name="ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ids")]
    public List<string> Ids { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BalanceResult {\n");
      sb.Append("  Chain: ").Append(Chain).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Symbol: ").Append(Symbol).Append("\n");
      sb.Append("  Decimals: ").Append(Decimals).Append("\n");
      sb.Append("  Ids: ").Append(Ids).Append("\n");
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
