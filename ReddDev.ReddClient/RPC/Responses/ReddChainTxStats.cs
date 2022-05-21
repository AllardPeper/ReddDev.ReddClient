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
  /// Compute statistics about the total number and rate of transactions in the chain.
  /// </summary>
  public class ReddChainTxStats {

    /// <summary>
    /// [int64_t] The timestamp for the final block in the window, expressed in UNIX epoch time
    /// </summary>
    [JsonProperty(PropertyName = "time")]
    public Int64 Time { get; set; }

    /// <summary>
    /// [int64_t] The total number of transactions in the chain up to that point
    /// </summary>
    [JsonProperty(PropertyName = "txcount")]
    public Int64 TxCount { get; set; }

    /// <summary>
    /// [string] The hash of the final block in the window
    /// </summary>
    [JsonProperty(PropertyName = "window_final_block_hash")]
    public String WindowFinalBlockHash { get; set; }

    /// <summary>
    /// [int] The height of the final block in the window.
    /// </summary>
    [JsonProperty(PropertyName = "window_final_block_height")]
    public Int32 WindowFinalBlockHeight { get; set; }

    /// <summary>
    /// [int] Size of the window in number of blocks
    /// </summary>
    [JsonProperty(PropertyName = "window_block_count")]
    public Int32 WindowBlockCount { get; set; }

    /// <summary>
    /// [int] The number of transactions in the window. Only returned if "window_block_count" is > 0
    /// </summary>
    [JsonProperty(PropertyName = "window_tx_count")]
    public Int32 WindowTxCount { get; set; }

    /// <summary>
    /// [int] The elapsed time in the window in seconds. Only returned if "window_block_count" is > 0
    /// </summary>
    [JsonProperty(PropertyName = "window_interval")]
    public Int32 WindowInterval { get; set; }

    /// <summary>
    /// [double] The average rate of transactions per second in the window. Only returned if "window_interval" is > 0
    /// </summary>
    [JsonProperty(PropertyName = "txrate")]
    public Double TxRate { get; set; }
  }

}
