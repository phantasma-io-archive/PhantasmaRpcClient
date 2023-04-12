using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.Infrastructure;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetBlockTxCountByHash : GenericRpcRequestResponseHandlerNoParam<int>
    {
        public PhantasmaGetBlockTxCountByHash(IClient client) : base(client, ApiMethods.getBlockTransactionCountByHash.ToString()) { }
    }
}
