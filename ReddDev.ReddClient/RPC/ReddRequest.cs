// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
using Newtonsoft.Json;

namespace ReddDev.ReddClient.RPC {

  internal class ReddRequest {

    public ReddRequest () {
    }

    public ReddRequest (Int32 id, ReddMethods method, Object[] parameters) {
      Method = method.ToString().ToLowerInvariant();
      Parameters = parameters;
      Id = id;
    }

    [JsonProperty(PropertyName = "method", Order = 0)]
    public String Method { get; set; }

    [JsonProperty(PropertyName = "params", Order = 1)]
    public IList<Object> Parameters { get; set; }

    [JsonProperty(PropertyName = "id", Order = 2)]
    public int Id { get; set; }

  }
}
