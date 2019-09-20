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

        [JsonProperty("contract")]
        public string Contract { get; set; }

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
        RoleDemote = 10,
        RolePromote = 11,
        AddressRegister = 12,
        AddressLink = 13,
        AddressUnlink = 14,
        GasEscrow = 15,
        GasPayment = 16,
        GasLend = 17,
        OrderCreated = 18,
        OrderCancelled = 19,
        OrderFilled = 20,
        OrderClosed = 21,
        FeedCreate = 22,
        FeedUpdate = 23,
        FileCreate = 24,
        FileDelete = 25,
        ValidatorAdd = 26,
        ValidatorRemove = 27,
        ValidatorUpdate = 28,
        BrokerRequest = 29,
        Metadata = 31,
        Custom = 32,
    }
}
