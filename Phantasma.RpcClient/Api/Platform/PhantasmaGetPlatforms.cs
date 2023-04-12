using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;
using Phantasma.RpcClient.Infrastructure;
using System.Collections.Generic;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetPlatforms : GenericRpcRequestResponseHandlerNoParam<IList<PlatformDto>>
    {
        public PhantasmaGetPlatforms(IClient client) : base(client, ApiMethods.getPlatforms.ToString()) { }
    }
}
