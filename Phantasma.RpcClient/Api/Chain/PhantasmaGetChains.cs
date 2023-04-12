﻿using System.Collections.Generic;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;
using Phantasma.RpcClient.Infrastructure;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetChains : GenericRpcRequestResponseHandlerNoParam<IList<ChainDto>>
    {
        public PhantasmaGetChains(IClient client) : base(client, ApiMethods.getChains.ToString()) { }
    }
}
