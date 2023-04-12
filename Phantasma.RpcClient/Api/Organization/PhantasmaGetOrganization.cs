using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;
using Phantasma.RpcClient.Infrastructure;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetOrganization : RpcRequestResponseHandler<OrganizationDto>
    {
        public PhantasmaGetOrganization(IClient client) : base(client, ApiMethods.getOrganization.ToString()) { }
        
        public Task<OrganizationDto> SendRequestAsync(string orgID, object id = null)
        {
            if (string.IsNullOrEmpty(orgID)) throw new ArgumentNullException(nameof(orgID));
            return SendRequestAsync(id, orgID);
        }
        
        public OrganizationDto SendRequest(string orgID, object id = null)
        {
            if (string.IsNullOrEmpty(orgID)) throw new ArgumentNullException(nameof(orgID));
            return SendRequest(id, orgID);
        }

        public RpcRequest BuildRequest(string orgID, object id = null)
        {
            if (string.IsNullOrEmpty(orgID)) throw new ArgumentNullException(nameof(orgID));
            return BuildRequest(id, orgID);
        }
    }
}
