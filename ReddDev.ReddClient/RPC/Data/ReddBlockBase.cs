using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReddDev.ReddClient.RPC.Data {
  
  public abstract class ReddBlockBase {

    [JsonProperty(PropertyName = "hash")]
    public String Hash { get; set; }

    [JsonProperty(PropertyName = "confirmations")]
    public Int32 Confirmations { get; set; }

    [JsonProperty(PropertyName = "height")]
    public Int32 Height { get; set; }

    [JsonProperty(PropertyName = "version")]
    public Int32 Version { get; set; }

    [JsonProperty(PropertyName = "versionHex")]
    public String VersionHex { get; set; }

    [JsonProperty(PropertyName = "merkleroot")]
    public String MerkleRoot { get; set; }

    [JsonProperty(PropertyName = "time")]
    public Int32 Time { get; set; }

    [JsonProperty(PropertyName = "mediantime")]
    public Int32 MedianTime { get; set; }

    [JsonProperty(PropertyName = "Nonce")]
    public Int32 Nonce { get; set; }

    [JsonProperty(PropertyName = "bits")]
    public String Bits { get; set; }

    [JsonProperty(PropertyName = "difficulty")]
    public Double Difficulty { get; set; }

    [JsonProperty(PropertyName = "chainwork")]
    public String ChainWork { get; set; }

    [JsonProperty(PropertyName = "nTx")]
    public Int32 NTx { get; set; }

    [JsonProperty(PropertyName = "previousblockhash")]
    public String PreviousBlockHash { get; set; }

    [JsonProperty(PropertyName = "type")]
    public String Type { get; set; }

    [JsonProperty(PropertyName = "hashproof")]
    public String HashProof { get; set; }

    [JsonProperty(PropertyName = "entropybit")]
    public Int32 EntropyBit { get; set; }

    [JsonProperty(PropertyName = "modifier")]
    public String Modifier { get; set; }

    [JsonProperty(PropertyName = "blocksignature")]
    public String BlockSignature { get; set; }

    [JsonProperty(PropertyName = "strippedsize")]
    public Int32 StrippedSize { get; set; }

    [JsonProperty(PropertyName = "size")]
    public Int32 Size { get; set; }

    [JsonProperty(PropertyName = "weight")]
    public Int32 Weight { get; set; }

  }
}
