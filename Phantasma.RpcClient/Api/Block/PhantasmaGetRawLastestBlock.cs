using System;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetRawLatestBlock: RpcRequestResponseHandler<string>
    {
        public PhantasmaGetRawLatestBlock(IClient client) : base(client, ApiMethods.getRawLatestBlock.ToString()) { }

        public Task<string> SendRequestAsync(string chain, object id = null)
        {
            if (chain == null) throw new ArgumentNullException(nameof(chain));
            return SendRequestAsync(id, chain);
        }
        
        public string SendRequest(string chain, object id = null)
        {
            if (chain == null) throw new ArgumentNullException(nameof(chain));
            return SendRequest(id, chain);
        }

        public RpcRequest BuildRequest(string hash, object id = null)
        {
            if (hash == null) throw new ArgumentNullException(nameof(hash));
            return BuildRequest(id, hash);
        }
    }
}
