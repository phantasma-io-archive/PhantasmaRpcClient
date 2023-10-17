using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ChainResult
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parent")]
        public string Parent { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "organization")]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or Sets Contracts
        /// </summary>
        [DataMember(Name = "contracts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contracts")]
        public List<string> Contracts { get; set; }

        /// <summary>
        /// Gets or Sets Dapps
        /// </summary>
        [DataMember(Name = "dapps", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dapps")]
        public List<string> Dapps { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChainResult {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Contracts: ").Append(Contracts).Append("\n");
            sb.Append("  Dapps: ").Append(Dapps).Append("\n");
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