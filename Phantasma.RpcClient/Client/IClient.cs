using System.Threading.Tasks;

namespace Phantasma.RpcClient.Client
{
    public interface IClient
    {
        T SendRequest<T>(RpcRequest request, string route = null);
        T SendRequest<T>(string method, string route = null, params object[] paramList);
        void SendRequest(RpcRequest request, string route = null);
        void SendRequest(string method, string route = null, params object[] paramList);

        
        Task<T> SendRequestAsync<T>(RpcRequest request, string route = null);
        Task<T> SendRequestAsync<T>(string method, string route = null, params object[] paramList);
        Task SendRequestAsync(RpcRequest request, string route = null);
        Task SendRequestAsync(string method, string route = null, params object[] paramList);
    }
}
