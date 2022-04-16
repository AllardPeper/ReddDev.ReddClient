using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReddDev.ReddClient.RPC.Data;
using ReddDev.ReddClient.RPC.Responses;

namespace ReddDev.ReddClient.RPC {

  /// <summary>
  /// ReddCoin wallet Blockchain RPC methods
  /// </summary>
  public partial class ReddClient {

    /// <summary>
    /// Returns the hash of the best (tip) block in the most-work fully-validated chain.
    /// </summary>
    /// <returns>The block hash, hex-encoded</returns>
    public String GetBestBlockHash () {
      Task<String> result = GetBestBlockHashAsync();
      result.Wait();
      return result.Result;
    }

    /// <summary>
    /// Returns the hash of the best (tip) block in the most-work fully-validated chain.
    /// </summary>
    /// <returns>The block hash, hex-encoded</returns>
    public async Task<String> GetBestBlockHashAsync () {
      return await PostAsync<String>(ReddMethods.GetBestBlockHash);
    }

    /// <summary>
    /// getblock "blockhash" ( verbosity = 0 | 1 )
    /// </summary>
    /// <returns>Block</returns>
    public ReddBlock GetBlock (String blockHash, Boolean verbosity = false) {
      Int32 verbosityValue = 0;
      if (verbosity) {
        verbosityValue = 1;
      }
      Task<ReddBlockBase> result = GetBlockAsync(blockHash, verbosityValue);
      result.Wait();
      return (ReddBlock)result.Result;
    }

    /// <summary>
    /// getblock "blockhash" ( verbosity = 0 | 1 )
    /// </summary>
    /// <returns>Block</returns>
    public async Task<ReddBlock> GetBlockAsync (String blockHash, Boolean verbosity) {
      Int32 verbosityValue = 0;
      if (verbosity) {
        verbosityValue = 1;
      }
      return (ReddBlock)await GetBlockAsync(blockHash, verbosityValue);
    }

    /// <summary>
    /// getblock "blockhash" ( verbosity = 2 )
    /// </summary>
    /// <returns>Block</returns>
    public ReddBlockTransactions GetBlockTransactions (String blockHash) {
      Task<ReddBlockBase> result = GetBlockAsync(blockHash, 2);
      result.Wait();
      return (ReddBlockTransactions)result.Result;
    }


    /// <summary>
    /// getblock "blockhash" ( verbosity = 2 )
    /// </summary>
    /// <returns>Block</returns>
    public async Task<ReddBlockTransactions> GetBlockTransactionsAsync (String blockHash) {
      return (ReddBlockTransactions)await GetBlockAsync(blockHash, 2);
    }

    /// <summary>
    /// getblock "blockhash" ( verbosity ) Async
    /// </summary>
    /// <returns>Block</returns>
    private async Task<ReddBlockBase> GetBlockAsync (String blockHash, Int32 verbosity = 0) {
      switch (verbosity) {
        case 1:
          return await PostAsync<ReddBlock>(ReddMethods.GetBlock, blockHash, true);
        case 2:
          return await PostAsync<ReddBlockTransactions>(ReddMethods.GetBlock, blockHash, 2);
        default:
          return await PostAsync<ReddBlock>(ReddMethods.GetBlock, blockHash, false);
      }
    }


    //getblockchaininfo
    //getblockcount
    //getblockfilter "blockhash" ( "filtertype" )
    //getblockhash height
    //getblockheader "blockhash" ( verbose )
    //getblockstats hash_or_height ( stats )
    //getchaintips
    //getchaintxstats ( nblocks "blockhash" )
    //getdifficulty
    //getmempoolancestors "txid" ( verbose )
    //getmempooldescendants "txid" ( verbose )
    //getmempoolentry "txid"
    //getmempoolinfo
    //getrawmempool ( verbose mempool_sequence )
    //gettxout "txid" n ( include_mempool )
    //gettxoutproof ["txid",...] ( "blockhash" )
    //gettxoutsetinfo ( "hash_type" hash_or_height use_index )
    //preciousblock "blockhash"
    //pruneblockchain height
    //savemempool
    //scantxoutset "action" ( [scanobjects,...] )
    //verifychain ( checklevel nblocks )
    //verifytxoutproof "proof"


  }

}
