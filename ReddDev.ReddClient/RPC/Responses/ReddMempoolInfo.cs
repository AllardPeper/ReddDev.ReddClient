// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
using Newtonsoft.Json;

namespace ReddDev.ReddClient.RPC.Responses {

  /// <summary>
  /// [UniValue] CTxMemPool
  /// </summary>
  public class ReddMempoolInfo {

    /// <summary>
    /// [bool] True if the mempool is fully loaded
    /// </summary>
    [JsonProperty(PropertyName = "loaded")]
    public Boolean Loaded { get; set; }

    /// <summary>
    /// [int64_t] Current tx count
    /// </summary>
    [JsonProperty(PropertyName = "size")]
    public Int64 Size { get; set; }

    /// <summary>
    /// [int64_t] Sum of all virtual transaction sizes as defined in BIP 141. Differs from actual serialized size because witness data is discounted
    /// </summary>
    [JsonProperty(PropertyName = "bytes")]
    public Int64 Bytes { get; set; }

    /// <summary>
    /// [int64_t] Total memory usage for the mempool
    /// </summary>
    [JsonProperty(PropertyName = "usage")]
    public Int64 Usage { get; set; }

    /// <summary>
    /// [CAmount] Total fees for the mempool in RDD, ignoring modified fees through prioritizetransaction
    /// </summary>
    [JsonProperty(PropertyName = "total_fee")]
    public Boolean TotalFee { get; set; }

    /// <summary>
    /// [int64_t] Maximum memory usage for the mempool
    /// </summary>
    [JsonProperty(PropertyName = "maxmempool")]
    public Int64 MaxMempool { get; set; }

    /// <summary>
    /// [CAmount] Minimum fee rate in RDD/kvB for tx to be accepted. Is the maximum of minrelaytxfee and minimum mempool fee
    /// </summary>
    [JsonProperty(PropertyName = "mempoolminfee")]
    public Decimal MempoolMinFee { get; set; }

    /// <summary>
    /// [CAmount] Current minimum relay fee for transactions
    /// </summary>
    [JsonProperty(PropertyName = "minrelaytxfee")]
    public Decimal MinRelayTXFee { get; set; }

    /// <summary>
    /// [uint64_t] Current number of transactions that haven't passed initial broadcast yet
    /// </summary>
    [JsonProperty(PropertyName = "unbroadcastcount")]
    public Int64 UnbroadcastCount { get; set; }

  }

}
