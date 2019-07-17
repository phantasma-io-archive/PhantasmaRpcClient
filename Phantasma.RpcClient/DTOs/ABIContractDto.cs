using System.Collections.Generic;
using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class ABIContractDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("methods")]
        public List<ABIMethodDto> Methods { get; set; } = new List<ABIMethodDto>();
    }
}

