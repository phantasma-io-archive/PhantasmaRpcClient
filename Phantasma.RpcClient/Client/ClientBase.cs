using System;
using System.Threading.Tasks;

namespace Phantasma.RpcClient.Client
{
    public abstract class ClientBase : IClient
    {
        public static TimeSpan ConnectionTimeout { get; set; } = TimeSpan.FromSeconds(60.0);

        public T SendRequest<T>(RpcRequest request, string route = null)
        {
            return SendInnerRequest<T>(request, route );
        }

        public T SendRequest<T>(string method, string route = null, params object[] paramList)
        {
            return SendInnerRequest<T>(method, route, paramList);
        }

        public async Task<T> SendRequestAsync<T>(RpcRequest request, string route = null)
        {            
            return await SendInnerRequestAync<T>(request, route).ConfigureAwait(false);
        }

        public async Task<T> SendRequestAsync<T>(string method, string route = null, params object[] paramList)
        {
            return await SendInnerRequestAync<T>(method, route, paramList).ConfigureAwait(false);
        }

        public abstract Task SendRequestAsync(RpcRequest request, string route = null);

        public abstract Task SendRequestAsync(string method, string route = null, params object[] paramList);

        protected abstract Task<T> SendInnerRequestAync<T>(RpcRequest request, string route = null);

        protected abstract Task<T> SendInnerRequestAync<T>(string method, string route = null, params object[] paramList);
        
        
        public abstract void SendRequest(RpcRequest request, string route = null);

        public abstract void SendRequest(string method, string route = null, params object[] paramList);

        protected abstract T SendInnerRequest<T>(RpcRequest request, string route = null);

        protected abstract T SendInnerRequest<T>(string method, string route = null, params object[] paramList);
    }
}
