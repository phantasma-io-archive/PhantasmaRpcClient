using System.Collections.Generic;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetAuctions : GenericRpcRequestResponseHandlerNoParam<IList<AuctionDto>>
    {
        public PhantasmaGetAuctions(IClient client) : base(client, ApiMethods.getAuctions.ToString()) { }
    }
}
