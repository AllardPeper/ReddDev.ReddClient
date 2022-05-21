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
  /// Block transaction
  /// </summary>
  public class ReddTransaction {

    /// <summary>
    /// [string] Transaction id
    /// </summary>
    [JsonProperty(PropertyName = "txid")]
    public String TransactionId { get; set; }

    /// <summary>
    /// [string] Hash
    /// </summary>
    [JsonProperty(PropertyName = "hash")]
    public String Hash { get; set; }

    /// <summary>
    /// [string] version
    /// </summary>
    [JsonProperty(PropertyName = "version")]
    public Int64 Version { get; set; }

    /// <summary>
    /// [int] Size of the serialized block in bytes
    /// </summary>
    [JsonProperty(PropertyName = "size")]
    public Int32 Size { get; set; }

    /// <summary>
    /// [int64_t] Weighted virtual size ?
    /// </summary>
    [JsonProperty(PropertyName = "vsize")]
    public Int64 VSize { get; set; }

    /// <summary>
    /// [int64_t] Weight
    /// </summary>
    [JsonProperty(PropertyName = "weight")]
    public Int32 Weight { get; set; }

    /// <summary>
    /// [int64_t] Lock time
    /// </summary>
    [JsonProperty(PropertyName = "locktime")]
    public Int64 LockTime { get; set; }

    /// <summary>
    /// [CTxIn] Transactionn input
    /// </summary>
    [JsonProperty(PropertyName = "vin")]
    public List<ReddTransactionnInput> TransactionnInput { get; set; }

    /// <summary>
    /// [CTxOut] Transactionn output
    /// </summary>
    [JsonProperty(PropertyName = "vout")]
    public List<ReddTransactionnOutput> TransactionnOutput { get; set; }

    /// <summary>
    /// [String] optional fee
    /// </summary>
    [JsonProperty(PropertyName = "fee")]
    public String Fee { get; set; }

    /// <summary>
    /// [string] optional blockhash
    /// </summary>
    [JsonProperty(PropertyName = "blockhash")]
    public String Blockhash { get; set; }

    /// <summary>
    /// The hex-encoded transaction. Used the name "hex" to be consistent with the verbose output of "getrawtransaction".
    /// </summary>
    [JsonProperty(PropertyName = "hex")]
    public String HexEncodedTransaction { get; set; }

  }

}
