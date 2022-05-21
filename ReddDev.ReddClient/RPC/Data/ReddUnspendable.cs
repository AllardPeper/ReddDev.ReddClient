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
  /// Unspendable amounts (not yours)
  /// </summary>
  public class ReddUnspendable {

    /// <summary>
    /// [CAmount] The first generated block
    /// </summary>
    [JsonProperty(PropertyName = "genesis_block")]
    public Decimal GenesisBlock { get; set; }

    /// <summary>
    /// [CAmount] Duplicate transactions
    /// 
    /// The problem was that in case a duplicate transaction was created in a side branch that is afterwards reverted, and is only seen by a certain portion of the network, 
    /// a fork risk exists. The nodes A that have seen the duplicate transactions and its reversal, will consider the original transaction unspendable 
    /// (as it was overwritten and subsequently removed from their transaction database in the reorganisation), 
    /// while nodes B that did not see the duplicate would consider the original spendable. When the original transaction is spent afterwards, and a majority of the network is in B, 
    /// the network will split, as the A nodes will consider the chain created by B as invalid.
    /// The third solution presented is implemented by BIP30 - this was a stopgap solution to prevent the worst from happening.A more complete solution (the first one) being deployed as BIP 34
    /// </summary>
    [JsonProperty(PropertyName = "bip30")]
    public Decimal Bip30 { get; set; }

    /// <summary>
    /// [CAmount] 
    /// </summary>
    [JsonProperty(PropertyName = "scripts")]
    public Decimal Scripts { get; set; }

    /// <summary>
    /// [CAmount] 
    /// </summary>
    [JsonProperty(PropertyName = "unclaimed_rewards")]
    public Decimal UnclaimedRewards { get; set; }

  }

}
