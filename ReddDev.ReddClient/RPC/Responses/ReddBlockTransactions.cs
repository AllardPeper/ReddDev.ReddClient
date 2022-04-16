using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ReddDev.ReddClient.RPC.Data;

namespace ReddDev.ReddClient.RPC.Responses {

  /// <summary>
  /// returns an Object with information about block <hash>.
  /// </summary>
  public class ReddBlockTransactions :ReddBlockBase {

    [JsonProperty(PropertyName = "tx")]
    public List<ReddBlockTransaction> Tx { get; set; }

  }
}
