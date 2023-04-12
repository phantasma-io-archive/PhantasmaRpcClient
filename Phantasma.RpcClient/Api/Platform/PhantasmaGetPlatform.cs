using System.Collections.Generic;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;
using Phantasma.RpcClient.Infrastructure;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetPlatform : GenericRpcRequestResponseHandlerNoParam<PlatformDto>
    {
        public PhantasmaGetPlatform(IClient client) : base(client, ApiMethods.getPlatform.ToString()) { }
    }
}