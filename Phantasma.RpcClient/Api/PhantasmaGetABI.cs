using System;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetABI: RpcRequestResponseHandler<ABIContractDto>
    {
        public PhantasmaGetABI(IClient client) : base(client, ApiMethods.getABI.ToString()) { }

        public Task<ABIContractDto> SendRequestAsync(string chain, string contract, object id = null)
        {
            if (chain == null) throw new ArgumentNullException(nameof(chain));
            if (contract == null) throw new ArgumentNullException(nameof(contract));

            return SendRequestAsync(id, chain, contract);
        }

        public RpcRequest BuildRequest(string chain, string contract, object id = null)
        {
            if (chain == null) throw new ArgumentNullException(nameof(chain));
            if (contract == null) throw new ArgumentNullException(nameof(contract));

            return BuildRequest(id, chain, contract);
        }
    }
}
