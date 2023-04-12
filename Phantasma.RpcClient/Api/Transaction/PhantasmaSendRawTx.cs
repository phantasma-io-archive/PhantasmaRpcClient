using System;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaSendRawTx : RpcRequestResponseHandler<string>
    {
        public PhantasmaSendRawTx(IClient client) : base(client, ApiMethods.sendRawTransaction.ToString()) { }

        public Task<string> SendRequestAsync(string signedTx, object id = null)
        {
            if (signedTx == null) throw new ArgumentNullException(nameof(signedTx));
            return SendRequestAsync(id, signedTx);
        }
        
        public string SendRequest(string signedTx, object id = null)
        {
            if (signedTx == null) throw new ArgumentNullException(nameof(signedTx));
            return SendRequest(id, signedTx);
        }

        public RpcRequest BuildRequest(string signedTx, object id = null)
        {
            if (signedTx == null) throw new ArgumentNullException(nameof(signedTx));
            return BuildRequest(id, signedTx);
        }
    }
}
