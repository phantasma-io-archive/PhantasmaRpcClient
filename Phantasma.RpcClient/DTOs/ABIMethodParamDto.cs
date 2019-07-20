using System.Collections.Generic;
using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class ABIMethodParamDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("vmtype")]
        public string VMType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

