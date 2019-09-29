using Phantasma.RpcClient.Api;
using Phantasma.RpcClient.Client;
using Phantasma.RpcClient.Infrastructure;
using Phantasma.RpcClient.Interfaces;

namespace Phantasma.RpcClient
{
    public class PhantasmaRpcService : RpcClientWrapper, IPhantasmaRpcService
    {
        public PhantasmaRpcService(IClient client) : base(client)
        {
            GetABI = new PhantasmaGetABI(client);
            GetAccount = new PhantasmaGetAccount(client);
            GetAddressTxs = new PhantasmaGetAddressTxs(client);
            GetAddressTxCount = new PhantasmaGetAddressTxCount(client);

            GetApplications = new PhantasmaGetApplications(client);

            GetAuctions = new PhantasmaGetAuctions(client);
            GetAuctionCount = new PhantasmaGetAuctionCount(client);

            GetBlockByHash = new PhantasmaGetBlockByHash(client);
            GetBlockByHashSerialized = new PhantasmaGetBlockByHashSerialized(client);
            GetBlockByHeight = new PhantasmaGetBlockByHeight(client);
            GetBlockHeight = new PhantasmaGetBlockHeight(client);
            GetBlockByHeightSerialized = new PhantasmaGetBlockByHeightSerialized(client);
            GetBlockTxCountByHash = new PhantasmaGetBlockTxCountByHash(client);

            GetChains = new PhantasmaGetChains(client);
            GetPeers = new PhantasmaGetPeers(client);
            GetPlatforms = new PhantasmaGetPlatforms(client);
            GetTokens = new PhantasmaGetTokens(client);
            GetTokenData = new PhantasmaGetTokenData(client);
            GetTokenTransfers = new PhantasmaGetTokenTransfers(client);
            GetTokenTransferCount = new PhantasmaGetTokenTransferCount(client);
            GetSwapsForAddress = new PhantasmaGetSwapsForAddress(client);
            GetTxByBlockHashAndIndex = new PhantasmaGetTxByBlockHashAndIndex(client);
            GetTxByHash = new PhantasmaGetTxByHash(client);

            SendRawTx = new PhantasmaSendRawTx(client);
            InvokeRawScript = new PhantasmaInvokeRawScript(client);

            LookUpName = new PhantasmaLookUpName(client);
        }

        public PhantasmaGetABI GetABI { get; }
        public PhantasmaGetAccount GetAccount { get; }
        public PhantasmaGetAddressTxs GetAddressTxs { get; }
        public PhantasmaGetAddressTxCount GetAddressTxCount { get; }
        public PhantasmaGetApplications GetApplications { get; }
        public PhantasmaGetAuctions GetAuctions { get; }
        public PhantasmaGetAuctionCount GetAuctionCount { get; }
        public PhantasmaGetBlockByHash GetBlockByHash { get; }
        public PhantasmaGetBlockByHashSerialized GetBlockByHashSerialized { get; }
        public PhantasmaGetBlockByHeight GetBlockByHeight { get; }
        public PhantasmaGetBlockByHeightSerialized GetBlockByHeightSerialized { get; }
        public PhantasmaGetBlockHeight GetBlockHeight { get; }
        public PhantasmaGetBlockTxCountByHash GetBlockTxCountByHash { get; }
        public PhantasmaGetChains GetChains { get; }
        public PhantasmaGetPeers GetPeers { get; }
        public PhantasmaGetPlatforms GetPlatforms { get; }
        public PhantasmaGetTokens GetTokens { get; }
        public PhantasmaGetTokenData GetTokenData { get; }
        public PhantasmaGetTokenTransfers GetTokenTransfers { get; }
        public PhantasmaGetTokenTransferCount GetTokenTransferCount { get; set; }
        public PhantasmaGetTxByBlockHashAndIndex GetTxByBlockHashAndIndex { get; }
        public PhantasmaGetTxByHash GetTxByHash { get; }
        public PhantasmaGetSwapsForAddress GetSwapsForAddress { get; }
        public PhantasmaLookUpName LookUpName { get; }
        public PhantasmaSendRawTx SendRawTx { get; }
        public PhantasmaInvokeRawScript InvokeRawScript { get; }
    }
}
