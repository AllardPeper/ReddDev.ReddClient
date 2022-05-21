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
  /// BIP9Stats
  /// </summary>
  public class ReddBIP9Statistics {

    /// <summary>
    /// [int] Length of blocks of the BIP9 signalling period
    /// </summary>
    [JsonProperty(PropertyName = "period")]
    public Int32 Period { get; set; }

    /// <summary>
    /// [int] Number of blocks with the version bit set required to activate the softfork */
    /// </summary>
    [JsonProperty(PropertyName = "threshold")]
    public Int32 Threshold { get; set; }

    /// <summary>
    /// [int] Number of blocks elapsed since the beginning of the current period
    /// </summary>
    [JsonProperty(PropertyName = "elapsed")]
    public Int32 Elapsed { get; set; }

    /// <summary>
    /// [int] Number of blocks with the version bit set since the beginning of the current period
    /// </summary>
    [JsonProperty(PropertyName = "count")]
    public Int32 Count { get; set; }

    /// <summary>
    /// [bool] False if there are not enough blocks left in this period to pass activation threshold
    /// </summary>
    [JsonProperty(PropertyName = "possible")]
    public Boolean Possible { get; set; }

  }

}
