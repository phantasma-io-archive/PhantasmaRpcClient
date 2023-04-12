using System;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetTokenTransfers : RpcRequestResponseHandler<PaginatedListTransactionDto>
    {
        public PhantasmaGetTokenTransfers(IClient client) : base(client, ApiMethods.getTokenTransfers.ToString()) { }

        public Task<PaginatedListTransactionDto> SendRequestAsync(string tokenSymbol, int page, int pageSize, object id = null)
        {
            if (tokenSymbol == null) throw new ArgumentNullException(nameof(tokenSymbol));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (pageSize <= 0) throw new ArgumentOutOfRangeException(nameof(pageSize));

            return SendRequestAsync(id, tokenSymbol, page, pageSize);
        }

        public RpcRequest BuildRequest(string tokenSymbol, int page, int pageSize, object id = null)
        {
            if (tokenSymbol == null) throw new ArgumentNullException(nameof(tokenSymbol));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (pageSize <= 0) throw new ArgumentOutOfRangeException(nameof(pageSize));

            return BuildRequest(id, tokenSymbol, page, pageSize);
        }
    }
}
