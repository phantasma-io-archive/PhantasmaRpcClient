using System;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetAuctions : RpcRequestResponseHandler<PaginatedAuctionsDto>
    {
        public PhantasmaGetAuctions(IClient client) : base(client, ApiMethods.getAuctions.ToString()) { }

        public Task<PaginatedAuctionsDto> SendRequestAsync(int page, int pageSize, string tokenSymbol = null, object id = null)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (pageSize <= 0) throw new ArgumentOutOfRangeException(nameof(pageSize));

            if (string.IsNullOrEmpty(tokenSymbol))
            {
                return SendRequestAsync(id);
            }
            return SendRequestAsync(id, tokenSymbol);
        }

        public RpcRequest BuildRequest(int page, int pageSize, string tokenSymbol = null, object id = null)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (pageSize <= 0) throw new ArgumentOutOfRangeException(nameof(pageSize));

            if (string.IsNullOrEmpty(tokenSymbol))
            {
                return BuildRequest(id);
            }
            return BuildRequest(id, tokenSymbol);
        }
    }
}
