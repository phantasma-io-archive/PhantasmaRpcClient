using System;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;

namespace Phantasma.RpcClient.Api
{
   public  class PhantasmaLookUpName : RpcRequestResponseHandler<string>
    {
        public PhantasmaLookUpName(IClient client) : base(client, ApiMethods.lookUpName.ToString()) { }

        public Task<string> SendRequestAsync(string accountName, object id = null)
        {
            if (accountName == null) throw new ArgumentNullException(nameof(accountName));
            return SendRequestAsync(id, accountName);
        }

        public RpcRequest BuildRequest(string accountName, object id = null)
        {
            if (accountName == null) throw new ArgumentNullException(nameof(accountName));
            return BuildRequest(id, accountName);
        }
    }
}
