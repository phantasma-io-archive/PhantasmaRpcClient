using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class TokenData
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("chainAddress")]
        public string ChainAddress { get; set; }

        [JsonProperty("ownerAddress")]
        public string OwnerAddress { get; set; }

        [JsonProperty("ram")]
        public string Ram { get; set; }

        [JsonProperty("rom")]
        public string Rom { get; set; }
    }
}
