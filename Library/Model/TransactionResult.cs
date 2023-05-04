using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TransactionResult {
    /// <summary>
    /// Gets or Sets Hash
    /// </summary>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public string Hash { get; set; }

    /// <summary>
    /// Gets or Sets ChainAddress
    /// </summary>
    [DataMember(Name="chainAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chainAddress")]
    public string ChainAddress { get; set; }

    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public int? Timestamp { get; set; }

    /// <summary>
    /// Gets or Sets BlockHeight
    /// </summary>
    [DataMember(Name="blockHeight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blockHeight")]
    public int? BlockHeight { get; set; }

    /// <summary>
    /// Gets or Sets BlockHash
    /// </summary>
    [DataMember(Name="blockHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blockHash")]
    public string BlockHash { get; set; }

    /// <summary>
    /// Gets or Sets Script
    /// </summary>
    [DataMember(Name="script", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "script")]
    public string Script { get; set; }

    /// <summary>
    /// Gets or Sets Payload
    /// </summary>
    [DataMember(Name="payload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payload")]
    public string Payload { get; set; }

    /// <summary>
    /// Gets or Sets Events
    /// </summary>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<EventResult> Events { get; set; }

    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    [DataMember(Name="result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "result")]
    public string Result { get; set; }

    /// <summary>
    /// Gets or Sets Fee
    /// </summary>
    [DataMember(Name="fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fee")]
    public string Fee { get; set; }

    /// <summary>
    /// Gets or Sets Signatures
    /// </summary>
    [DataMember(Name="signatures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signatures")]
    public List<SignatureResult> Signatures { get; set; }

    /// <summary>
    /// Gets or Sets Expiration
    /// </summary>
    [DataMember(Name="expiration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiration")]
    public int? Expiration { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionResult {\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  ChainAddress: ").Append(ChainAddress).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  BlockHeight: ").Append(BlockHeight).Append("\n");
      sb.Append("  BlockHash: ").Append(BlockHash).Append("\n");
      sb.Append("  Script: ").Append(Script).Append("\n");
      sb.Append("  Payload: ").Append(Payload).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
      sb.Append("  Result: ").Append(Result).Append("\n");
      sb.Append("  Fee: ").Append(Fee).Append("\n");
      sb.Append("  Signatures: ").Append(Signatures).Append("\n");
      sb.Append("  Expiration: ").Append(Expiration).Append("\n");
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
