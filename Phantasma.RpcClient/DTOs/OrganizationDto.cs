using Newtonsoft.Json;
using System.Collections.Generic;

namespace Phantasma.RpcClient.DTOs
{
    public class OrganizationDto
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("members")]
        public IList<string> Members { get; set; }
        
    }
}
