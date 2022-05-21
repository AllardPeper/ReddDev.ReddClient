// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
using Newtonsoft.Json;

namespace ReddDev.ReddClient.RPC.Data {

  /// <summary>
  /// [UniValue] Info on amounts in the block at this block height
  /// </summary>
  public class ReddBlockInfo {

    /// <summary>
    /// [CAmount] 
    /// </summary>
    [JsonProperty(PropertyName = "prevout_spent")]
    public Decimal PrevoutSpent { get; set; }

    /// <summary>
    /// [CAmount] 
    /// </summary>
    [JsonProperty(PropertyName = "coinbase")]
    public Decimal Coinbase { get; set; }

    /// <summary>
    /// [CAmount] 
    /// </summary>
    [JsonProperty(PropertyName = "new_outputs_ex_coinbase")]
    public Decimal NewOutputsExCoinbase { get; set; }

    /// <summary>
    /// [CAmount] 
    /// </summary>
    [JsonProperty(PropertyName = "unspendable")]
    public Decimal Unspendable { get; set; }

    /// <summary>
    /// [UniValue] Detailed view of the unspendable categories
    /// </summary>
    [JsonProperty(PropertyName = "unspendables")]
    public ReddUnspendable Unspendables { get; set; }

  }

}
