using System.Threading.Tasks;
using Phantasma.RpcClient.Client;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetAuctionCount : RpcRequestResponseHandler<int>
    {
        public PhantasmaGetAuctionCount(IClient client) : base(client, ApiMethods.getAuctionsCount.ToString()) { }

        public Task<int> SendRequestAsync(string tokenSymbol = null, object id = null)
        {
            return string.IsNullOrEmpty(tokenSymbol) ? SendRequestAsync(id) : SendRequestAsync(id, tokenSymbol);
        }

        public RpcRequest BuildRequest(string tokenSymbol = null, object id = null)
        {
            return string.IsNullOrEmpty(tokenSymbol) ? BuildRequest(id) : BuildRequest(id, tokenSymbol);
        }
    }
}
