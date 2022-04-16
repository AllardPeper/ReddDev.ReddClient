using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReddDev.ReddClient.RPC.Data {
  
  public class ReddScriptPubKey {

    [JsonProperty(PropertyName = "Asm")]
    public String Asm { get; set; }
    
    [JsonProperty(PropertyName = "Hex")]
    public String Hex { get; set; }

    [JsonProperty(PropertyName = "ReqSigs")]
    public Int32 ReqSigs { get; set; }

    [JsonProperty(PropertyName = "Type")]
    public String Type { get; set; }

    [JsonProperty(PropertyName = "Addresses")]
    public List<String> Addresses { get; set; }
  }
}
