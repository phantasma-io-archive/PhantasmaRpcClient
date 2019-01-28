using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class AuctionDto
    {
        [JsonProperty("creatorAddress")]
        public string CreatorAddress;

        [JsonProperty("startDate")]
        public uint StartDate;

        [JsonProperty("endDate")]
        public uint EndDate;

        [JsonProperty("baseSymbol")]
        public string BaseSymbol;

        [JsonProperty("quoteSymbol")]
        public string QuoteSymbol;

        [JsonProperty("TokenID")]
        public string TokenId;

        [JsonProperty("Price")]
        public string Price;
    }
}
