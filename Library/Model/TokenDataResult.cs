using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TokenDataResult {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Series
    /// </summary>
    [DataMember(Name="series", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "series")]
    public string Series { get; set; }

    /// <summary>
    /// Gets or Sets Mint
    /// </summary>
    [DataMember(Name="mint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mint")]
    public string Mint { get; set; }

    /// <summary>
    /// Gets or Sets ChainName
    /// </summary>
    [DataMember(Name="chainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chainName")]
    public string ChainName { get; set; }

    /// <summary>
    /// Gets or Sets OwnerAddress
    /// </summary>
    [DataMember(Name="ownerAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerAddress")]
    public string OwnerAddress { get; set; }

    /// <summary>
    /// Gets or Sets CreatorAddress
    /// </summary>
    [DataMember(Name="creatorAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creatorAddress")]
    public string CreatorAddress { get; set; }

    /// <summary>
    /// Gets or Sets Ram
    /// </summary>
    [DataMember(Name="ram", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ram")]
    public string Ram { get; set; }

    /// <summary>
    /// Gets or Sets Rom
    /// </summary>
    [DataMember(Name="rom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rom")]
    public string Rom { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets Infusion
    /// </summary>
    [DataMember(Name="infusion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "infusion")]
    public List<TokenPropertyResult> Infusion { get; set; }

    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<TokenPropertyResult> Properties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TokenDataResult {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Series: ").Append(Series).Append("\n");
      sb.Append("  Mint: ").Append(Mint).Append("\n");
      sb.Append("  ChainName: ").Append(ChainName).Append("\n");
      sb.Append("  OwnerAddress: ").Append(OwnerAddress).Append("\n");
      sb.Append("  CreatorAddress: ").Append(CreatorAddress).Append("\n");
      sb.Append("  Ram: ").Append(Ram).Append("\n");
      sb.Append("  Rom: ").Append(Rom).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Infusion: ").Append(Infusion).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
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
