using System.Collections.Generic;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetAuctions : RpcRequestResponseHandler<IList<AuctionDto>>
    {
        public PhantasmaGetAuctions(IClient client) : base(client, ApiMethods.getAuctions.ToString()) { }

        public Task<IList<AuctionDto>> SendRequestAsync(string tokenSymbol = null, object id = null)
        {
            if (string.IsNullOrEmpty(tokenSymbol))
            {
                return SendRequestAsync(id);
            }
            return SendRequestAsync(id, tokenSymbol);
        }

        public RpcRequest BuildRequest(string tokenSymbol = null, object id = null)
        {
            if (string.IsNullOrEmpty(tokenSymbol))
            {
                return BuildRequest(id);
            }
            return BuildRequest(id, tokenSymbol);
        }
    }
}
