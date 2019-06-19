using Newtonsoft.Json;
using System.Collections.Generic;

namespace Phantasma.RpcClient.DTOs
{
    public class ChainDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("parentAddress")]
        public string ParentAddress { get; set; }

        [JsonProperty("height")]
        public uint Height { get; set; }

        [JsonProperty("contracts")]
        public IList<string> Contracts { get; set; }
    }
}
