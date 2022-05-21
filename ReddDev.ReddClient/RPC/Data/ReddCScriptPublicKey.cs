// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ReddDev.ReddClient.RPC.Data {

  /// <summary>
  /// CScript public key
  /// </summary>
  public class ReddCScriptPublicKey {

    /// <summary>
    /// [string] Assembly string representation of a CScript object
    /// </summary>
    [JsonProperty(PropertyName = "asm")]
    public String Asm { get; set; }
    
    /// <summary>
    /// [string] Hash of the CStript object (optional)
    /// </summary>
    [JsonProperty(PropertyName = "hex")]
    public String Hex { get; set; }

    /// <summary>
    /// [string] Transaction output type
    /// "nonstandard", "pubkey", "pubkeyhash", "scripthash", "multisig", "nulldata", "witness_v0_keyhash", 
    /// "witness_v0_scripthash", "witness_v1_taproot", "witness_unknown";
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public String Type { get; set; }

    /// <summary>
    /// DEPRECATED
    /// [string[]] Encoded CTxDestination objects
    /// </summary>
    [JsonProperty(PropertyName = "addresses")]
    public List<String> Addresses { get; set; }

    /// <summary>
    /// DEPRECATED
    /// [int] reqSigs
    /// </summary>
    [JsonProperty(PropertyName = "reqSigs")]
    public Int32 ReqSigs { get; set; }

  }

}
