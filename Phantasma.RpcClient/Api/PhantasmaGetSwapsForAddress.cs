using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetSwapsForAddress : RpcRequestResponseHandler<List<SwapForAddressDto>>
    {
        public PhantasmaGetSwapsForAddress(IClient client) : base(client, ApiMethods.getSwapsForAddress.ToString()) { }

        public Task<List<SwapForAddressDto>> SendRequestAsync(string address, object id = null)
        {
            if (address == null) throw new ArgumentNullException(nameof(address));
            return SendRequestAsync(id, address);
        }

        public RpcRequest BuildRequest(string address, object id = null)
        {
            if (address == null) throw new ArgumentNullException(nameof(address));
            return BuildRequest(id, address);
        }
    }
}