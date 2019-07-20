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

        [JsonProperty("confirmations")]
        public uint Confirmations { get; set; }

        [JsonProperty("blockHeight")]
        public uint BlockHeight { get; set; }

        [JsonProperty("blockHash")]
        public string BlockHash { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("events")]
        public List<EventDto> Events { get; set; }

        [JsonProperty("fee")]
        public string Fee { get; set; }
    }
}
