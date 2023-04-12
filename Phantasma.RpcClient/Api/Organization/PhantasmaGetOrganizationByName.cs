using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;
using Phantasma.RpcClient.Infrastructure;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetOrganizationByName : RpcRequestResponseHandler<OrganizationDto>
    {
        public PhantasmaGetOrganizationByName(IClient client) : base(client, ApiMethods.getOrganizationByName.ToString()) { }
        
        public Task<OrganizationDto> SendRequestAsync(string orgName, object id = null)
        {
            if (string.IsNullOrEmpty(orgName)) throw new ArgumentNullException(nameof(orgName));
            return SendRequestAsync(id, orgName);
        }
        
        public OrganizationDto SendRequest(string orgName, object id = null)
        {
            if (string.IsNullOrEmpty(orgName)) throw new ArgumentNullException(nameof(orgName));
            return SendRequest(id, orgName);
        }

        public RpcRequest BuildRequest(string orgName, object id = null)
        {
            if (string.IsNullOrEmpty(orgName)) throw new ArgumentNullException(nameof(orgName));
            return BuildRequest(id, orgName);
        }
    }
}
