// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
namespace ReddDev.ReddClient.RPC {

  /// <summary>
  /// ReddCoin wallet Rawtransactions RPC methods
  /// </summary>
  public partial class ReddClient {

    //== Rawtransactions ==
    //analyzepsbt "psbt"
    //combinepsbt["psbt", ...]
    //combinerawtransaction["hexstring", ...]
    //converttopsbt "hexstring" (permitsigdata iswitness )
    //createpsbt[{"txid":"hex", "vout":n, "sequence":n},...] [{"address":amount,...},{ "data":"hex"},...] (locktime replaceable )
    //createrawtransaction[{ "txid":"hex","vout":n,"sequence":n},...] [{"address":amount,...},{ "data":"hex"},...] (locktime replaceable )
    //decodepsbt "psbt"
    //decoderawtransaction "hexstring"(iswitness)
    //decodescript "hexstring"
    //finalizepsbt "psbt"(extract)
    //fundrawtransaction "hexstring"(options iswitness)
    //getrawtransaction "txid"(verbose "blockhash")
    //joinpsbts["psbt", ...]
    //sendrawtransaction "hexstring"(maxfeerate)
    //signrawtransactionwithkey "hexstring"["privatekey", ...]( [{ "txid":"hex","vout":n,"scriptPubKey":"hex","redeemScript":"hex","witnessScript":"hex","amount":amount},...] "sighashtype" )
    //testmempoolaccept["rawtx", ...](maxfeerate)
    //utxoupdatepsbt "psbt"( ["",{ "desc":"str","range":n or[n, n]},...] )

  }

}
