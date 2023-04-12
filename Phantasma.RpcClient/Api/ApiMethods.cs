namespace Phantasma.RpcClient.Api
{
    public enum ApiMethods
    {
        // Acount
        getAccount,
        getAccounts,
        lookUpName,
        getAddressesBySymbol,
        
        // Auction
        getAuctionsCount,
        getAuctions,
        getAuction,
        
        // Block
        getBlockHeight,
        getBlockTransactionCountByHash,
        getBlockByHash,
        getRawBlockByHash,
        getBlockByHeight,
        getRawBlockByHeight,
        getLatestBlock,
        getRawLatestBlock,
        
        // Chain
        getChains,
        
        // Connection
        abci_query,
        health,
        status,
        net_info,
        request_block,
        getValidatorsSettings,
        
        // Contract
        getContracts,
        getContract,
        getContractByAddress,
        
        // Leaderboard
        getLeaderboard,
        
        // Nexus
        getNexus,
        
        // Organization
        getOrganization,
        getOrganizations,
        getOrganizationByName,
        
        // Platforms
        getPlatforms,
        getPlatform,
        getInterop,
        
        // RPC
        rpc,
        
        // Sale
        getLatestSaleHash,
        getSale,
        
        // Token
        getTokens,
        getToken,
        getTokenData,
        getNFT,
        getNFTs,
        getTokenBalance,
        
        // Transaction
        getTransactionByBlockHashAndIndex,
        getAddressTransactions,
        getAddressTransactionCount,
        sendRawTransaction,
        invokeRawScript,
        getTransaction,
        
        // Validator
        getValidators,
        getABI,
        
        // Storage
        getArchive,
        writeArchive,
        readArchive,
        
        // Swaps
        getSwapsForAddress,
        settleSwap,


        // Missing
        getApps,
        getAddressTxCount,
        getPeers,
        getTokenTransfers,
        getTokenTransferCount,

    }
}
