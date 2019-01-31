using System.Collections.Generic;
using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class PaginatedAuctionsDto
    {
        [JsonProperty("result")]
        public List<AuctionDto> AuctionsList { get; set; }

        [JsonProperty("page")]
        public uint Page { get; set; }

        [JsonProperty("pageSize")]
        public uint PageSize { get; set; }

        [JsonProperty("total")]
        public uint Total { get; set; }

        [JsonProperty("totalPages")]
        public uint TotalPages { get; set; }
    }
}
