using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.DTOs;

namespace Phantasma.RpcClient.Api
{
    public class PhantasmaGetAddressesBySymbol : RpcRequestResponseHandler<List<AccountDto>>
    {
        public PhantasmaGetAddressesBySymbol(IClient client) : base(client, ApiMethods.getAddressesBySymbol.ToString()) { }

        public Task<List<AccountDto>> SendRequestAsync(string symbol, object id = null)
        {
            if (symbol == null) throw new ArgumentNullException(nameof(symbol));
            return SendRequestAsync(id, symbol);
        }
        
        public List<AccountDto> SendRequest(string symbol, object id = null)
        {
            if (symbol == null) throw new ArgumentNullException(nameof(symbol));
            return SendRequest(id, symbol);
        }

        public RpcRequest BuildRequest(string symbol, object id = null)
        {
            if (symbol == null) throw new ArgumentNullException(nameof(symbol));
            return BuildRequest(id, symbol);
        }
    }
}
