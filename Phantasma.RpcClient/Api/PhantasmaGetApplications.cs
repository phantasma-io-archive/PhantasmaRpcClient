using System.Collections.Generic;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;
using Phantasma.RpcClient.Infrastructure;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetApplications : GenericRpcRequestResponseHandlerNoParam<List<AppDto>>
    {
        public PhantasmaGetApplications(IClient client) : base(client, ApiMethods.getApps.ToString()) { }
    }
}
