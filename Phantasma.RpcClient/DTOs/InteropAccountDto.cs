using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class InteropAccountDto
    {
        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("interop")]
        public string InteropAddress { get; set; }
    }
}
