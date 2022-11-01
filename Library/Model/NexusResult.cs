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
  public class NexusResult {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Protocol
    /// </summary>
    [DataMember(Name="protocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocol")]
    public int? Protocol { get; set; }

    /// <summary>
    /// Gets or Sets Platforms
    /// </summary>
    [DataMember(Name="platforms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platforms")]
    public List<PlatformResult> Platforms { get; set; }

    /// <summary>
    /// Gets or Sets Tokens
    /// </summary>
    [DataMember(Name="tokens", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tokens")]
    public List<TokenResult> Tokens { get; set; }

    /// <summary>
    /// Gets or Sets Chains
    /// </summary>
    [DataMember(Name="chains", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chains")]
    public List<ChainResult> Chains { get; set; }

    /// <summary>
    /// Gets or Sets Governance
    /// </summary>
    [DataMember(Name="governance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "governance")]
    public List<GovernanceResult> Governance { get; set; }

    /// <summary>
    /// Gets or Sets Organizations
    /// </summary>
    [DataMember(Name="organizations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organizations")]
    public List<string> Organizations { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NexusResult {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      sb.Append("  Platforms: ").Append(Platforms).Append("\n");
      sb.Append("  Tokens: ").Append(Tokens).Append("\n");
      sb.Append("  Chains: ").Append(Chains).Append("\n");
      sb.Append("  Governance: ").Append(Governance).Append("\n");
      sb.Append("  Organizations: ").Append(Organizations).Append("\n");
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
