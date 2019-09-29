using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Phantasma.RpcClient.DTOs
{
    public class SwapForAddressDto
    {
        [JsonProperty("sourceHash")]
        public string SourceHash { get; set; }

        [JsonProperty("sourcePlatform")]
        public string SourcePlatform { get; set; }

        [JsonProperty("sourceAddress")]
        public string SourceAddress { get; set; }

        [JsonProperty("destinationHash")]
        public string DestinationHash { get; set; }

        [JsonProperty("destinationPlatform")]
        public string DestinationPlatform { get; set; }

        [JsonProperty("destinationAddress")]
        public string DestinationAddress { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("decimals")]
        public int Decimals { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ChainSwapStatus Status { get; set; }
    }

    public enum ChainSwapStatus
    {
        Invalid,
        Pending,
        Sending,
        Link,
        Settle,
        Resettle,
        Broker,
        Receive,
        Platform,
        Finished
    }
}
