﻿// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
using Newtonsoft.Json;

namespace ReddDev.ReddClient.RPC.Data {

  /// <summary>
  /// CScript object as Assembly string representation and its hash
  /// </summary>
  public class ReddScriptSig {

    /// <summary>
    /// [string] Assembly string representation of a CScript object
    /// </summary>
    [JsonProperty(PropertyName = "asm")]
    public String CScript { get; set; }

    /// <summary>
    /// [string] Hex string for the CScript
    /// </summary>
    [JsonProperty(PropertyName = "hex")]
    public String Hex { get; set; }

    /// <summary>
    /// [string] The type, eg pubkeyhash
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public String Type { get; set; }

    /// <summary>
    /// [string] Reddcoin address (only if a well-defined address exists)
    /// </summary>
    [JsonProperty(PropertyName = "address")]
    public String Address { get; set; }

    ///// <summary>
    ///// [sting[]] (DEPRECATED, returned only if config option -deprecatedrpc=addresses is passed) Array of reddcoin addresses
    ///// </summary>
    //[JsonProperty(PropertyName = "addresses")]
    //public List<String> Addresses { get; set; }

    ///// <summary>
    ///// [int] (DEPRECATED, returned only if config option -deprecatedrpc=addresses is passed) Number of required signatures
    ///// </summary>
    //[JsonProperty(PropertyName = "reqSigs")]
    //public Int32 ReqSigs { get; set; }

  }

}
