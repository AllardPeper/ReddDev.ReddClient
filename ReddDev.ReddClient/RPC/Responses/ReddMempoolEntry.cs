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
  /// [UniValue] CTxMemPoolEntry
  /// </summary>
  public class ReddMempoolEntry {

    /// <summary>
    /// [UniValue] Analogous statistics for ancestor transactions
    /// </summary>
    [JsonProperty(PropertyName = "fees")]
    public ReddFees Fees { get; set; }

    /// <summary>
    /// [int] Virtual transaction size as defined in BIP 141. 
    /// This is different from actual serialized size for witness transactions as witness data is discounted.
    /// </summary>
    [JsonProperty(PropertyName = "vsize")]
    public Int32 VSize { get; set; }

    /// <summary>
    /// [int] Transaction weight as defined in BIP 141
    /// </summary>
    [JsonProperty(PropertyName = "weight")]
    public Int32 Weight { get; set; }

    ///// <summary>
    ///// [CAmount] Transaction fee in RDD (DEPRECATED)
    ///// </summary>
    //[JsonProperty(PropertyName = "fee")]
    //public Decimal Fee { get; set; }

    ///// <summary>
    ///// [CAmount] Transaction fee with fee deltas used for mining priority (DEPRECATED)
    ///// </summary>
    //[JsonProperty(PropertyName = "modifiedfee")]
    //public Decimal ModifiedFee { get; set; }

    /// <summary>
    /// [int64_t] Local time transaction entered pool in seconds since 1 Jan 1970 GMT
    /// </summary>
    [JsonProperty(PropertyName = "time")]
    public Int64 Time { get; set; }

    /// <summary>
    /// [int] Block height when transaction entered pool
    /// </summary>
    [JsonProperty(PropertyName = "height")]
    public Int32 Height { get; set; }

    /// <summary>
    /// [int64_t] Number of in-mempool descendant transactions (including this one)
    /// </summary>
    [JsonProperty(PropertyName = "descendantcount")]
    public Int64 SescendantCount { get; set; }

    /// <summary>
    /// [int64_t] Virtual transaction size of in-mempool descendants (including this one)
    /// </summary>
    [JsonProperty(PropertyName = "descendantsize")]
    public Int64 DescendantSize { get; set; }

    ///// <summary>
    ///// [CAmount] Modified fees (see above) of in-mempool descendants (including this one) (DEPRECATED)
    ///// </summary>
    //[JsonProperty(PropertyName = "descendantfees")]
    //public Int32 SescendantFees { get; set; }

    /// <summary>
    /// [int64_t] Number of in-mempool ancestor transactions (including this one)
    /// </summary>
    [JsonProperty(PropertyName = "ancestorcount")]
    public Int32 AncestorCount { get; set; }

    /// <summary>
    /// [int64_t] Virtual transaction size of in-mempool ancestors (including this one)
    /// </summary>
    [JsonProperty(PropertyName = "ancestorsize")]
    public Int32 AncestorSize { get; set; }

    ///// <summary>
    ///// [CAmount] Modified fees (see above) of in-mempool ancestors (including this one) (DEPRECATED)
    ///// </summary>
    //[JsonProperty(PropertyName = "ancestorfees")]
    //public Int32 AncestorFees { get; set; }

    /// <summary>
    /// [string] Hash of serialized transaction, including witness data
    /// </summary>
    [JsonProperty(PropertyName = "wtxid")]
    public String WTxId { get; set; }

    /// <summary>
    /// [string[]] Unconfirmed transactions used as inputs for this transaction
    /// </summary>
    [JsonProperty(PropertyName = "depends")]
    public List<String> Depends { get; set; }

    /// <summary>
    /// [string[]] Unconfirmed transactions spending outputs from this transaction
    /// </summary>
    [JsonProperty(PropertyName = "spentby")]
    public List<String> SpentBy { get; set; }

    /// <summary>
    /// [bool] Whether this transaction could be replaced due to BIP125 (replace-by-fee)
    /// </summary>
    [JsonProperty("bip125-replaceable")]
    public Boolean Bip125Replaceable { get; set; }

    /// <summary>
    /// [bool] Whether this transaction is currently unbroadcast (initial broadcast not yet acknowledged by any peers)
    /// </summary>
    [JsonProperty(PropertyName = "unbroadcast")]
    public Boolean UnbroadCast { get; set; }

  }

}
