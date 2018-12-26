using System;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;

namespace Phantasma.RpcClient.Api
{
   public class PhantasmaGetBlockByHash : RpcRequestResponseHandler<BlockDto>
    {
        public PhantasmaGetBlockByHash(IClient client) : base(client, ApiMethods.getBlockByHash.ToString()) { }

        public Task<BlockDto> SendRequestAsync(string hash, object id = null)
        {
            if (hash == null) throw new ArgumentNullException(nameof(hash));
            return SendRequestAsync(id, hash);
        }

        public RpcRequest BuildRequest(string hash, object id = null)
        {
            if (hash == null) throw new ArgumentNullException(nameof(hash));
            return BuildRequest(id, hash);
        }
    }
}
