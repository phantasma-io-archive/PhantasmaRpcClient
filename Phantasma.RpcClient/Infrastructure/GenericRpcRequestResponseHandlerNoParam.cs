using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using IClient = Phantasma.RpcClient.Client.IClient;

namespace Phantasma.RpcClient.Infrastructure
{
    public class GenericRpcRequestResponseHandlerNoParam<TResponse> : RpcRequestResponseHandlerNoParam<TResponse>
    {
        public GenericRpcRequestResponseHandlerNoParam(IClient client, string methodName) : base(client, methodName)
        {
        }

        public new Task<TResponse> SendRequestAsync(object id = null)
        {
            return base.SendRequestAsync(id);
        }
        
        public new TResponse SendRequest(object id = null)
        {
            return base.SendRequest(id);
        }
    }
}
