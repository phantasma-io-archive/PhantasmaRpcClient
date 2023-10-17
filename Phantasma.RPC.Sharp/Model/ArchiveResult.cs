using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ArchiveResult
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "time")]
        public int? Time { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

        /// <summary>
        /// Gets or Sets Encryption
        /// </summary>
        [DataMember(Name = "encryption", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "encryption")]
        public string Encryption { get; set; }

        /// <summary>
        /// Gets or Sets BlockCount
        /// </summary>
        [DataMember(Name = "blockCount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "blockCount")]
        public int? BlockCount { get; set; }

        /// <summary>
        /// Gets or Sets MissingBlocks
        /// </summary>
        [DataMember(Name = "missingBlocks", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "missingBlocks")]
        public List<int?> MissingBlocks { get; set; }

        /// <summary>
        /// Gets or Sets Owners
        /// </summary>
        [DataMember(Name = "owners", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "owners")]
        public List<string> Owners { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchiveResult {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Encryption: ").Append(Encryption).Append("\n");
            sb.Append("  BlockCount: ").Append(BlockCount).Append("\n");
            sb.Append("  MissingBlocks: ").Append(MissingBlocks).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}