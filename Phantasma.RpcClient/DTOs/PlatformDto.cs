using Newtonsoft.Json;
using System.Collections.Generic;

namespace Phantasma.RpcClient.DTOs
{
    public class PlatformDto
    {
        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("chain")]
        public string ChainAddress { get; set; }

        [JsonProperty("fuel")]
        public string FuelSymbol { get; set; }

        [JsonProperty("interop")]
        public string Interop { get; set; }

        [JsonProperty("tokens")]
        public List<string> Tokens { get; set; }
    }

    public class Interop
    {
        [JsonProperty("local")]
        public string Local { get; set; }

        [JsonProperty("external")]
        public string External { get; set; }
    }
}
