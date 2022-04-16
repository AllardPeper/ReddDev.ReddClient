// See https://aka.ms/new-console-template for more information

using ReddDev.ReddClient.RPC;
using ReddDev.ReddClient.RPC.Responses;

Console.WriteLine("Hello, World!");


ReddSettings settings = new ReddSettings();
settings.RpcRequestTimeoutInSeconds = 60;
settings.DaemonUrl = "http://localhost:55443";
settings.DaemonUrl_Testnet = "http://localhost:55443";
settings.WalletPassword = "password";
settings.RpcUsername = "Ace";
settings.RpcPassword = "NDY1OTc1NzMzMzYyMjI5MjU4.W0PDuA.abJoVmnoZvUqkFZygO4bOyM5Tc4";

using (ReddClient client = new ReddClient(settings)) {
  String blockHash = client.GetBestBlockHash();

  //ReddBlock reddBlock = client.GetBlock(blockHash);
  //reddBlock = client.GetBlock(blockHash, false);
  ReddBlock reddBlock = client.GetBlock(blockHash, true);

  ReddBlockTransactions reddBlockTransactions = client.GetBlockTransactions(blockHash);

}
