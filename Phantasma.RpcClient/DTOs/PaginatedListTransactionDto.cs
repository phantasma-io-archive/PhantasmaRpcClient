using System.Collections.Generic;
using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class PaginatedListTransactionDto
    {
        [JsonProperty("results")]
        public List<TransactionDto> AccountTransactionsDto { get; set; }

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
