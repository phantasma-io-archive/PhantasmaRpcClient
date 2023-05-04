using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PaginatedResult {
    /// <summary>
    /// Gets or Sets Page
    /// </summary>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public int? Page { get; set; }

    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    [DataMember(Name="pageSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageSize")]
    public int? PageSize { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }

    /// <summary>
    /// Gets or Sets TotalPages
    /// </summary>
    [DataMember(Name="totalPages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalPages")]
    public int? TotalPages { get; set; }

    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    [DataMember(Name="result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "result")]
    public object Result { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaginatedResult {\n");
      sb.Append("  Page: ").Append(Page).Append("\n");
      sb.Append("  PageSize: ").Append(PageSize).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
      sb.Append("  Result: ").Append(Result).Append("\n");
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
