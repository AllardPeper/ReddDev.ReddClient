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
  /// [UniValue] Return information about all known tips in the block tree, including the main chain as well as orphaned branches.
  /// </summary>
  public class ReddChainTips {

    /// <summary>
    /// [int] Height of the chain tip
    /// </summary>
    [JsonProperty(PropertyName = "height")]
    public Int32 Height { get; set; }

    /// <summary>
    /// [string] Block hash of the tip
    /// </summary>
    [JsonProperty(PropertyName = "hash")]
    public String Hash { get; set; }

    /// <summary>
    /// [int] Zero for main chain, otherwise length of branch connecting the tip to the main chain
    /// </summary>
    [JsonProperty(PropertyName = "branchlen")]
    public Int32 Branchlen { get; set; }

    /// <summary>
    /// [string] Status of the chain, "active" for the main chain
    /// 1.  "invalid"               This branch contains at least one invalid block
    /// 2.  "headers-only"          Not all blocks for this branch are available, but the headers are valid
    /// 3.  "valid-headers"         All blocks are available for this branch, but they were never fully validated
    /// 4.  "valid-fork"            This branch is not part of the active chain, but is fully validated
    /// 5.  "active"                This is the tip of the active main chain, which is certainly valid
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public String Status { get; set; }
  }

}
