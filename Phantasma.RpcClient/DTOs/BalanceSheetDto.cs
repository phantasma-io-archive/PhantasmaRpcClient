using System.Collections.Generic;
using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class BalanceSheetDto
    {
        [JsonProperty("chain")]
        public string ChainName { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("decimals")]
        public int Decimals { get; set; }

        [JsonProperty("ids")]
        public List<string> Ids { get; set; } = new List<string>();
    }
}
