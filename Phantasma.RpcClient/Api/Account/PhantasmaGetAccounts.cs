using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetAccounts : RpcRequestResponseHandler<List<AccountDto>>
    {
        public PhantasmaGetAccounts(IClient client) : base(client, ApiMethods.getAccounts.ToString()) { }

        public Task<List<AccountDto>> SendRequestAsync(string[] addresses, object id = null)
        {
            if (addresses == null) throw new ArgumentNullException(nameof(addresses));
            return SendRequestAsync(id, String.Join(",", addresses));
        }
        
        public List<AccountDto> SendRequest(string[] addresses, object id = null)
        {
            if (addresses == null) throw new ArgumentNullException(nameof(addresses));
            return SendRequest(id, String.Join(",", addresses));
        }

        public RpcRequest BuildRequest(string[] addresses, object id = null)
        {
            if (addresses == null) throw new ArgumentNullException(nameof(addresses));
            return BuildRequest(id, String.Join(",", addresses));
        }
    }
}
