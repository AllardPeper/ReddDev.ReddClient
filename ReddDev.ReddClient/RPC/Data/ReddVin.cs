using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReddDev.ReddClient.RPC.Data {
  
  public class ReddVin {
    
    [JsonProperty(PropertyName = "TxId")]
    public string TxId { get; set; }

    [JsonProperty(PropertyName = "Vout")]
    public string Vout { get; set; }

    [JsonProperty(PropertyName = "ScriptSig")]
    public ReddScriptSig ScriptSig { get; set; }

    [JsonProperty(PropertyName = "CoinBase")]
    public string CoinBase { get; set; }

    [JsonProperty(PropertyName = "Sequence")]
    public string Sequence { get; set; }
  }
}
