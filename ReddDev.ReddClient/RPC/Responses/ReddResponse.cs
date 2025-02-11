﻿// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
using Newtonsoft.Json;

namespace ReddDev.ReddClient.RPC.Responses {

  /// <summary>
  /// General response class for all RPC calls
  /// </summary>
  /// <typeparam name="T">Expected return type, in case of error this will be null</typeparam>
  public class ReddResponse<T> {

    /// <summary>
    /// Expected result of type <T>
    /// </summary>
    [JsonProperty(PropertyName = "result", Order = 0)]
    public T Result { get; set; }

    /// <summary>
    /// Id of the transaction
    /// </summary>
    [JsonProperty(PropertyName = "id", Order = 1)]
    public Int32? Id { get; set; }

    /// <summary>
    // Error object in case of error or null when no error occurred
    /// </summary>
    [JsonProperty(PropertyName = "error", Order = 2)]
    public ReddError Error { get; set; }

  }

}
