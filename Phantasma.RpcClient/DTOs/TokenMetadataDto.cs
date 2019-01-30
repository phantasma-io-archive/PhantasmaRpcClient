using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class TokenMetadataDto
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
