// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
using ReddDev.ReddClient.RPC.Data;

namespace ReddDev.ReddClient.RPC.Responses {

  /// <summary>
  /// Reddcoin Block with transactions
  /// Counterpart of the CTransaction in the wallet
  /// </summary>
  public class ReddBlockTransactions: ReddBlockBase<ReddTransaction> {
  }
}
