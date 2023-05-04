using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class StorageResult {
    /// <summary>
    /// Gets or Sets Available
    /// </summary>
    [DataMember(Name="available", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "available")]
    public int? Available { get; set; }

    /// <summary>
    /// Gets or Sets Used
    /// </summary>
    [DataMember(Name="used", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "used")]
    public int? Used { get; set; }

    /// <summary>
    /// Gets or Sets Avatar
    /// </summary>
    [DataMember(Name="avatar", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatar")]
    public string Avatar { get; set; }

    /// <summary>
    /// Gets or Sets Archives
    /// </summary>
    [DataMember(Name="archives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archives")]
    public List<ArchiveResult> Archives { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StorageResult {\n");
      sb.Append("  Available: ").Append(Available).Append("\n");
      sb.Append("  Used: ").Append(Used).Append("\n");
      sb.Append("  Avatar: ").Append(Avatar).Append("\n");
      sb.Append("  Archives: ").Append(Archives).Append("\n");
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
