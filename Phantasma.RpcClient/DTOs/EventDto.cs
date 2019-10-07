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
        Unknown = 0,
        ChainCreate = 1,
        BlockCreate = 2,
        BlockClose = 3,
        TokenCreate = 4,
        TokenSend = 5,
        TokenReceive = 6,
        TokenMint = 7,
        TokenBurn = 8,
        TokenStake = 9,
        TokenUnstake = 10,
        TokenClaim = 11,
        RoleDemote = 12,
        RolePromote = 13,
        AddressRegister = 14,
        AddressLink = 15,
        AddressUnlink = 16,
        GasEscrow = 17,
        GasPayment = 18,
        GasLoan = 19,
        OrderCreated = 20,
        OrderCancelled = 21,
        OrderFilled = 22,
        OrderClosed = 23,
        FeedCreate = 24,
        FeedUpdate = 25,
        FileCreate = 26,
        FileDelete = 27,
        ValidatorPropose = 28,
        ValidatorElect = 29,
        ValidatorRemove = 30,
        ValidatorSwitch = 31,
        PackedNFT = 32,
        ValueCreate = 33,
        ValueUpdate = 34,
        PollCreated = 35,
        PollClosed = 36,
        PollVote = 37,
        ChannelCreate = 38,
        ChannelRefill = 39,
        ChannelSettle = 40,
        LeaderboardCreate = 40,
        LeaderboardInsert = 41,
        LeaderboardReset = 42,
        PlatformCreate = 43,
        TransactionSettle = 44,
        ContractRegister = 45,
        ContractDeploy = 46,
        Custom = 64,
    }
}
