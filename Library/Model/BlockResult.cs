using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class BlockResult {
    /// <summary>
    /// Gets or Sets Hash
    /// </summary>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public string Hash { get; set; }

    /// <summary>
    /// Gets or Sets PreviousHash
    /// </summary>
    [DataMember(Name="previousHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previousHash")]
    public string PreviousHash { get; set; }

    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public int? Timestamp { get; set; }

    /// <summary>
    /// Gets or Sets Height
    /// </summary>
    [DataMember(Name="height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "height")]
    public int? Height { get; set; }

    /// <summary>
    /// Gets or Sets ChainAddress
    /// </summary>
    [DataMember(Name="chainAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chainAddress")]
    public string ChainAddress { get; set; }

    /// <summary>
    /// Gets or Sets Protocol
    /// </summary>
    [DataMember(Name="protocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocol")]
    public int? Protocol { get; set; }

    /// <summary>
    /// Gets or Sets Txs
    /// </summary>
    [DataMember(Name="txs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "txs")]
    public List<TransactionResult> Txs { get; set; }

    /// <summary>
    /// Gets or Sets ValidatorAddress
    /// </summary>
    [DataMember(Name="validatorAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validatorAddress")]
    public string ValidatorAddress { get; set; }

    /// <summary>
    /// Gets or Sets Reward
    /// </summary>
    [DataMember(Name="reward", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reward")]
    public string Reward { get; set; }

    /// <summary>
    /// Gets or Sets Events
    /// </summary>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<EventResult> Events { get; set; }

    /// <summary>
    /// Gets or Sets Oracles
    /// </summary>
    [DataMember(Name="oracles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oracles")]
    public List<OracleResult> Oracles { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BlockResult {\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  PreviousHash: ").Append(PreviousHash).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  Height: ").Append(Height).Append("\n");
      sb.Append("  ChainAddress: ").Append(ChainAddress).Append("\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      sb.Append("  Txs: ").Append(Txs).Append("\n");
      sb.Append("  ValidatorAddress: ").Append(ValidatorAddress).Append("\n");
      sb.Append("  Reward: ").Append(Reward).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
      sb.Append("  Oracles: ").Append(Oracles).Append("\n");
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
