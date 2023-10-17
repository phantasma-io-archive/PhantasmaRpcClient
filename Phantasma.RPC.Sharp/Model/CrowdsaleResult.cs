using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CrowdsaleResult
    {
        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "flags")]
        public string Flags { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startDate")]
        public int? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endDate")]
        public int? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets SellSymbol
        /// </summary>
        [DataMember(Name = "sellSymbol", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sellSymbol")]
        public string SellSymbol { get; set; }

        /// <summary>
        /// Gets or Sets ReceiveSymbol
        /// </summary>
        [DataMember(Name = "receiveSymbol", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "receiveSymbol")]
        public string ReceiveSymbol { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "price")]
        public int? Price { get; set; }

        /// <summary>
        /// Gets or Sets GlobalSoftCap
        /// </summary>
        [DataMember(Name = "globalSoftCap", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "globalSoftCap")]
        public string GlobalSoftCap { get; set; }

        /// <summary>
        /// Gets or Sets GlobalHardCap
        /// </summary>
        [DataMember(Name = "globalHardCap", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "globalHardCap")]
        public string GlobalHardCap { get; set; }

        /// <summary>
        /// Gets or Sets UserSoftCap
        /// </summary>
        [DataMember(Name = "userSoftCap", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "userSoftCap")]
        public string UserSoftCap { get; set; }

        /// <summary>
        /// Gets or Sets UserHardCap
        /// </summary>
        [DataMember(Name = "userHardCap", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "userHardCap")]
        public string UserHardCap { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrowdsaleResult {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  SellSymbol: ").Append(SellSymbol).Append("\n");
            sb.Append("  ReceiveSymbol: ").Append(ReceiveSymbol).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  GlobalSoftCap: ").Append(GlobalSoftCap).Append("\n");
            sb.Append("  GlobalHardCap: ").Append(GlobalHardCap).Append("\n");
            sb.Append("  UserSoftCap: ").Append(UserSoftCap).Append("\n");
            sb.Append("  UserHardCap: ").Append(UserHardCap).Append("\n");
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