// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
using Newtonsoft.Json;
using ReddDev.ReddClient.RPC.Data;

namespace ReddDev.ReddClient.RPC.Responses {

  /// <summary>
  /// Returns statistics about the unspent transaction output set
  /// 
  /// Note this call may take some time if you are not using coinstatsindex.
  /// 
  /// Note 2 some calls will fail when coinstatsindex is not active. 
  /// Activite it using the -coinstatsindex argument when stating the core wallet.
  /// </summary>
  public class ReddTransactionOutSetInfo {

    /// <summary>
    /// [int64_t] The block height (index) of the returned statistics
    /// </summary>
    [JsonProperty(PropertyName = "height")]
    public Int64 Height { get; set; }

    /// <summary>
    /// [string] The hash of the block at which these statistics are calculated
    /// </summary>
    [JsonProperty(PropertyName = "bestblock")]
    public String BestBlock { get; set; }

    /// <summary>
    /// [int64_t] The number of unspent transaction outputs
    /// </summary>
    [JsonProperty(PropertyName = "txouts")]
    public Int64 TxOuts { get; set; }

    /// <summary>
    /// [int64_t] Database-independent, meaningless metric indicating the UTXO set size
    /// </summary>
    [JsonProperty(PropertyName = "bogosize")]
    public Int64 BogoSize { get; set; }

    /// <summary>
    /// [string] The serialized hash (only present if 'hash_serialized_2' hash_type is chosen)
    /// </summary>
    [JsonProperty(PropertyName = "hash_serialized_2")]
    public String HashSerialized2 { get; set; }

    /// <summary>
    /// [string] The serialized hash (only present if 'muhash' hash_type is chosen)
    /// </summary>
    [JsonProperty(PropertyName = "muhash")]
    public String MuHash { get; set; }

    /// <summary>
    /// [CAmount] The total amount of coins in the UTXO set
    /// </summary>
    [JsonProperty(PropertyName = "total_amount")]
    public Decimal TotalAmount { get; set; }

    #region Basic

    /// <summary>
    /// [int64_t] The number of transactions with unspent outputs (not available when coinstatsindex is used)
    /// </summary>
    [JsonProperty(PropertyName = "transactions")]
    public Int64 Transactions { get; set; }

    /// <summary>
    /// [uint64_t] The estimated size of the chainstate on disk (not available when coinstatsindex is used)
    /// </summary>
    [JsonProperty(PropertyName = "disk_size")]
    public Int64 DiskSize { get; set; }

    #endregion Basic

    #region Advanced (Only possible when Hash type is None or MuHash and useIndex = true and wallet is started with -coinstatsindex)

    /// <summary>
    /// [CAmount] The total amount of coins permanently excluded from the UTXO set (only available if coinstatsindex is used)
    /// </summary>
    [JsonProperty(PropertyName = "total_unspendable_amount")]
    public Decimal TotalUnspendableAmount { get; set; }

    /// <summary>
    /// [UniValue] Info on amounts in the block at this block height (only available if coinstatsindex is used)
    /// </summary>
    [JsonProperty(PropertyName = "block_info")]
    public ReddBlockInfo BlockInfo { get; set; }

    #endregion Advanced 
  }

}
