// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
namespace ReddDev.ReddClient.RPC {

  /// <summary>
  /// ReddCoin wallet Wallet RPC methods
  /// </summary>
  public partial class ReddClient {

    //== Wallet ==
    //abandontransaction "txid"
    //abortrescan
    //addmultisigaddress nrequired ["key",...] ("label" "address_type" )
    //backupwallet "destination"
    //bumpfee "txid"(options)
    //createwallet "wallet_name"(disable_private_keys blank "passphrase" avoid_reuse descriptors load_on_startup external_signer)
    //dumpprivkey "address"
    //dumpwallet "filename"
    //encryptwallet "passphrase"
    //getaddressesbylabel "label"
    //getaddressinfo "address"
    //getbalance("dummy" minconf include_watchonly avoid_reuse)
    //getbalances
    //getnewaddress ( "label" "address_type" )
    //getrawchangeaddress("address_type")
    //getreceivedbyaddress "address"(minconf)
    //getreceivedbylabel "label"(minconf)
    //gettransaction "txid"(include_watchonly verbose)
    //getunconfirmedbalance
    //getwalletinfo
    //importaddress "address" ( "label" rescan p2sh )
    //importdescriptors "requests"
    //importmulti "requests"("options")
    //importprivkey "privkey"("label" rescan)
    //importprunedfunds "rawtransaction" "txoutproof"
    //importpubkey "pubkey"("label" rescan)
    //importwallet "filename"
    //keypoolrefill(newsize)
    //listaddressgroupings
    //listdescriptors
    //listlabels ( "purpose" )
    //listlockunspent
    //listreceivedbyaddress (minconf include_empty include_watchonly "address_filter" )
    //listreceivedbylabel(minconf include_empty include_watchonly)
    //listsinceblock("blockhash" target_confirmations include_watchonly include_removed)
    //listtransactions("label" count skip include_watchonly)
    //listunspent(minconf maxconf["address", ...] include_unsafe query_options)
    //listwalletdir
    //listwallets
    //loadwallet "filename" ( load_on_startup )
    //lockunspent unlock ([{"txid":"hex","vout":n},...] )
    //psbtbumpfee "txid"(options)
    //removeprunedfunds "txid"
    //rescanblockchain(start_height stop_height)
    //send[{ "address":amount,...},{ "data":"hex"},...] (conf_target "estimate_mode" fee_rate options )
    //sendmany "" { "address":amount,...} (minconf "comment"["address", ...] replaceable conf_target "estimate_mode" fee_rate verbose )
    //sendtoaddress "address" amount("comment" "comment_to" subtractfeefromamount replaceable conf_target "estimate_mode" avoid_reuse fee_rate verbose)
    //sethdseed(newkeypool "seed")
    //setlabel "address" "label"
    //settxfee amount
    //setwalletflag "flag" ( value )
    //signmessage "address" "message"
    //signrawtransactionwithwallet "hexstring"( [{ "txid":"hex","vout":n,"scriptPubKey":"hex","redeemScript":"hex","witnessScript":"hex","amount":amount},...] "sighashtype" )
    //unloadwallet("wallet_name" load_on_startup)
    //upgradewallet(version)
    //walletcreatefundedpsbt( [{ "txid":"hex","vout":n,"sequence":n},...] ) [{"address":amount,...},{ "data":"hex"},...] (locktime options bip32derivs )
    //walletdisplayaddress bitcoin address to display
    //walletlock
    //walletpassphrase "passphrase" timeout
    //walletpassphrasechange "oldpassphrase" "newpassphrase"
    //walletprocesspsbt "psbt" ( sign "sighashtype" bip32derivs )


  }

}
