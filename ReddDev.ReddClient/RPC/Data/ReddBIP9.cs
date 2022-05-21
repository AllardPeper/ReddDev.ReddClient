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
  /// Bitcoin Improvement Proposal 9
  /// A standard framework for activating soft fork upgrades to the Bitcoin protocol.
  /// </summary>
  public class ReddBIP9 {

    /// <summary>
    /// [string] One of "defined", "started", "locked_in", "active", "failed"
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public String Status { get; set; }

    /// <summary>
    /// [int] Bit position to select the particular bit in nVersion.
    /// </summary>
    [JsonProperty(PropertyName = "bit")]
    public Int32 Bit { get; set; }

    /// <summary>
    /// [int64_t] The minimum median time past of a block at which the bit gains its meaning
    /// </summary>
    [JsonProperty(PropertyName = "start_time")]
    public Int64 StartTime { get; set; }

    /// <summary>
    /// [int64_t] The median time past of a block at which the deployment is considered failed if not yet locked in
    /// </summary>
    [JsonProperty(PropertyName = "timeout")]
    public Int64 Timeout { get; set; }

    /// <summary>
    /// [int64_t] Height of the first block to which the status applies
    /// </summary>
    [JsonProperty(PropertyName = "since")]
    public Int64 Since { get; set; }

    /// <summary>
    /// [BIP9Stats] Bip9 statistics
    /// </summary>
    [JsonProperty(PropertyName = "statistics")]
    public ReddBIP9Statistics Statistics { get; set; }

    /// <summary>
    /// [int] Minimum height of blocks for which the rules may be enforced
    /// </summary>
    [JsonProperty(PropertyName = "min_activation_height")]
    public Int32 MinActivationHeight { get; set; }

  }

}
