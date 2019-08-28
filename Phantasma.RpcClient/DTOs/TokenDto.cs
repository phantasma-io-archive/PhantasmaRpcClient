using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class TokenDto
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("decimals")]
        public int Decimals { get; set; }

        [JsonProperty("currentSupply")]
        public string CurrentSupply { get; set; }

        [JsonProperty("maxSupply")]
        public string MaxSupply { get; set; }

        [JsonProperty("ownerAddress")]
        public string OwnerAddress { get; set; }

        [JsonProperty("flags")]
        public TokenFlags Flags { get; set; }

        [JsonProperty("metadataList")]
        public List<TokenMetadataDto> MetadataList { get; set; }
    }

    [Flags]
    public enum TokenFlags
    {
        None = 0,
        Transferable = 1 << 0,
        Fungible = 1 << 1,
        Finite = 1 << 2,
        Divisible = 1 << 3,
        Fuel = 1 << 4,
        Stakable = 1 << 5,
        Stable = 1 << 6,
        External = 1 << 7,
        Burnable = 1 << 8,
        Swappable = 1 << 9,
    }
}
