using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;
using Phantasma.RpcClient.Infrastructure;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetOrganizations : RpcRequestResponseHandler<IList<OrganizationDto>>
    {
        public PhantasmaGetOrganizations(IClient client) : base(client, ApiMethods.getOrganizations.ToString()) { }
        
        public Task<IList<OrganizationDto>> SendRequestAsync(bool extended, object id = null)
        {
            return SendRequestAsync(id, extended);
        }
        
        public IList<OrganizationDto> SendRequest(bool extended = false, object id = null)
        {
            return SendRequest(id, extended);
        }

        public RpcRequest BuildRequest(bool extended = false, object id = null)
        {
            return BuildRequest(id, extended);
        }
    }
}
