using System;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetAuction : RpcRequestResponseHandler<AuctionDto>
    {
        public PhantasmaGetAuction(IClient client) : base(client, ApiMethods.getAuction.ToString()) { }

        public Task<AuctionDto> SendRequestAsync(string chain, string symbol, int page, int pageSize, object id = null)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (pageSize <= 0) throw new ArgumentOutOfRangeException(nameof(pageSize));

            return SendRequestAsync(id, chain, symbol, page, pageSize);
        }

        public AuctionDto SendRequest(string chain, string symbol, int page, int pageSize, object id = null)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (pageSize <= 0) throw new ArgumentOutOfRangeException(nameof(pageSize));

            return SendRequest(id, chain, symbol, page, pageSize);
        }
        public RpcRequest BuildRequest(string chain, string symbol, int page, int pageSize, object id = null)
        {
            if (page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (pageSize <= 0) throw new ArgumentOutOfRangeException(nameof(pageSize));

            return BuildRequest(id, chain, symbol, page, pageSize);
        }
    }
}
