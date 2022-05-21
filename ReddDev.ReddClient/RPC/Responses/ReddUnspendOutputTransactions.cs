// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
using Newtonsoft.Json;
using ReddDev.ReddClient.RPC.Data;

namespace ReddDev.ReddClient.RPC.Responses {

  /// <summary>
  /// Details about an unspent transaction output
  /// </summary>
  public class ReddUnspendOutputTransactions {

    /// <summary>
    /// [string] The hash of the block at the tip of the chain
    /// </summary>
    [JsonProperty(PropertyName = "bestblock")]
    public String Bestblock { get; set; }

    /// <summary>
    /// [int64_t] The number of confirmations
    /// </summary>
    [JsonProperty(PropertyName = "confirmations")]
    public Int64 Confirmations { get; set; }

    /// <summary>
    /// [CAmount] The transaction value in RDD
    /// </summary>
    [JsonProperty(PropertyName = "value")]
    public Decimal Value { get; set; }

    /// <summary>
    /// [UniValue] ScriptPubKey
    /// </summary>
    [JsonProperty(PropertyName = "scriptPubKey")]
    public ReddScriptSig ScriptPubKey { get; set; }

    /// <summary>
    /// [bool] Coinbase or not
    /// </summary>
    [JsonProperty(PropertyName = "coinbase")]
    public Boolean Coinbase { get; set; }

  }

}
