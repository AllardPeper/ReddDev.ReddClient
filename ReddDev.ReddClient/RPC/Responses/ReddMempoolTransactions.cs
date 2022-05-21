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
  /// Transaction list and mempool sequence number
  /// </summary>
  public class ReddMempoolTransactions {

    /// <summary>
    /// [string[]] True if the mempool is fully loaded
    /// </summary>
    [JsonProperty(PropertyName = "txids")]
    public List<String> TransactionIds { get; set; }

    /// <summary>
    /// [uint64_t] True if the mempool is fully loaded
    /// </summary>
    [JsonProperty(PropertyName = "mempool_sequence")]
    public Int64 MempoolSequence { get; set; }

  }

}
