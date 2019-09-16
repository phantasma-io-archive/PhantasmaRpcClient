using Phantasma.RpcClient.Api;

namespace Phantasma.RpcClient.Interfaces
{
    public interface IPhantasmaRpcService
    {
        PhantasmaGetABI GetABI { get; }
        PhantasmaGetAccount GetAccount { get; }
        PhantasmaGetAddressTxs GetAddressTxs { get; }
        PhantasmaGetAddressTxCount GetAddressTxCount { get; }
        PhantasmaGetApplications GetApplications { get; }
        PhantasmaGetAuctions GetAuctions { get; }
        PhantasmaGetAuctionCount GetAuctionCount { get; }
        PhantasmaGetBlockByHash GetBlockByHash { get; }
        PhantasmaGetBlockByHashSerialized GetBlockByHashSerialized { get; }
        PhantasmaGetBlockByHeight GetBlockByHeight { get; }
        PhantasmaGetBlockByHeightSerialized GetBlockByHeightSerialized { get; }
        PhantasmaGetBlockHeight GetBlockHeight { get; }
        PhantasmaGetBlockTxCountByHash GetBlockTxCountByHash { get; }
        PhantasmaGetChains GetChains { get; }
        PhantasmaGetPlatforms GetPlatforms { get; }
        PhantasmaGetTokens GetTokens { get; }
        PhantasmaGetTokenData GetTokenData { get; }
        PhantasmaGetTokenTransfers GetTokenTransfers { get; }
        PhantasmaGetTokenTransferCount GetTokenTransferCount { get; set; }
        PhantasmaGetTxByBlockHashAndIndex GetTxByBlockHashAndIndex { get; }
        PhantasmaGetTxByHash GetTxByHash { get; }
        PhantasmaLookUpName LookUpName { get; }
        PhantasmaSendRawTx SendRawTx { get; }
        PhantasmaInvokeRawScript InvokeRawScript { get; }
    }
}
