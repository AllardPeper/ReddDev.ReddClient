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
  /// [CTxIn] An input of a transaction.
  /// It contains the location of the previous transaction's output that it claims 
  /// and a signature that matches the output's public key.
  /// </summary>
  public class ReddTransactionnInput {
    
    /// <summary>
    /// [string] Transaction Id
    /// </summary>
    [JsonProperty(PropertyName = "txid")]
    public String TransactionId { get; set; }

    /// <summary>
    /// [int64_t] vout
    /// </summary>
    [JsonProperty(PropertyName = "vout")]
    public Int64 Vout { get; set; }

    /// <summary>
    /// CScript object
    /// </summary>
    [JsonProperty(PropertyName = "scriptSig")]
    public ReddScriptSig ScriptSig { get; set; }

    /// <summary>
    /// [string] Coinbase hex string
    /// </summary>
    [JsonProperty(PropertyName = "coinbase")]
    public String CoinBase { get; set; }

    /// <summary>
    /// [string[]] Array of hashes of Transaction in widnesses
    /// </summary>
    [JsonProperty(PropertyName = "txinwitness")]
    public List<String> TransactionInWitness { get; set; }

    /// <summary>
    /// [int64_t] Sequence number
    /// </summary>
    [JsonProperty(PropertyName = "sequence")]
    public Int64 Sequence { get; set; }

  }

}
