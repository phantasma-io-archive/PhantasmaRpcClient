namespace Phantasma.RpcClient.Api
{
    public enum ApiMethods
    {
        getAccount,
        getApps,
        getAddressTransactions,
        getAddressTxCount,
        getAuctions,
        getAuctionsCount,
        getBlockByHash,
        getRawBlockByHash,
        getBlockByHeight,
        getRawBlockByHeight,
        getBlockHeight,
        getBlockTransactionCountByHash,
        getChains,
        getTransaction,
        getTransactionByBlockHashAndIndex,
        getTokens,
        getTokenData,
        getTokenTransfers,
        getTokenTransferCount,
        sendRawTransaction,
        lookUpName,
        invokeRawScript,
    }
}
