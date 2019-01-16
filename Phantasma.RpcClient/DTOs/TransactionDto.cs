using System.Collections.Generic;
using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class TransactionDto
    {
        [JsonProperty("hash")]
        public string Txid { get; set; }

        [JsonProperty("chainAddress")]
        public string ChainAddress { get; set; }

        [JsonProperty("timestamp")]
        public uint Timestamp { get; set; }

        [JsonProperty("blockHeight")]
        public uint BlockHeight { get; set; }

        //[JsonProperty("gasLimit")]
        //public decimal GasLimit { get; set; }

        //[JsonProperty("gasPrice")]
        //public decimal GasPrice { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("events")]
        public List<EventDto> Events { get; set; }
    }
}
