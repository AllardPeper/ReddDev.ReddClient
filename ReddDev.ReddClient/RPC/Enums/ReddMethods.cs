﻿// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
namespace ReddDev.ReddClient.RPC {

  /// <summary>
  /// Methods
  /// </summary>
  internal enum ReddMethods {
    Unknown,
    GetBestBlockHash,
    GetBlock,
    GetBlockChainInfo,
    GetBlockCount,
    GetBlockFilter,
    GetBlockHash,
    GetBlockHeader,
    GetBlockStats,
    GetChainTips,
    GetChainTxStats,
    GetDifficulty,
    GetMempoolAncestors,
    GetMempoolDescendants,
    GetMempoolEntry,
    GetMempoolInfo,
    GetRawMempool,
    GetTxOut,
    GetTxoutProof,
    GetTxOutSetInfo,
  }
}
