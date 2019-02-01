using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Phantasma.RpcClient.DTOs
{
    public class EventDto
    {
        [JsonProperty("address")]
        public string EventAddress { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EventKind EventKind { get; set; }
    }

    public enum EventKind
    {
        ChainCreate,
        TokenCreate,
        TokenSend,
        TokenReceive,
        TokenMint,
        TokenBurn,
        TokenEscrow,
        TokenStake,
        TokenUnstake,
        AddressRegister,
        FriendAdd,
        FriendRemove,
        GasEscrow,
        GasPayment,
        AuctionCreated,
        AuctionCancelled,
        AuctionFilled,
        Metadata,
    }
}
