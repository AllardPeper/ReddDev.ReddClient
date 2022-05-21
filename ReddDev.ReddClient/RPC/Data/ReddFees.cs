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
  /// Fees
  /// </summary>
  public class ReddFees {

    /// <summary>
    /// [CAmount] Transaction fee in RDD
    /// </summary>
    [JsonProperty(PropertyName = "base")]
    public Decimal Base { get; set; }

    /// <summary>
    /// [CAmount] Transaction fee with fee deltas used for mining priority in RDD
    /// </summary>
    [JsonProperty(PropertyName = "modified")]
    public Decimal Modified { get; set; }

    /// <summary>
    /// [CAmount] Modified fees (see above) of in-mempool ancestors (including this one) in RDD
    /// </summary>
    [JsonProperty(PropertyName = "ancestor")]
    public Decimal Ancestor { get; set; }

    /// <summary>
    /// [CAmount] Modified fees (see above) of in-mempool descendants (including this one) in RDD
    /// </summary>
    [JsonProperty(PropertyName = "descendant")]
    public Decimal Descendant { get; set; }

  }

}
