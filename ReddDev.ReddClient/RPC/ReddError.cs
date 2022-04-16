using Newtonsoft.Json;

namespace ReddDev.ReddClient.RPC {

  public class ReddError {

    [JsonProperty(PropertyName = "code")]
    public ReddErrorCodes Code { get; set; }

    [JsonProperty(PropertyName = "message")]
    public String Message { get; set; }

  }

}
