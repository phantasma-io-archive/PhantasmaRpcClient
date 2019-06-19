using System.Threading.Tasks;
using Phantasma.RpcClient.Client;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetAuctionCount : RpcRequestResponseHandler<int>
    {
        public PhantasmaGetAuctionCount(IClient client) : base(client, ApiMethods.getAuctionsCount.ToString()) { }

        public Task<int> SendRequestAsync(string chain, string tokenSymbol = null, object id = null)
        {
            return SendRequestAsync(id, chain, tokenSymbol);
        }

        public RpcRequest BuildRequest(string chain, string tokenSymbol = null, object id = null)
        {
            return BuildRequest(id, chain, tokenSymbol);
        }
    }
}
