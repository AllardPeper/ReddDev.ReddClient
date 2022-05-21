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
  /// Object containing various state info regarding blockchain processing.
  /// </summary>
  public class ReddBlockchainInfo {

    /// <summary>
    /// [string] Current network name (main, test, signet, regtest)
    /// </summary>
    [JsonProperty(PropertyName = "chain")]
    public String Chain { get; set; }

    /// <summary>
    /// [int] The height of the most-work fully-validated chain. The genesis block has height 0
    /// </summary>
    [JsonProperty(PropertyName = "blocks")]
    public Int32 Blocks { get; set; }

    /// <summary>
    /// [int] The current number of headers we have validated
    /// </summary>
    [JsonProperty(PropertyName = "headers")]
    public Int32 Headers { get; set; }

    /// <summary>
    /// [string] The hash of the currently best block
    /// </summary>
    [JsonProperty(PropertyName = "bestblockhash")]
    public String BestBlockHash { get; set; }

    /// <summary>
    /// [double] The current difficulty
    /// </summary>
    [JsonProperty(PropertyName = "difficulty")]
    public Double Difficulty { get; set; }

    /// <summary>
    /// [int64_t] Median time for the current best block
    /// </summary>
    [JsonProperty(PropertyName = "mediantime")]
    public Int64 MedianTime { get; set; }

    /// <summary>
    /// [double] Estimate of verification progress [0..1]
    /// </summary>
    [JsonProperty(PropertyName = "verificationprogress")]
    public Double VerificationProgress { get; set; }

    /// <summary>
    /// [bool] (debug information) estimate of whether this node is in Initial Block Download mode
    /// </summary>
    [JsonProperty(PropertyName = "initialblockdownload")]
    public Boolean InitialBlockDownload { get; set; }

    /// <summary>
    /// [string] Total amount of work in active chain, in hexadecimal
    /// </summary>
    [JsonProperty(PropertyName = "chainwork")]
    public String ChainWork { get; set; }

    /// <summary>
    /// [int64_t] The estimated size of the block and undo files on disk
    /// </summary>
    [JsonProperty(PropertyName = "size_on_disk")]
    public Int64 SizeOnDisk { get; set; }

    /// <summary>
    /// [bool] If the blocks are subject to pruning
    /// </summary>
    [JsonProperty(PropertyName = "pruned")]
    public Boolean Pruned { get; set; }

    /// <summary>
    /// [int] Lowest-height complete block stored (only present if pruning is enabled)
    /// </summary>
    [JsonProperty(PropertyName = "pruneheight")]
    public Int32 PruneHeight { get; set; }

    /// <summary>
    /// [bool] Whether automatic pruning is enabled (only present if pruning is enabled)
    /// </summary>
    [JsonProperty(PropertyName = "automatic_pruning")]
    public Boolean AutomaticPruning { get; set; }

    /// <summary>
    /// [int64_t] The target size used by pruning (only present if automatic pruning is enabled)
    /// </summary>
    [JsonProperty(PropertyName = "prune_target_size")]
    public Boolean PruneTargetSize { get; set; }

    /// <summary>
    /// [UniValue] Status of softforks
    /// </summary>
    [JsonProperty(PropertyName = "softforks")]
    public Dictionary<String, ReddSoftFork> SoftForks { get; set; }

    /// <summary>
    /// [string] Any network and blockchain warnings
    /// </summary>
    [JsonProperty(PropertyName = "warnings")]
    public String Warnings { get; set; }

  }

}
