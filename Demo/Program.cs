using Phantasma.RpcClient;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Phantasma.RpcClient.Client;

namespace Demo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var phantasmaService = new PhantasmaRpcService(new RpcClient(new Uri("http://localhost:7077/rpc"), httpClientHandler: new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            }));

            var test = await phantasmaService.GetAddressTxs.SendRequestAsync("P2f7ZFuj6NfZ76ymNMnG3xRBT5hAMicDrQRHE4S7SoxEr", 1, 20);

            var soul = await phantasmaService.GetTokenTransfers.SendRequestAsync("SOUL", 1, 60);
        }
    }
}
