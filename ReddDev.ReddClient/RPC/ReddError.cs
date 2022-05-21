// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
using Newtonsoft.Json;

namespace ReddDev.ReddClient.RPC {

  /// <summary>
  /// In case of error a code and message is returned
  /// </summary>
  public class ReddError {

    /// <summary>
    /// [int] Error code can be mapped to ReddErrorCodes
    /// </summary>
    [JsonProperty(PropertyName = "code")]
    public ReddErrorCodes Code { get; set; }

    /// <summary>
    /// [string] Readable error message
    /// </summary>
    [JsonProperty(PropertyName = "message")]
    public String Message { get; set; }

  }

}
