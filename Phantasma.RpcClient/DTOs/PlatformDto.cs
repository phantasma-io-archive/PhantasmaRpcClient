using Newtonsoft.Json;
using System.Collections.Generic;

namespace Phantasma.RpcClient.DTOs
{
    public class PlatformDto
    {
        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("interop")]
        public string Interop { get; set; }

        [JsonProperty("tokens")]
        public List<string> Tokens { get; set; }
    }
}
