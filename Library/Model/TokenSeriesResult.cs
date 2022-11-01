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
  public class TokenSeriesResult {
    /// <summary>
    /// Gets or Sets SeriesID
    /// </summary>
    [DataMember(Name="seriesID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seriesID")]
    public int? SeriesID { get; set; }

    /// <summary>
    /// Gets or Sets CurrentSupply
    /// </summary>
    [DataMember(Name="currentSupply", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentSupply")]
    public string CurrentSupply { get; set; }

    /// <summary>
    /// Gets or Sets MaxSupply
    /// </summary>
    [DataMember(Name="maxSupply", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxSupply")]
    public string MaxSupply { get; set; }

    /// <summary>
    /// Gets or Sets BurnedSupply
    /// </summary>
    [DataMember(Name="burnedSupply", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "burnedSupply")]
    public string BurnedSupply { get; set; }

    /// <summary>
    /// Gets or Sets Mode
    /// </summary>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public TokenSeriesMode Mode { get; set; }

    /// <summary>
    /// Gets or Sets Script
    /// </summary>
    [DataMember(Name="script", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "script")]
    public string Script { get; set; }

    /// <summary>
    /// Gets or Sets Methods
    /// </summary>
    [DataMember(Name="methods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "methods")]
    public List<ABIMethodResult> Methods { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TokenSeriesResult {\n");
      sb.Append("  SeriesID: ").Append(SeriesID).Append("\n");
      sb.Append("  CurrentSupply: ").Append(CurrentSupply).Append("\n");
      sb.Append("  MaxSupply: ").Append(MaxSupply).Append("\n");
      sb.Append("  BurnedSupply: ").Append(BurnedSupply).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  Script: ").Append(Script).Append("\n");
      sb.Append("  Methods: ").Append(Methods).Append("\n");
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
