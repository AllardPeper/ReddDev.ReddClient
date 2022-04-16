using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReddDev.ReddClient.RPC.Data {
  
  public class ReddBlockTransaction {

    [JsonProperty(PropertyName = "Hex")]
    public String Hex { get; set; }

    [JsonProperty(PropertyName = "Version")]
    public Int64 Version { get; set; }

    [JsonProperty(PropertyName = "LockTime")]
    public UInt32 LockTime { get; set; }

    [JsonProperty(PropertyName = "Vin")]
    public List<ReddVin> Vin { get; set; }

    [JsonProperty(PropertyName = "Vout")]
    public List<ReddVout> Vout { get; set; }

    [JsonProperty(PropertyName = "TxId")]
    public String TxId { get; set; }

    [JsonProperty(PropertyName = "Size")]
    public Int32 Size { get; set; }

    [JsonProperty(PropertyName = "VSize")]
    public Int32 VSize { get; set; }
    
    [JsonProperty(PropertyName = "Weight")]
    public Int32 Weight { get; set; }

  }
}
