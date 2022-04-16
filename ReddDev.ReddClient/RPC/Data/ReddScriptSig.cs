using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReddDev.ReddClient.RPC.Data {
  
  public class ReddScriptSig {
    
    [JsonProperty(PropertyName = "Asm")]
    public string Asm { get; set; }

    [JsonProperty(PropertyName = "Hex")]
    public string Hex { get; set; }
  }

}
