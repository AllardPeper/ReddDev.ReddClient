// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
using ReddDev.ReddClient.RPC;
using ReddDev.ReddClient.RPC.Responses;

Console.WriteLine("Hello, World!");

ReddSettings settings = new ReddSettings();
settings.RpcRequestTimeoutInSeconds = 60;
settings.DaemonUrl = "http://192.168.1.201:55443";
settings.DaemonUrl_Testnet = "http://192.168.1.201:55443";
settings.WalletPassword = "password";
settings.RpcUsername = "Ace";
settings.RpcPassword = "password";

using (ReddClient client = new ReddClient(settings)) {

  String blockHash = "0e61c7c6d2a816a48c131fc8d7f7dd31a507d0d2335d99680ef3d075f01079c5";
  String blockHash2 = "4deae5afe5b5e57a96d7e9aae563fedcf67065af5cc5e86db04d05c6a86a134f";
  //ReddBlockTransactions reddBlockTransactions;

  // getbestblockhash works, returned hash presumed to be the best
  //blockHash = client.GetBestBlockHash();

  // getblock verbosity = 0, looks correct
  //String reddBlockString = client.GetBlockHexString("0e61c7c6d2a816a48c131fc8d7f7dd31a507d0d2335d99680ef3d075f01079c5");


  //blockHash = "0e61c7c6d2a816a48c131fc8d7f7dd31a507d0d2335d99680ef3d075f01079c5";
  // getblock verbosity = 1, Looks good
  //ReddBlock reddBlock = client.GetBlock(blockHash); // GetBlock verbosity = 1
  //if (String.Compare(reddBlock.Hash, blockHash) != 0) {
  //  Console.WriteLine("Error");
  //}

  // getblock verbosity = 1, Internal error for some hashes
  // TODO: Not working, internal error
  //reddBlockTransactions = client.GetBlockTransactions(blockHash); // GetBlock verbosity = 2
  //if (String.Compare(reddBlockTransactions.Hash, blockHash) != 0) {
  //  Console.WriteLine("Error");
  //}

  // Works!
  //reddBlockTransactions = client.GetBlockTransactions(blockHash2); // GetBlock verbosity = 2
  //if (String.Compare(reddBlockTransactions.Hash, blockHash2) != 0) {
  //  Console.WriteLine("Error");
  //}



  // Looks good
  //ReddBlockchainInfo blockchainInfo = client.GetBlockchainInfo();

  // Looks good
  //UInt32 blockCount = client.GetBlockCount();

  // TODO: Not working "Index is not enabled for filtertype basic"
  //ReddContentFilter filter = client.GetBlockFilter("0e61c7c6d2a816a48c131fc8d7f7dd31a507d0d2335d99680ef3d075f01079c5");

  //String blockHash2 = client.GetBlockHash(reddBlock.Height);
  //if (String.Compare("0e61c7c6d2a816a48c131fc8d7f7dd31a507d0d2335d99680ef3d075f01079c5", blockHash2) != 0) {
  //  Console.WriteLine("Error hash does not match!");
  //}

  // Looks good
  //String hexString = client.GetBlockHeaderHexString("0e61c7c6d2a816a48c131fc8d7f7dd31a507d0d2335d99680ef3d075f01079c5");

  // Looks good
  //ReddBlockHeader blockHeader = client.GetBlockHeader("0e61c7c6d2a816a48c131fc8d7f7dd31a507d0d2335d99680ef3d075f01079c5");

  // TODO: Not working for some values, internal error
  //ReddGetBlockStats blockStats = client.GetBlockStats("0e61c7c6d2a816a48c131fc8d7f7dd31a507d0d2335d99680ef3d075f01079c5");
  //ReddGetBlockStats blockStats = client.GetBlockStats(117038);
  //ReddGetBlockStats blockStats = client.GetBlockStats("4deae5afe5b5e57a96d7e9aae563fedcf67065af5cc5e86db04d05c6a86a134f");
  //ReddGetBlockStats blockStats = client.GetBlockStats(1000);

  //List<ReddChainTips> chainTips = client.GetChainTips();

  // Looks good
  //ReddChainTxStats chainTxStats = client.GetChainTxStats();
  //chainTxStats = client.GetChainTxStats(1);
  //chainTxStats = client.GetChainTxStats("4deae5afe5b5e57a96d7e9aae563fedcf67065af5cc5e86db04d05c6a86a134f");
  //chainTxStats = client.GetChainTxStats(1, "4deae5afe5b5e57a96d7e9aae563fedcf67065af5cc5e86db04d05c6a86a134f");

  // Looks good
  //Double difficulty = client.GetDifficulty();

  //List<String> ancestorsIds = client.GetMempoolAncestorIds("21f385cfd0a3e0ccda9f41f9b8f1a1ae0547b9311ba4f068adaa0bd2dc6eb30c");
  //Dictionary<String, ReddMempoolEntry> ancestors = client.GetMempoolAncestors("21f385cfd0a3e0ccda9f41f9b8f1a1ae0547b9311ba4f068adaa0bd2dc6eb30c");



  //ReddMempoolInfo info = client.GetMempoolInfo();

  //List<String> memPoolTransactions = client.GetMempoolTransactionList();
  //ReddMempoolTransactions mempool = client.GetMempoolTransactions();
  //Dictionary<String,ReddMempoolEntry> memPoolEntries = client.GetMempoolEntries();

  //var result = client.GetTxOut("dab58ba7af304ec0e298544da4d1b9611b2f4bad98b9e30ebec9f35282036c4c", 2);

  //List<String> transactions = new List<String>();
  //transactions.Add("8f58e264c303b0adc32e56dca35a417c55664acf3b7e125fe7c6bfe1c0289ce1");
  //transactions.Add("de5e081b6ff1fef3951d6a51ff081ca94755b90ed578154b1f38c2406f13d9cb");
  //050000004bf3ce291c3bdfb3349d68df06b2c942ce83fa00f6afec8922dbbfc8932da027b5a34b6bc151e91e5815cd20a9a33c7f5500a8e770afa47d26f0c367d207a4911dad7f6239aa791c000000000200000002e19c28c0e1bfc6e75f127e3bcf4a66557c415aa3dc562ec3adb003c364e2588fcbd9136f40c2381f4b1578d50eb95547a91c08ff516a1d95f3fef16f1b085ede0105
  //050000004bf3ce291c3bdfb3349d68df06b2c942ce83fa00f6afec8922dbbfc8932da027b5a34b6bc151e91e5815cd20a9a33c7f5500a8e770afa47d26f0c367d207a4911dad7f6239aa791c000000000200000002e19c28c0e1bfc6e75f127e3bcf4a66557c415aa3dc562ec3adb003c364e2588fcbd9136f40c2381f4b1578d50eb95547a91c08ff516a1d95f3fef16f1b085ede0103
  //050000004bf3ce291c3bdfb3349d68df06b2c942ce83fa00f6afec8922dbbfc8932da027b5a34b6bc151e91e5815cd20a9a33c7f5500a8e770afa47d26f0c367d207a4911dad7f6239aa791c000000000200000002e19c28c0e1bfc6e75f127e3bcf4a66557c415aa3dc562ec3adb003c364e2588fcbd9136f40c2381f4b1578d50eb95547a91c08ff516a1d95f3fef16f1b085ede0107
  //var result = client.GetTxoutProof(transactions);
  //if (result != "050000004bf3ce291c3bdfb3349d68df06b2c942ce83fa00f6afec8922dbbfc8932da027b5a34b6bc151e91e5815cd20a9a33c7f5500a8e770afa47d26f0c367d207a4911dad7f6239aa791c000000000200000002e19c28c0e1bfc6e75f127e3bcf4a66557c415aa3dc562ec3adb003c364e2588fcbd9136f40c2381f4b1578d50eb95547a91c08ff516a1d95f3fef16f1b085ede0107") {
  //}


  //var result = client.GetTxOutSetInfoOut(ReddHashType.MuHash, "670ec98cea5cc93b5caac7e51ba4464efb5fd030f86ca9905f3f8639439d0aba");
  var result = client.GetTxOutSetInfo(ReddHashType.MuHash);

  //var block = client.GetBlock(result.BestBlock);

}
