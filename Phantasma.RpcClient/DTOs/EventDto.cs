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
        ChainCreate = 0,
        TokenCreate = 1,
        TokenSend = 2,
        TokenReceive = 3,
        TokenMint = 4,
        TokenBurn = 5,
        TokenEscrow = 6,
        TokenStake = 7,
        TokenUnstake = 8,
        TokenClaim = 9,
        MasterDemote = 10,
        MasterPromote = 11,
        AddressRegister = 12,
        AddressAdd = 13,
        AddressRemove = 14,
        GasEscrow = 15,
        GasPayment = 16,
        OrderCreated = 17,
        OrderCancelled = 18,
        OrderFilled = 19,
        OrderClosed = 20,
        AddFriend = 21,
        RemoveFriend = 22,
        Metadata = 23,
        Custom = 24,
    }
}
