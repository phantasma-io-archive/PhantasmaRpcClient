using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class TxConfirmationDto
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("confirmations")]
        public uint Confirmations { get; set; }

        [JsonProperty("height")]
        public uint Height { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        public bool IsConfirmed => Confirmations >= 1;
    }
}
