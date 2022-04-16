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
