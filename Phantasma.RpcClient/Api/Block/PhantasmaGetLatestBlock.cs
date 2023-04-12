using System;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;

namespace Phantasma.RpcClient.Api
{
   public class PhantasmaGetLatestBlock : RpcRequestResponseHandler<BlockDto>
    {
        public PhantasmaGetLatestBlock(IClient client) : base(client, ApiMethods.getLatestBlock.ToString()) { }

        public Task<BlockDto> SendRequestAsync(string chain, object id = null)
        {
            return SendRequestAsync(id, chain);
        }
        
        public BlockDto SendRequest(string chain, object id = null)
        {
            return SendRequest(id, chain);
        }

        public RpcRequest BuildRequest(string hash, object id = null)
        {
            if (hash == null) throw new ArgumentNullException(nameof(hash));
            return BuildRequest(id, hash);
        }
    }
}
