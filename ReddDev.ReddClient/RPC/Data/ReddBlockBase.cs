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
  /// [CBlock] Meta information about a block
  /// </summary>
  public abstract class ReddBlockBase<T>:ReddBlockHeader {

    /// <summary>
    /// [string] Type of block ("PoS" or "PoW")
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public String Type { get; set; }

    /// <summary>
    /// [string] ProofOfStacke (Hex string)
    /// </summary>
    [JsonProperty(PropertyName = "hashproof")]
    public String HashProof { get; set; }

    /// <summary>
    /// [int] Entropybit
    /// </summary>
    [JsonProperty(PropertyName = "entropybit")]
    public Int32 EntropyBit { get; set; }

    /// <summary>
    /// [string] Hash modifier for proof-of-stake
    /// </summary>
    [JsonProperty(PropertyName = "modifier")]
    public String Modifier { get; set; }

    /// <summary>
    /// [string] Block Signature (Hex string)
    /// </summary>
    [JsonProperty(PropertyName = "blocksignature")]
    public String BlockSignature { get; set; }

    /// <summary>
    /// [int] The block size excluding witness data
    /// </summary>
    [JsonProperty(PropertyName = "strippedsize")]
    public Int32 StrippedSize { get; set; }

    /// <summary>
    /// [int] The block size
    /// </summary>
    [JsonProperty(PropertyName = "size")]
    public Int32 Size { get; set; }

    /// <summary>
    /// [int] The block weight as defined in BIP 141
    /// </summary>
    [JsonProperty(PropertyName = "weight")]
    public Int32 Weight { get; set; }

    /// <summary>
    /// [CTransaction] or [string] The transaction ids
    /// </summary>
    [JsonProperty(PropertyName = "tx")]
    public List<T> Transactions { get; set; }

  }

}
