using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
