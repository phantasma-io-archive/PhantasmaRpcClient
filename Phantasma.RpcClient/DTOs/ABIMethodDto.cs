using System.Collections.Generic;
using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class ABIMethodDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("returnType")]
        public string ReturnType { get; set; }

        [JsonProperty("parameters")]
        public List<ABIMethodParamDto> Parameters { get; set; } = new List<ABIMethodParamDto>();

    }
}

