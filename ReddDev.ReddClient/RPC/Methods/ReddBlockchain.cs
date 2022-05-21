// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
using ReddDev.ReddClient.RPC.Responses;

namespace ReddDev.ReddClient.RPC {

  /// <summary>
  /// ReddCoin wallet Blockchain RPC methods
  /// </summary>
  public partial class ReddClient {

    private ReddError m_LastError; // Error received for last call or null when successfull

    /// <summary>
    /// Last error
    /// </summary>
    public ReddError LastError { get => m_LastError; }

    #region getbestblockhash

    /// <summary>
    /// Returns the hash of the best (tip) block in the most-work fully-validated chain.
    /// </summary>
    /// <returns>[string] The block hash, hex-encoded</returns>
    public String GetBestBlockHash () {
      Task<String> result = GetBestBlockHashAsync();
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns the hash of the best (tip) block in the most-work fully-validated chain.
    /// </summary>
    /// <returns>[string] The block hash, hex-encoded</returns>
    public async Task<String> GetBestBlockHashAsync () {
      ReddResponse<String> response = await PostAsync<String>(ReddMethods.GetBestBlockHash);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getbestblockhash

    #region getblock

    /// <summary>
    /// Getblock "blockhash" ( verbosity 0 )
    /// </summary>
    /// <param name="blockHash">[string] The block hash</param>
    /// <returns>[string] Serialized string, hex-encoded data for block 'hash'</returns>
    public String GetBlockHexString (String blockHash) {
      Task<String> result = GetBlockHexStringAsync(blockHash);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Getblock "blockhash" ( verbosity 0 )
    /// </summary>
    /// <param name="blockHash">[string] The block hash</param>
    /// <returns>[string] Serialized string, hex-encoded data for block 'hash'</returns>
    public async Task<String> GetBlockHexStringAsync (String blockHash) {
      ReddResponse<String> response = await PostAsync<String>(ReddMethods.GetBlock, blockHash, 0);
      m_LastError = response.Error;
      return response.Result;
    }

    /// <summary>
    /// getblock "blockhash" ( verbosity 1 )
    /// </summary>
    /// <returns>[UniValue] Object with information about block</returns>
    public ReddBlock GetBlock (String blockHash) {
      Task<ReddBlock> result = GetBlockAsync(blockHash);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// getblock "blockhash" ( verbosity 1 )
    /// </summary>
    /// <returns>[UniValue] Object with information about block</returns>
    public async Task<ReddBlock> GetBlockAsync (String blockHash) {
      ReddResponse<ReddBlock> response = await PostAsync<ReddBlock>(ReddMethods.GetBlock, blockHash, 1);
      m_LastError = response.Error;
      return response.Result;
    }

    /// <summary>
    /// getblock "blockhash" ( verbosity = 2 )
    /// </summary>
    /// <returns>[UniValue] Object with information about block and information about each transaction</returns>
    public ReddBlockTransactions GetBlockTransactions (String blockHash) {
      Task<ReddBlockTransactions> result = GetBlockTransactionsAsync(blockHash);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// getblock "blockhash" ( verbosity = 2 )
    /// </summary>
    /// <returns>[UniValue] Object with information about block and information about each transaction</returns>
    public async Task<ReddBlockTransactions> GetBlockTransactionsAsync (String blockHash) {
      ReddResponse<ReddBlockTransactions> response = await PostAsync<ReddBlockTransactions>(ReddMethods.GetBlock, blockHash, 2);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getblock

    #region getblockchaininfo

    /// <summary>
    /// Returns an object containing various state info regarding blockchain processing.
    /// </summary>
    /// <returns>[UniValue] Blockchain Info</returns>
    public ReddBlockchainInfo GetBlockchainInfo () {
      Task<ReddBlockchainInfo> result = GetBlockchainInfoAsync();
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns an object containing various state info regarding blockchain processing.
    /// </summary>
    /// <returns>[UniValue] Blockchain Info</returns>
    public async Task<ReddBlockchainInfo> GetBlockchainInfoAsync () {
      ReddResponse<ReddBlockchainInfo> response = await PostAsync<ReddBlockchainInfo>(ReddMethods.GetBlockChainInfo);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getblockchaininfo

    #region getblockcount

    /// <summary>
    /// Returns the height of the most-work fully-validated chain.
    /// The genesis block has height 0.
    /// </summary>
    /// <returns>[int] The current block count</returns>
    public Int32 GetBlockCount () {
      Task<Int32> result = GetBlockCountAsync();
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns the height of the most-work fully-validated chain.
    /// The genesis block has height 0.
    /// </summary>
    /// <returns>[int] The current block count</returns>
    public async Task<Int32> GetBlockCountAsync () {
      ReddResponse<Int32> response = await PostAsync<Int32>(ReddMethods.GetBlockCount);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getblockcount

    #region getblockfilter "blockhash" ( "filtertype" )

    /// <summary>
    /// Retrieve a BIP 157 content filter for a particular block.
    /// </summary>
    /// <param name="blockHash">[string] The hash of the block</param>
    /// <param name="filtertype">[string] The type name of the filter</param>
    /// <returns>[UniValue] The current block count</returns>
    public ReddContentFilter GetBlockFilter (String blockHash, String filtertype = "basic") {
      Task<ReddContentFilter> result = GetBlockFilterAsync(blockHash, filtertype);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Retrieve a BIP 157 content filter for a particular block.
    /// </summary>
    /// <param name="blockHash">[string] The hash of the block</param>
    /// <param name="filtertype">[string] The type name of the filter</param>
    /// <returns>[UniValue] The current block count</returns>
    public async Task<ReddContentFilter> GetBlockFilterAsync (String blockHash, String filtertype) {
      ReddResponse<ReddContentFilter> response = await PostAsync<ReddContentFilter>(ReddMethods.GetBlockFilter, blockHash, filtertype);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getblockfilter "blockhash" ( "filtertype" )

    #region getblockhash height

    /// <summary>
    /// Returns hash of block in best-block-chain at height provided.
    /// </summary>
    /// <param name="height">[int] The height index</param>
    /// <returns>[string] The block hash</returns>
    public String GetBlockHash (Int32 height) {
      Task<String> result = GetBlockHashAsync(height);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns hash of block in best-block-chain at height provided.
    /// </summary>
    /// <param name="height">[int] The height index</param>
    /// <returns>[string] The block hash</returns>
    public async Task<String> GetBlockHashAsync (Int32 height) {
      ReddResponse<String> response = await PostAsync<String>(ReddMethods.GetBlockHash, height);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getblockhash height

    #region getblockheader "blockhash" ( verbose )

    /// <summary>
    /// Returns serialized, hex-encoded data for blockheader
    /// </summary>
    /// <param name="blockhash">[string] The block hash</param>
    /// <returns>[string] serialized, hex-encoded data for block</returns>
    public String GetBlockHeaderHexString (String blockhash) {
      Task<String> result = GetBlockHeaderHexStringAsync(blockhash);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns serialized, hex-encoded data for blockheader
    /// </summary>
    /// <param name="blockhash">[string] The block hash</param>
    /// <returns>[string] serialized, hex-encoded data for block</returns>
    public async Task<String> GetBlockHeaderHexStringAsync (String blockhash) {
      ReddResponse<String> response = await PostAsync<String>(ReddMethods.GetBlockHeader, blockhash, false);
      m_LastError = response.Error;
      return response.Result;
    }

    /// <summary>
    /// Object with information about blockheader
    /// </summary>
    /// <param name="blockhash">[string] The block hash</param>
    /// <returns>[UniValue] ReddBlockHeader</returns>
    public ReddBlockHeader GetBlockHeader (String blockhash) {
      Task<ReddBlockHeader> result = GetBlockHeaderAsync(blockhash);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Object with information about blockheader
    /// </summary>
    /// <param name="blockhash">[string] The block hash</param>
    /// <returns>[UniValue] ReddBlockHeader</returns>
    public async Task<ReddBlockHeader> GetBlockHeaderAsync (String blockhash) {
      ReddResponse<ReddBlockHeader> response = await PostAsync<ReddBlockHeader>(ReddMethods.GetBlockHeader, blockhash, true);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getblockheader "blockhash" ( verbose )

    #region getblockstats hash_or_height ( stats )

    /// <summary>
    /// Compute per block statistics for a given window. 
    /// All amounts are in satoshis.
    /// It won't work for some heights with pruning.
    /// </summary>
    /// <param name="blockhash">[string] The block hash of the target block</param>
    /// <returns>[UniValue] Block stats</returns>
    public ReddGetBlockStats GetBlockStats (String blockhash) {
      Task<ReddGetBlockStats> result = GetBlockStatsAsync(blockhash);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Compute per block statistics for a given window. 
    /// All amounts are in satoshis.
    /// It won't work for some heights with pruning.
    /// </summary>
    /// <param name="blockhash">[string] The block hash of the target block</param>
    /// <returns>[UniValue] Block stats</returns>
    public async Task<ReddGetBlockStats> GetBlockStatsAsync (String blockhash) {
      ReddResponse<ReddGetBlockStats> response = await PostAsync<ReddGetBlockStats>(ReddMethods.GetBlockStats, blockhash);
      m_LastError = response.Error;
      return response.Result;
    }

    /// <summary>
    /// Compute per block statistics for a given window. 
    /// All amounts are in satoshis.
    /// It won't work for some heights with pruning.
    /// </summary>
    /// <param name="height">[int] The block height of the target block</param>
    /// <returns>[UniValue] Block stats</returns>
    public ReddGetBlockStats GetBlockStats (Int32 height) {
      Task<ReddGetBlockStats> result = GetBlockStatsAsync(height);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Compute per block statistics for a given window. 
    /// All amounts are in satoshis.
    /// It won't work for some heights with pruning.
    /// </summary>
    /// <param name="height">[int] The block height of the target block</param>
    /// <returns>[UniValue] Block stats</returns>
    public async Task<ReddGetBlockStats> GetBlockStatsAsync (Int32 height) {
      ReddResponse<ReddGetBlockStats> response = await PostAsync<ReddGetBlockStats>(ReddMethods.GetBlockStats, height);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getblockstats hash_or_height ( stats )

    #region getchaintips

    /// <summary>
    /// Return information about all known tips in the block tree, including the main chain as well as orphaned branches.
    /// </summary>
    /// <returns>[UniValue] All known tips in the block tree</returns>
    public List<ReddChainTips> GetChainTips () {
      Task<List<ReddChainTips>> result = GetChainTipsAsync();
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Return information about all known tips in the block tree, including the main chain as well as orphaned branches.
    /// </summary>
    /// <returns>[UniValue] All known tips in the block tree</returns>
    public async Task<List<ReddChainTips>> GetChainTipsAsync () {
      ReddResponse<List<ReddChainTips>> response = await PostAsync<List<ReddChainTips>>(ReddMethods.GetChainTips);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getchaintips

    #region getchaintxstats ( nblocks "blockhash" )

    /// <summary>
    /// Compute statistics about the total number and rate of transactions in the chain.
    /// </summary>
    /// <param name="blockhash">[string] The hash of the block that ends the window. default=chain tip</param>
    /// <returns>[UniValue] ChainTxStats</returns>
    public ReddChainTxStats GetChainTxStats (String blockhash = null) {
      Task<ReddChainTxStats> result = GetChainTxStatsAsync(blockhash);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Compute statistics about the total number and rate of transactions in the chain.
    /// </summary>
    /// <param name="blockhash">[string] The hash of the block that ends the window. default=chain tip</param>
    /// <returns>[UniValue] ChainTxStats</returns>
    public async Task<ReddChainTxStats> GetChainTxStatsAsync (String blockhash = null) {
      ReddResponse<ReddChainTxStats> response = await PostAsync<ReddChainTxStats>(ReddMethods.GetChainTxStats, null, blockhash);
      m_LastError = response.Error;
      return response.Result;
    }

    /// <summary>
    /// Compute statistics about the total number and rate of transactions in the chain.
    /// </summary>
    /// <param name="nblocks">[int] Size of the window in number of blocks, default=one month</param>
    /// <param name="blockhash">[string] The hash of the block that ends the window. default=chain tip</param>
    /// <returns>[UniValue] ChainTxStats</returns>
    public ReddChainTxStats GetChainTxStats (Int32 nblocks, String blockhash = null) {
      Task<ReddChainTxStats> result = GetChainTxStatsAsync(nblocks, blockhash);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Compute statistics about the total number and rate of transactions in the chain.
    /// </summary>
    /// <param name="nblocks">[int] Size of the window in number of blocks, default=one month</param>
    /// <param name="blockhash">[string] The hash of the block that ends the window. default=chain tip</param>
    /// <returns>[UniValue] ChainTxStats</returns>
    public async Task<ReddChainTxStats> GetChainTxStatsAsync (Int32 nblocks, String blockhash = null) {
      ReddResponse<ReddChainTxStats> response = await PostAsync<ReddChainTxStats>(ReddMethods.GetChainTxStats, nblocks, blockhash);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getchaintxstats ( nblocks "blockhash" )

    #region getdifficulty

    /// <summary>
    /// Returns the proof-of-work difficulty as a multiple of the minimum difficulty.
    /// </summary>
    /// <returns>[double] The proof-of-work difficulty as a multiple of the minimum difficulty.</returns>
    public Double GetDifficulty () {
      Task<Double> result = GetDifficultyAsync();
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns the proof-of-work difficulty as a multiple of the minimum difficulty.
    /// </summary>
    /// <returns>[double] The proof-of-work difficulty as a multiple of the minimum difficulty.</returns>
    public async Task<Double> GetDifficultyAsync () {
      ReddResponse<Double> response = await PostAsync<Double>(ReddMethods.GetDifficulty);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getdifficulty

    #region getmempoolancestors "txid" ( verbose )

    /// <summary>
    /// If txid is in the mempool, returns all transaction Id's of the in-mempool ancestors.
    /// </summary>
    /// <param name="transactionId">[string] The transaction id of a transaction in the mempool</param>
    /// <returns>[string[]] List of transaction id's of ancestors</returns>
    public List<String> GetMempoolAncestorIds (String transactionId) {
      Task<List<String>> result = GetMempoolAncestorIdsAsync(transactionId);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// If txid is in the mempool, returns all transaction Id's of the in-mempool ancestors.
    /// </summary>
    /// <param name="transactionId">[string] The transaction id of a transaction in the mempool</param>
    /// <returns>[string[]] List of transaction id's of ancestors</returns>
    public async Task<List<String>> GetMempoolAncestorIdsAsync (String transactionId) {
      ReddResponse<List<String>> response = await PostAsync<List<String>>(ReddMethods.GetMempoolAncestors, transactionId, false);
      m_LastError = response.Error;
      return response.Result;
    }

    /// <summary>
    /// If txid is in the mempool, returns all ancestors in the in-mempool.
    /// </summary>
    /// <param name="transactionId">[string] The transaction id of a transaction in the mempool</param>
    /// <returns>[UniValue[]] List of transaction id's of ancestors</returns>
    public Dictionary<String, ReddMempoolEntry> GetMempoolAncestors (String transactionId) {
      Task<Dictionary<String, ReddMempoolEntry>> result = GetMempoolAncestorsAsync(transactionId);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// If txid is in the mempool, returns all ancestors in the in-mempool.
    /// </summary>
    /// <param name="transactionId">[string] The transaction id of a transaction in the mempool</param>
    /// <returns>[UniValue[]] List of transaction id's of ancestors</returns>
    public async Task<Dictionary<String, ReddMempoolEntry>> GetMempoolAncestorsAsync (String transactionId) {
      ReddResponse<Dictionary<String, ReddMempoolEntry>> response = await PostAsync<Dictionary<String, ReddMempoolEntry>>(ReddMethods.GetMempoolAncestors, transactionId, true);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getmempoolancestors "txid" ( verbose )

    #region getmempooldescendants "txid" ( verbose )

    /// <summary>
    /// If txid is in the mempool, returns all transaction Id's of the in-mempool descendants.
    /// </summary>
    /// <param name="transactionId">[string] The transaction id of a transaction in the mempool</param>
    /// <returns>[string[]] List of transaction id's of descendants</returns>
    public List<String> GetMempoolDescendantIds (String transactionId) {
      Task<List<String>> result = GetMempoolDescendantIdsAsync(transactionId);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// If txid is in the mempool, returns all transaction Id's of the in-mempool descendants.
    /// </summary>
    /// <param name="transactionId">[string] The transaction id of a transaction in the mempool</param>
    /// <returns>[string[]] List of transaction id's of descendants</returns>
    public async Task<List<String>> GetMempoolDescendantIdsAsync (String transactionId) {
      ReddResponse<List<String>> response = await PostAsync<List<String>>(ReddMethods.GetMempoolDescendants, transactionId, false);
      m_LastError = response.Error;
      return response.Result;
    }

    /// <summary>
    /// If txid is in the mempool, returns all descendants in the in-mempool.
    /// </summary>
    /// <param name="transactionId">[string] The transaction id of a transaction in the mempool</param>
    /// <returns>[string, UniValue] List of transaction id's of descendants</returns>
    public Dictionary<String, ReddMempoolEntry> GetMempoolDescendants (String transactionId) {
      Task<Dictionary<String, ReddMempoolEntry>> result = GetMempoolDescendantsAsync(transactionId);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// If txid is in the mempool, returns all descendants in the in-mempool.
    /// </summary>
    /// <param name="transactionId">[string] The transaction id of a transaction in the mempool</param>
    /// <returns>[string, UniValue] List of transaction id's of descendants</returns>
    public async Task<Dictionary<String, ReddMempoolEntry>> GetMempoolDescendantsAsync (String transactionId) {
      ReddResponse<Dictionary<String, ReddMempoolEntry>> response = await PostAsync<Dictionary<String, ReddMempoolEntry>>(ReddMethods.GetMempoolDescendants, transactionId, true);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getmempooldescendants "txid" ( verbose )

    #region getmempoolentry "txid"

    /// <summary>
    /// Returns mempool data for given transaction
    /// </summary>
    /// <param name="transactionId">[string] The transaction id (must be in mempool)</param>
    /// <returns>[UniValue] Mempool data for given transaction</returns>
    public ReddMempoolEntry GetMempoolEntry (String transactionId) {
      Task<ReddMempoolEntry> result = GetMempoolEntryAsync(transactionId);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns mempool data for given transaction
    /// </summary>
    /// <param name="transactionId">[string] The transaction id (must be in mempool)</param>
    /// <returns>[UniValue] Mempool data for given transaction</returns>
    public async Task<ReddMempoolEntry> GetMempoolEntryAsync (String transactionId) {
      ReddResponse<ReddMempoolEntry> response = await PostAsync<ReddMempoolEntry>(ReddMethods.GetMempoolEntry, transactionId);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getmempoolentry "txid"

    #region getmempoolinfo

    /// <summary>
    /// Returns details on the active state of the TX memory pool.
    /// </summary>
    /// <returns>[UniValue] Details on the active state of the TX memory pool.</returns>
    public ReddMempoolInfo GetMempoolInfo () {
      Task<ReddMempoolInfo> result = GetMempoolInfoAsync();
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns details on the active state of the TX memory pool.
    /// </summary>
    /// <returns>[UniValue] Details on the active state of the TX memory pool.</returns>
    public async Task<ReddMempoolInfo> GetMempoolInfoAsync () {
      ReddResponse<ReddMempoolInfo> response = await PostAsync<ReddMempoolInfo>(ReddMethods.GetMempoolInfo);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getmempoolinfo

    #region getrawmempool ( verbose mempool_sequence )

    /// <summary>
    /// Returns all transaction ids in memory pool as an list of string transaction ids.
    /// </summary>
    /// <returns>[string[]] list of string transaction ids.</returns>
    public List<String> GetMempoolTransactionList () {
      Task<List<String>> result = GetMempoolTransactionListAsync();
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns all transaction ids in memory pool as an list of string transaction ids.
    /// </summary>
    /// <returns>[string[]] list of string transaction ids.</returns>
    public async Task<List<String>> GetMempoolTransactionListAsync () {
      ReddResponse<List<String>> response = await PostAsync<List<String>>(ReddMethods.GetRawMempool, false, false);
      m_LastError = response.Error;
      return response.Result;
    }

    /// <summary>
    /// Returns an object with all transaction ids in memory pool as an list of string transaction ids and the mempool sequence number
    /// </summary>
    /// <returns>[UniValue] Containing list of string transaction ids and mempool sequence number.</returns>
    public ReddMempoolTransactions GetMempoolTransactions () {
      Task<ReddMempoolTransactions> result = GetMempoolTransactionsAsync();
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns an object with all transaction ids in memory pool as an list of string transaction ids and the mempool sequence number
    /// </summary>
    /// <returns>[UniValue] Containing list of string transaction ids and mempool sequence number.</returns>
    public async Task<ReddMempoolTransactions> GetMempoolTransactionsAsync () {
      ReddResponse<ReddMempoolTransactions> response = await PostAsync<ReddMempoolTransactions>(ReddMethods.GetRawMempool, false, true);
      m_LastError = response.Error;
      return response.Result;
    }

    /// <summary>
    /// Returns all transaction ids in memory pool as an list of string transaction ids.
    /// </summary>
    /// <returns>[string, UniValue] Dictionary of string transaction ids with the mempool entry.</returns>
    public Dictionary<String, ReddMempoolEntry> GetMempoolEntries () {
      Task<Dictionary<String, ReddMempoolEntry>> result = GetMempoolEntriesAsync();
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns all transaction ids in memory pool as an list of string transaction ids.
    /// </summary>
    /// <returns>[string, UniValue] Dictionary of string transaction ids with the mempool entry.</returns>
    public async Task<Dictionary<String, ReddMempoolEntry>> GetMempoolEntriesAsync () {
      ReddResponse<Dictionary<String, ReddMempoolEntry>> response = await PostAsync<Dictionary<String, ReddMempoolEntry>>(ReddMethods.GetRawMempool, true);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion getrawmempool ( verbose mempool_sequence )

    #region gettxout "txid" n ( include_mempool )

    /// <summary>
    /// Returns details about an unspent transaction output.
    /// </summary>
    /// <param name="transactionId">[string] The transaction id</param>
    /// <param name="n">[int] vout number</param>
    /// <param name="includeMempool">[bool] Whether to include the mempool. Note that an unspent output that is spent in the mempool won't appear.</param>
    /// <returns>[UniValue] details about an unspent transaction output.</returns>
    public ReddUnspendOutputTransactions GetTxOut (String transactionId, Int32 n, Boolean includeMempool = true) {
      Task<ReddUnspendOutputTransactions> result = GetTxOutAsync(transactionId, n, includeMempool);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns details about an unspent transaction output.
    /// </summary>
    /// <param name="transactionId">[string] The transaction id</param>
    /// <param name="n">[int] vout number</param>
    /// <param name="includeMempool">[bool] Whether to include the mempool. Note that an unspent output that is spent in the mempool won't appear.</param>
    /// <returns>[UniValue] details about an unspent transaction output.</returns>
    public async Task<ReddUnspendOutputTransactions> GetTxOutAsync (String transactionId, Int32 n, Boolean includeMempool = true) {
      ReddResponse<ReddUnspendOutputTransactions> response = await PostAsync<ReddUnspendOutputTransactions>(ReddMethods.GetTxOut, transactionId, n, includeMempool);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion gettxout "txid" n ( include_mempool )

    #region gettxoutproof ["txid",...] ( "blockhash" )

    /// <summary>
    /// Returns a hex-encoded proof that "txid" was included in a block.
    /// 
    /// NOTE: By default this function only works sometimes. This is when there is an unspent output in the utxo for this transaction. 
    /// To make it always work,you need to maintain a transaction index, using the -txindex command line option or specify the block in which the transaction is included manually (by blockhash).
    /// </summary>
    /// <param name="transactionIds">[string] The txids to filter</param>
    /// <param name="blockhash">[string] If specified, looks for txid in the block with this hash</param>
    /// <returns>[string] hex-encoded proof that "txid" was included in a block.</returns>
    public String GetTxoutProof (List<String> transactionIds, String blockhash = null) {
      Task<String> result = GetTxoutProofAsync(transactionIds, blockhash);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns a hex-encoded proof that "txid" was included in a block.
    /// 
    /// NOTE: By default this function only works sometimes. This is when there is an unspent output in the utxo for this transaction. 
    /// To make it always work,you need to maintain a transaction index, using the -txindex command line option or specify the block in which the transaction is included manually (by blockhash).
    /// </summary>
    /// <param name="transactionIds">[string] The txids to filter</param>
    /// <param name="blockhash">[string] If specified, looks for txid in the block with this hash</param>
    /// <returns>[string] hex-encoded proof that "txid" was included in a block.</returns>
    public async Task<String> GetTxoutProofAsync (List<String> transactionIds, String blockhash = null) {
      ReddResponse<String> response = await PostAsync<String>(ReddMethods.GetTxoutProof, transactionIds, blockhash);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion gettxoutproof ["txid",...] ( "blockhash" )

    #region gettxoutsetinfo ( "hash_type" hash_or_height use_index )

    /// <summary>
    /// Returns statistics about the unspent transaction output set.
    /// </summary>
    /// <param name="hashType">[string] default="hash_serialized_2") Which UTXO set hash should be calculated. 
    /// <param name="hash">[string] The block hash of the target height (only available with coinstatsindex).</param>
    /// <param name="useIndex">[bool]  Use coinstatsindex, if available.</param>
    /// <returns>[UniValue] Statistics about the unspent transaction output set.</returns>
    public ReddTransactionOutSetInfo GetTxOutSetInfo (ReddHashType hashType = ReddHashType.Hash_Serialized_2, String hash = null, Boolean useIndex = true) {
      Task<ReddTransactionOutSetInfo> result = GetTxOutSetInfoAsync(hashType, hash, useIndex);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns statistics about the unspent transaction output set.
    /// </summary>
    /// <param name="hashType">[string] default="hash_serialized_2") Which UTXO set hash should be calculated. 
    /// <param name="hash">[string] The block hash of the target height (only available with coinstatsindex).</param>
    /// <param name="useIndex">[bool]  Use coinstatsindex, if available.</param>
    /// <returns>[UniValue] Statistics about the unspent transaction output set.</returns>
    public async Task<ReddTransactionOutSetInfo> GetTxOutSetInfoAsync (ReddHashType hashType, String hash = null, Boolean useIndex = true) {
      ReddResponse<ReddTransactionOutSetInfo> response = await PostAsync<ReddTransactionOutSetInfo>(ReddMethods.GetTxOutSetInfo, hashType.ToString().ToLowerInvariant(), hash, useIndex);
      m_LastError = response.Error;
      return response.Result;
    }

    /// <summary>
    /// Returns statistics about the unspent transaction output set.
    /// </summary>
    /// <param name="hashType">[string] default="hash_serialized_2") Which UTXO set hash should be calculated. 
    /// <param name="hash">[string] The block height of the target height (only available with coinstatsindex).</param>
    /// <param name="useIndex">[bool]  Use coinstatsindex, if available.</param>
    /// <returns>[UniValue] Statistics about the unspent transaction output set.</returns>
    public ReddTransactionOutSetInfo GetTxOutSetInfo (ReddHashType hashType, Int32 height, Boolean useIndex = true) {
      Task<ReddTransactionOutSetInfo> result = GetTxOutSetInfoAsync(hashType, height, useIndex);
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns statistics about the unspent transaction output set.
    /// </summary>
    /// <param name="hashType">[string] default="hash_serialized_2") Which UTXO set hash should be calculated. 
    /// <param name="hash">[string] The block height of the target height (only available with coinstatsindex).</param>
    /// <param name="useIndex">[bool]  Use coinstatsindex, if available.</param>
    /// <returns>[UniValue] Statistics about the unspent transaction output set.</returns>
    public async Task<ReddTransactionOutSetInfo> GetTxOutSetInfoAsync (ReddHashType hashType, Int32 height, Boolean useIndex = true) {
      ReddResponse<ReddTransactionOutSetInfo> response = await PostAsync<ReddTransactionOutSetInfo>(ReddMethods.GetTxOutSetInfo, hashType.ToString().ToLowerInvariant(), height, useIndex);
      m_LastError = response.Error;
      return response.Result;
    }

    #endregion gettxoutsetinfo ( "hash_type" hash_or_height use_index )

    #region preciousblock "blockhash"
    #endregion preciousblock "blockhash"

    #region pruneblockchain height
    #endregion pruneblockchain height

    #region savemempool
    #endregion savemempool

    #region scantxoutset "action" ( [scanobjects,...] )
    #endregion scantxoutset "action" ( [scanobjects,...] )

    #region verifychain ( checklevel nblocks )
    #endregion verifychain ( checklevel nblocks )

    #region verifytxoutproof "proof"
    #endregion verifytxoutproof "proof"

  }

}
