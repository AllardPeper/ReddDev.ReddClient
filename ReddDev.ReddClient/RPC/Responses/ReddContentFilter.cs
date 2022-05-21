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
  /// BIP 157 content filter for a particular block
  /// </summary>
  public class ReddContentFilter {

    /// <summary>
    /// [string] The block hash
    /// </summary>
    [JsonProperty(PropertyName = "filter")]
    public String Filter { get; set; }

    /// <summary>
    /// [string] The block hash
    /// </summary>
    [JsonProperty(PropertyName = "header")]
    public String Header { get; set; }

  }

}
