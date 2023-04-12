using System;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetTxByHash : RpcRequestResponseHandler<TransactionDto>
    {
        public PhantasmaGetTxByHash(IClient client) : base(client, ApiMethods.getTransaction.ToString()) { }

        public Task<TransactionDto> SendRequestAsync(string txHash, object id = null)
        {
            if (txHash == null) throw new ArgumentNullException(nameof(txHash));
            return SendRequestAsync(id, txHash);
        }
        
        public TransactionDto SendRequest(string txHash, object id = null)
        {
            if (txHash == null) throw new ArgumentNullException(nameof(txHash));
            return SendRequest(id, txHash);
        }

        public RpcRequest BuildRequest(string txHash, object id = null)
        {
            if (txHash == null) throw new ArgumentNullException(nameof(txHash));
            return BuildRequest(id, txHash);
        }
    }
}
