using System;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetAddressTxs : RpcRequestResponseHandler<PaginatedAccountTransactionsDto>
    {
        public PhantasmaGetAddressTxs(IClient client) : base(client, ApiMethods.getAddressTransactions.ToString()) { }

        public Task<PaginatedAccountTransactionsDto> SendRequestAsync(string address, int page, int pageSize, object id = null)
        {
            if (address == null) throw new ArgumentNullException(nameof(address));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (pageSize <= 0) throw new ArgumentOutOfRangeException(nameof(pageSize));

            return SendRequestAsync(id, address, page, pageSize);
        }

        public RpcRequest BuildRequest(string address, int page, int pageSize, object id = null)
        {
            if (address == null) throw new ArgumentNullException(nameof(address));
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (pageSize <= 0) throw new ArgumentOutOfRangeException(nameof(pageSize));

            return BuildRequest(id, address, page, pageSize);
        }
    }
}
