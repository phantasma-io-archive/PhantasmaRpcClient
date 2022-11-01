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
  public class TokenPriceResult {
    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public int? Timestamp { get; set; }

    /// <summary>
    /// Gets or Sets Open
    /// </summary>
    [DataMember(Name="open", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open")]
    public string Open { get; set; }

    /// <summary>
    /// Gets or Sets High
    /// </summary>
    [DataMember(Name="high", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "high")]
    public string High { get; set; }

    /// <summary>
    /// Gets or Sets Low
    /// </summary>
    [DataMember(Name="low", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "low")]
    public string Low { get; set; }

    /// <summary>
    /// Gets or Sets Close
    /// </summary>
    [DataMember(Name="close", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "close")]
    public string Close { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TokenPriceResult {\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  Open: ").Append(Open).Append("\n");
      sb.Append("  High: ").Append(High).Append("\n");
      sb.Append("  Low: ").Append(Low).Append("\n");
      sb.Append("  Close: ").Append(Close).Append("\n");
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
