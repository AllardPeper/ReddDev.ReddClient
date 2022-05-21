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
  /// [UniValue] Block statistics for a given window
  /// </summary>
  public class ReddGetBlockStats {

    /// <summary>
    /// [int64_t] Average fee in the block
    /// </summary>
    [JsonProperty(PropertyName = "avgfee")]
    public Int64 AvgFee { get; set; }

    /// <summary>
    /// [int64_t] Average feerate (in satoshis per virtual byte)
    /// </summary>
    [JsonProperty(PropertyName = "avgfeerate")]
    public Int64 AvgFeeRate { get; set; }

    /// <summary>
    /// [int64_t] Average transaction size
    /// </summary>
    [JsonProperty(PropertyName = "avgtxsize")]
    public Int64 AvgTxSize { get; set; }

    /// <summary>
    /// [string] The block hash (to check for potential reorgs)
    /// </summary>
    [JsonProperty(PropertyName = "blockhash")]
    public String BlockHash { get; set; }

    /// <summary>
    /// [int64_t[]] Feerates at the 10th, 25th, 50th, 75th, and 90th percentile weight unit (in satoshis per virtual byte)
    /// </summary>
    [JsonProperty(PropertyName = "feerate_percentiles")]
    public List<Int64> FeeRatePercentiles { get; set; }

    /// <summary>
    /// [int64_t] The height of the block
    /// </summary>
    [JsonProperty(PropertyName = "height")]
    public Int64 Height { get; set; }

    /// <summary>
    /// [int64_t] The number of inputs (excluding coinbase)
    /// </summary>
    [JsonProperty(PropertyName = "ins")]
    public Int64 Ins { get; set; }

    /// <summary>
    /// [int64_t] Maximum fee in the block
    /// </summary>
    [JsonProperty(PropertyName = "maxfee")]
    public Int64 MaxFee { get; set; }

    /// <summary>
    /// [int64_t] Maximum feerate (in satoshis per virtual byte)
    /// </summary>
    [JsonProperty(PropertyName = "maxfeerate")]
    public Int64 MaxFeeRate { get; set; }

    /// <summary>
    /// [int64_t] Maximum transaction size
    /// </summary>
    [JsonProperty(PropertyName = "maxtxsize")]
    public Int64 MaxtxSize { get; set; }

    /// <summary>
    /// [int64_t] Truncated median fee in the block
    /// </summary>
    [JsonProperty(PropertyName = "medianfee")]
    public Int64 MedianFee { get; set; }

    /// <summary>
    /// [int64_t] The block median time past
    /// </summary>
    [JsonProperty(PropertyName = "mediantime")]
    public Int64 MedianTime { get; set; }

    /// <summary>
    /// [int64_t] Truncated median transaction size
    /// </summary>
    [JsonProperty(PropertyName = "mediantxsize")]
    public Int64 MediantxSize { get; set; }

    /// <summary>
    /// [int64_t] Minimum fee in the block
    /// </summary>
    [JsonProperty(PropertyName = "minfee")]
    public Int64 MinFee { get; set; }

    /// <summary>
    /// [int64_t] Minimum feerate (in satoshis per virtual byte)
    /// </summary>
    [JsonProperty(PropertyName = "minfeerate")]
    public Int64 MinFeeRate { get; set; }

    /// <summary>
    /// [int64_t] Minimum transaction size
    /// </summary>
    [JsonProperty(PropertyName = "mintxsize")]
    public Int64 MinTxSize { get; set; }

    /// <summary>
    /// [int64_t] The number of outputs
    /// </summary>
    [JsonProperty(PropertyName = "outs")]
    public Int64 Outs { get; set; }

    /// <summary>
    /// [int64_t] The block subsidy
    /// </summary>
    [JsonProperty(PropertyName = "subsidy")]
    public Int64 Subsidy { get; set; }

    /// <summary>
    /// [int64_t] Total size of all segwit transactions
    /// </summary>
    [JsonProperty(PropertyName = "swtotal_size")]
    public Int64 SwTotalSize { get; set; }

    /// <summary>
    /// [int64_t] Total weight of all segwit transactions
    /// </summary>
    [JsonProperty(PropertyName = "swtotal_weight")]
    public Int64 SwTotalWeight { get; set; }

    /// <summary>
    /// [int64_t] The number of segwit transactions
    /// </summary>
    [JsonProperty(PropertyName = "swtxs")]
    public Int64 SwTxs { get; set; }

    /// <summary>
    /// [int64_t] The block time
    /// </summary>
    [JsonProperty(PropertyName = "time")]
    public Int64 Time { get; set; }

    /// <summary>
    /// [int64_t] Total amount in all outputs (excluding coinbase and thus reward [ie subsidy + totalfee])
    /// </summary>
    [JsonProperty(PropertyName = "total_out")]
    public Int64 TotalOut { get; set; }

    /// <summary>
    /// [int64_t] Total size of all non-coinbase transactions
    /// </summary>
    [JsonProperty(PropertyName = "total_size")]
    public Int64 TotalSize { get; set; }

    /// <summary>
    /// [int64_t] Total weight of all non-coinbase transactions
    /// </summary>
    [JsonProperty(PropertyName = "total_weight")]
    public Int64 TotalWeight { get; set; }

    /// <summary>
    /// [int64_t] The fee total
    /// </summary>
    [JsonProperty(PropertyName = "totalfee")]
    public Int64 TotalFee { get; set; }

    /// <summary>
    /// [int64_t] The number of transactions (including coinbase)
    /// </summary>
    [JsonProperty(PropertyName = "txs")]
    public Int64 Txs { get; set; }

    /// <summary>
    /// [int64_t] The increase/decrease in the number of unspent outputs
    /// </summary>
    [JsonProperty(PropertyName = "utxo_increase")]
    public Int64 UtxoIncrease { get; set; }

    /// <summary>
    /// [int64_t] The increase/decrease in size for the utxo index (not discounting op_return and similar)
    /// </summary>
    [JsonProperty(PropertyName = "utxo_size_inc")]
    public Int64 UtxoSizeInc { get; set; }

  }
}
