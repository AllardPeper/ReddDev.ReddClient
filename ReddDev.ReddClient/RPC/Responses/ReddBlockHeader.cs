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
  /// Object with information about blockheader
  /// </summary>
  public class ReddBlockHeader {

    /// <summary>
    /// [string] The block hash
    /// </summary>
    [JsonProperty(PropertyName = "hash")]
    public String Hash { get; set; }

    /// <summary>
    /// [int] The number of confirmations, or -1 if the block is not on the main chain
    /// </summary>
    [JsonProperty(PropertyName = "confirmations")]
    public Int32 Confirmations { get; set; }

    /// <summary>
    /// [int] The block height or index
    /// </summary>
    [JsonProperty(PropertyName = "height")]
    public Int32 Height { get; set; }

    /// <summary>
    /// [int] The block version
    /// </summary>
    [JsonProperty(PropertyName = "version")]
    public Int32 Version { get; set; }

    /// <summary>
    /// [string] The block version formatted in hexadecimal
    /// </summary>
    [JsonProperty(PropertyName = "versionHex")]
    public String VersionHex { get; set; }

    /// <summary>
    /// [string] The merkle root
    /// </summary>
    [JsonProperty(PropertyName = "merkleroot")]
    public String MerkleRoot { get; set; }

    /// <summary>
    /// [int64_t] The block time expressed in UNIX epoch time
    /// </summary>
    [JsonProperty(PropertyName = "time")]
    public Int64 Time { get; set; }

    /// <summary>
    /// [int64_t] The median block time expressed in UNIX epoch time
    /// </summary>
    [JsonProperty(PropertyName = "mediantime")]
    public Int64 MedianTime { get; set; }

    /// <summary>
    /// [uint64_t] The nonce
    /// </summary>
    [JsonProperty(PropertyName = "nonce")]
    public Int64 Nonce { get; set; }

    /// <summary>
    /// [string] The bits
    /// </summary>
    [JsonProperty(PropertyName = "bits")]
    public String Bits { get; set; }

    /// <summary>
    /// [double] The difficulty
    /// </summary>
    [JsonProperty(PropertyName = "difficulty")]
    public Double Difficulty { get; set; }

    /// <summary>
    /// [string] Expected number of hashes required to produce the current chain
    /// </summary>
    [JsonProperty(PropertyName = "chainwork")]
    public String ChainWork { get; set; }

    /// <summary>
    /// [uint64_t] The number of transactions in the block
    /// </summary>
    [JsonProperty(PropertyName = "nTx")]
    public Int64 nTx { get; set; }

    /// <summary>
    /// [string] The hash of the previous block (if available)
    /// </summary>
    [JsonProperty(PropertyName = "previousblockhash")]
    public String PreviousBlockHash { get; set; }

    /// <summary>
    /// [string] The hash of the next block (if available)
    /// </summary>
    [JsonProperty(PropertyName = "nextblockhash")]
    public String NextBlockHash { get; set; }

  }

}
