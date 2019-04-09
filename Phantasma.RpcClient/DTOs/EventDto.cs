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
        AuctionCreated = 17,
        AuctionCancelled = 18,
        AuctionFilled = 19,
        Metadata = 20,
        AddFriend = 21,
        RemoveFriend = 22,

        // Nachomen Events -> Remover later
        Transfer = 23,
        Deposit = 24,
        Withdraw = 25,
        WrestlerReceived = 26,
        Purchase = 27,
        ItemAdded = 28,
        ItemRemoved = 39,
        ItemReceived = 30,
        ItemSpent = 31,
        ItemActivated = 32,
        ItemUnwrapped = 33,
        Stance = 34,
        StatusAdded = 35,
        StatusRemoved = 36,
        Buff = 37,
        Debuff = 38,
        Experience = 39,
        Unlock = 40,
        Rename = 41,
        Auto = 42,
        Pot = 43,
        Referral = 44,
        Trophy = 45,
        Confusion = 46,
        MoveMiss = 47,
        SelectAvatar = 48,
    }
}
