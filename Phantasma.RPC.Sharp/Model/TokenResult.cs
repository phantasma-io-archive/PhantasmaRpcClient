using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class TokenResult
    {
        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Decimals
        /// </summary>
        [DataMember(Name = "decimals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "decimals")]
        public int? Decimals { get; set; }

        /// <summary>
        /// Gets or Sets CurrentSupply
        /// </summary>
        [DataMember(Name = "currentSupply", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentSupply")]
        public string CurrentSupply { get; set; }

        /// <summary>
        /// Gets or Sets MaxSupply
        /// </summary>
        [DataMember(Name = "maxSupply", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "maxSupply")]
        public string MaxSupply { get; set; }

        /// <summary>
        /// Gets or Sets BurnedSupply
        /// </summary>
        [DataMember(Name = "burnedSupply", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "burnedSupply")]
        public string BurnedSupply { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "flags")]
        public string Flags { get; set; }

        /// <summary>
        /// Gets or Sets Script
        /// </summary>
        [DataMember(Name = "script", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "script")]
        public string Script { get; set; }

        /// <summary>
        /// Gets or Sets Series
        /// </summary>
        [DataMember(Name = "series", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "series")]
        public List<TokenSeriesResult> Series { get; set; }

        /// <summary>
        /// Gets or Sets External
        /// </summary>
        [DataMember(Name = "external", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "external")]
        public List<TokenExternalResult> External { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "price")]
        public List<TokenPriceResult> Price { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenResult {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
            sb.Append("  CurrentSupply: ").Append(CurrentSupply).Append("\n");
            sb.Append("  MaxSupply: ").Append(MaxSupply).Append("\n");
            sb.Append("  BurnedSupply: ").Append(BurnedSupply).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Script: ").Append(Script).Append("\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
            sb.Append("  External: ").Append(External).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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