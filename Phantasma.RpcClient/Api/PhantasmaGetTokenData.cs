using System;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetTokenData : RpcRequestResponseHandler<TokenData>
    {
        public PhantasmaGetTokenData(IClient client) : base(client, ApiMethods.getTokenData.ToString()) { }

        public Task<TokenData> SendRequestAsync(string tokenSymbol, string tokenId, object id = null)
        {
            if (tokenSymbol == null) throw new ArgumentNullException(nameof(tokenSymbol));
            if (tokenId == null) throw new ArgumentNullException(nameof(tokenId));

            return SendRequestAsync(id, tokenSymbol);
        }

        public RpcRequest BuildRequest(string tokenSymbol, string tokenId, object id = null)
        {
            if (tokenSymbol == null) throw new ArgumentNullException(nameof(tokenSymbol));
            if (tokenId == null) throw new ArgumentNullException(nameof(tokenId));

            return BuildRequest(id, tokenSymbol);
        }
    }
}
