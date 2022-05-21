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
  /// Taproot
  /// </summary>
  public class ReddSoftFork {

    /// <summary>
    /// [string] burried or bip9
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public String Type { get; set; }

    /// <summary>
    /// [bool] True if the rules are enforced for the mempool and the next block
    /// </summary>
    [JsonProperty(PropertyName = "active")]
    public Boolean Active { get; set; }

    /// <summary>
    /// [int] Height of the first block which the rules are or will be enforced (only for "buried" type, or "bip9" type
    /// </summary>
    [JsonProperty(PropertyName = "height")]
    public Int32 height { get; set; }

    /// <summary>
    /// [UniValue] Bitcoin Improvement Proposal 9
    /// Soft Fork Activation
    /// </summary>
    [JsonProperty(PropertyName = "bip9")]
    public ReddBIP9 Bip9 { get; set; }

  }

}
