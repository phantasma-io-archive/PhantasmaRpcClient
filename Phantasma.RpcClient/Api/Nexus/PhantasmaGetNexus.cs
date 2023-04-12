using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;
using Phantasma.RpcClient.Infrastructure;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetNexus : RpcRequestResponseHandler<NexusDto>
    {
        public PhantasmaGetNexus(IClient client) : base(client, ApiMethods.getNexus.ToString()) { }
        
        public Task<NexusDto> SendRequestAsync(bool extended = false, object id = null)
        {
            return SendRequestAsync(id, extended);
        }
        
        public NexusDto SendRequest(bool extended = false, object id = null)
        {
            return SendRequest(id, extended);
        }

        public RpcRequest BuildRequest(bool extended = false, object id = null)
        {
            return BuildRequest(id, extended);
        }
    }
}
