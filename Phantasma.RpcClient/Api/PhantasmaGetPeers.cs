using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;
using Phantasma.RpcClient.Infrastructure;
using System.Collections.Generic;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetPeers : GenericRpcRequestResponseHandlerNoParam<IList<PeerDto>>
    {
        public PhantasmaGetPeers(IClient client) : base(client, ApiMethods.getPeers.ToString()) { }
    }
}
