using System.Collections.Generic;
using Newtonsoft.Json;
using Phantasma.RpcClient.Helpers;

namespace Phantasma.RpcClient.DTOs
{
    public class BlockDto
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("previousHash")]
        public string PreviousHash { get; set; }

        [JsonProperty("timestamp")]
        public uint Timestamp { get; set; }

        [JsonProperty("height")]
        public uint Height { get; set; }

        [JsonProperty("chainAddress")]
        public string ChainAddress { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("txs")]
        public List<TransactionDto> Txs { get; set; }

        [JsonProperty("validatorAddress")]
        public string ValidatorAddress { get; set; }

        [JsonProperty("reward")]
        public string Reward { get; set; }


        public static BlockDto FromJson(string json) => JsonConvert.DeserializeObject<BlockDto>(json, JsonUtils.Settings);

        public string ToJson() => JsonConvert.SerializeObject(this, JsonUtils.Settings);
    }
}
