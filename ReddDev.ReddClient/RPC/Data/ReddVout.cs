using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReddDev.ReddClient.RPC.Data {
  
  public class ReddVout {

    [JsonProperty(PropertyName = "Value")]
    public decimal Value { get; set; }
    
    [JsonProperty(PropertyName = "N")]
    public int N { get; set; }
    
    [JsonProperty(PropertyName = "ScriptPubKey")]
    public ReddScriptPubKey ScriptPubKey { get; set; }
  }
}
