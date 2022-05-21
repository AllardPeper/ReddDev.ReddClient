// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using ReddDev.ReddClient.RPC.Responses;

namespace ReddDev.ReddClient.RPC {

  /// <summary>
  /// ReddClient for communicating with the ReddWallet RPC deamon
  /// </summary>
  public partial class ReddClient :IDisposable {

    private HttpClient m_Client;
    private Boolean m_DisposedValue;
    private ReddSettings m_Settings;
    private String m_RPCUrl;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="settings">Settings for connecting</param>
    /// <param name="testnet">Set to true when connecting to testnet</param>
    public ReddClient (ReddSettings settings, Boolean testnet = false) {
      m_Settings = settings;
      m_Client = new HttpClient();

      String authInfo = m_Settings.RpcUsername + ":" + m_Settings.RpcPassword;
      authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
      m_Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authInfo);

      if (testnet) {
        m_RPCUrl = m_Settings.DaemonUrl_Testnet;
      } else {
        m_RPCUrl = m_Settings.DaemonUrl;
      }
    }

    /// <summary>
    /// Post a request to the ReddWallet deamon
    /// </summary>
    /// <typeparam name="TResponse">The type or the expected response</typeparam>
    /// <param name="method">Method to call from the ReddMethods enum</param>
    /// <param name="parameters">Optional parameters</param>
    /// <returns>TResponse</returns>
    private async Task<ReddResponse<TResponse>> PostAsync<TResponse> (ReddMethods method, params Object[] parameters) {
      try {
        ReddRequest request = new ReddRequest(1, method, parameters);
        String jsonRequest = JsonConvert.SerializeObject(request);
        StringContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json-rpc");
        HttpResponseMessage responseMessage = await m_Client.PostAsync(m_RPCUrl, content);
        String jsonResponse = await responseMessage.Content.ReadAsStringAsync();
        ReddResponse<TResponse> response = JsonConvert.DeserializeObject<ReddResponse<TResponse>>(jsonResponse);
        return response;
      } catch (JsonException e) {
        ReddResponse<TResponse> errorResponse = new ReddResponse<TResponse>();
        errorResponse.Error = new ReddError();
        errorResponse.Error.Message = e.Message;
        errorResponse.Error.Code = ReddErrorCodes.RPC_REDDDEV_JSON_EXCEPTION;
        return errorResponse;
      } catch (Exception e) {
        ReddResponse<TResponse> errorResponse = new ReddResponse<TResponse>();
        errorResponse.Error = new ReddError();
        errorResponse.Error.Message = e.Message;
        errorResponse.Error.Code = ReddErrorCodes.RPC_REDDDEV_CANNOT_CONNECT;
        return errorResponse;
      }
    }

    /// <summary>
    /// Protected dispose for the actual disposing of objects
    /// </summary>
    /// <param name="disposing">Disposing or finalizing</param>
    protected virtual void Dispose (Boolean disposing) {
      if (!m_DisposedValue) {
        if (disposing) {
          // TODO: dispose managed state (managed objects)
        }

        // TODO: free unmanaged resources (unmanaged objects) and override finalizer
        // TODO: set large fields to null
        m_DisposedValue = true;
      }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~RPCClient()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    /// <summary>
    /// Dispose
    /// </summary>
    public void Dispose () {
      // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
      Dispose(disposing: true);
      GC.SuppressFinalize(this);
    }
  }
}