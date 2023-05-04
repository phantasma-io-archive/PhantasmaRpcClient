using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AccountResult {
    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Stakes
    /// </summary>
    [DataMember(Name="stakes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stakes")]
    public StakeResult Stakes { get; set; }

    /// <summary>
    /// Gets or Sets Stake
    /// </summary>
    [DataMember(Name="stake", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stake")]
    public string Stake { get; set; }

    /// <summary>
    /// Gets or Sets Unclaimed
    /// </summary>
    [DataMember(Name="unclaimed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unclaimed")]
    public string Unclaimed { get; set; }

    /// <summary>
    /// Gets or Sets Relay
    /// </summary>
    [DataMember(Name="relay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relay")]
    public string Relay { get; set; }

    /// <summary>
    /// Gets or Sets Validator
    /// </summary>
    [DataMember(Name="validator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validator")]
    public string Validator { get; set; }

    /// <summary>
    /// Gets or Sets Storage
    /// </summary>
    [DataMember(Name="storage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storage")]
    public StorageResult Storage { get; set; }

    /// <summary>
    /// Gets or Sets Balances
    /// </summary>
    [DataMember(Name="balances", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balances")]
    public List<BalanceResult> Balances { get; set; }

    /// <summary>
    /// Gets or Sets Txs
    /// </summary>
    [DataMember(Name="txs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "txs")]
    public List<string> Txs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountResult {\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Stakes: ").Append(Stakes).Append("\n");
      sb.Append("  Stake: ").Append(Stake).Append("\n");
      sb.Append("  Unclaimed: ").Append(Unclaimed).Append("\n");
      sb.Append("  Relay: ").Append(Relay).Append("\n");
      sb.Append("  Validator: ").Append(Validator).Append("\n");
      sb.Append("  Storage: ").Append(Storage).Append("\n");
      sb.Append("  Balances: ").Append(Balances).Append("\n");
      sb.Append("  Txs: ").Append(Txs).Append("\n");
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
