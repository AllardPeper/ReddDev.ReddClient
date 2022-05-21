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
  /// [CTxOut] An output of a transaction,
  /// It contains the public key that the next input must be able to sign with to claim it.
  /// </summary>
  public class ReddTransactionnOutput {

    /// <summary>
    /// [CAmount] Value 
    /// CAmount is formatted as [-][int64_t].[int64_t] 
    /// where quotient = amount / 100000000
    /// and remainder = amount % 100000000
    /// </summary>
    [JsonProperty(PropertyName = "value")]
    public Decimal Value { get; set; }

    /// <summary>
    /// [int64_t] Index
    /// </summary>
    [JsonProperty(PropertyName = "n")]
    public Int64 Index { get; set; }

    /// <summary>
    /// [CScript] CScript public key
    /// </summary>
    [JsonProperty(PropertyName = "scriptPubKey")]
    public ReddCScriptPublicKey CScriptPublicKey { get; set; }

  }

}
