using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class AuctionResult
    {
        /// <summary>
        /// Gets or Sets CreatorAddress
        /// </summary>
        [DataMember(Name = "creatorAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creatorAddress")]
        public string CreatorAddress { get; set; }

        /// <summary>
        /// Gets or Sets ChainAddress
        /// </summary>
        [DataMember(Name = "chainAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "chainAddress")]
        public string ChainAddress { get; set; }

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
        /// Gets or Sets BaseSymbol
        /// </summary>
        [DataMember(Name = "baseSymbol", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "baseSymbol")]
        public string BaseSymbol { get; set; }

        /// <summary>
        /// Gets or Sets QuoteSymbol
        /// </summary>
        [DataMember(Name = "quoteSymbol", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quoteSymbol")]
        public string QuoteSymbol { get; set; }

        /// <summary>
        /// Gets or Sets TokenId
        /// </summary>
        [DataMember(Name = "tokenId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenId")]
        public string TokenId { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }

        /// <summary>
        /// Gets or Sets EndPrice
        /// </summary>
        [DataMember(Name = "endPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endPrice")]
        public string EndPrice { get; set; }

        /// <summary>
        /// Gets or Sets ExtensionPeriod
        /// </summary>
        [DataMember(Name = "extensionPeriod", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "extensionPeriod")]
        public string ExtensionPeriod { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Rom
        /// </summary>
        [DataMember(Name = "rom", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rom")]
        public string Rom { get; set; }

        /// <summary>
        /// Gets or Sets Ram
        /// </summary>
        [DataMember(Name = "ram", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ram")]
        public string Ram { get; set; }

        /// <summary>
        /// Gets or Sets ListingFee
        /// </summary>
        [DataMember(Name = "listingFee", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "listingFee")]
        public string ListingFee { get; set; }

        /// <summary>
        /// Gets or Sets CurrentWinner
        /// </summary>
        [DataMember(Name = "currentWinner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentWinner")]
        public string CurrentWinner { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuctionResult {\n");
            sb.Append("  CreatorAddress: ").Append(CreatorAddress).Append("\n");
            sb.Append("  ChainAddress: ").Append(ChainAddress).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  BaseSymbol: ").Append(BaseSymbol).Append("\n");
            sb.Append("  QuoteSymbol: ").Append(QuoteSymbol).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  EndPrice: ").Append(EndPrice).Append("\n");
            sb.Append("  ExtensionPeriod: ").Append(ExtensionPeriod).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Rom: ").Append(Rom).Append("\n");
            sb.Append("  Ram: ").Append(Ram).Append("\n");
            sb.Append("  ListingFee: ").Append(ListingFee).Append("\n");
            sb.Append("  CurrentWinner: ").Append(CurrentWinner).Append("\n");
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