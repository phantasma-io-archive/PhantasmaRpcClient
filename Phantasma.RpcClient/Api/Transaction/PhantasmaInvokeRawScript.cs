using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Phantasma.RpcClient.Client;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaInvokeRawScript : RpcRequestResponseHandler<JObject>
    {
        public PhantasmaInvokeRawScript(IClient client) : base(client, ApiMethods.invokeRawScript.ToString()) { }

        public Task<JObject> SendRequestAsync(string chain, string script, object id = null)
        {
            if (chain == null) throw new ArgumentNullException(nameof(chain));
            if (script == null) throw new ArgumentNullException(nameof(script));
            return SendRequestAsync(id, chain, script);
        }

        public RpcRequest BuildRequest(string chain, string script, object id = null)
        {
            if (chain == null) throw new ArgumentNullException(nameof(chain));
            if (script == null) throw new ArgumentNullException(nameof(script));
            return BuildRequest(id, chain, script);
        }
    }
}
