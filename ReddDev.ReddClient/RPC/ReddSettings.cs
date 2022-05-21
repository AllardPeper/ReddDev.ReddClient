// *******************************************************************************************************************************
// Copyright (c) 2022 Allard Peper aka Dragon Ace
// See the accompanying License.txt file or http://www.opensource.org/licenses/mit-license.php for the Software License Aggrement.
// 
// It takes time and effort to produce high standard code like this,
// consider donating RDD to Rm3QzToPurkULhKX3WxLr6CGnsicTq5CWQ to support the project
// *******************************************************************************************************************************
namespace ReddDev.ReddClient.RPC {
  
  public class ReddSettings {

    private Int32 m_RpcRequestTimeoutInSeconds;
    private String m_DaemonUrl;
    private String m_DaemonUrl_Testnet;
    private String m_WalletPassword;
    private String m_RpcUsername;
    private String m_RpcPassword;

    public Int32 RpcRequestTimeoutInSeconds { get => m_RpcRequestTimeoutInSeconds; set => m_RpcRequestTimeoutInSeconds = value; }

    public String DaemonUrl { get => m_DaemonUrl; set => m_DaemonUrl = value; }

    public String DaemonUrl_Testnet { get => m_DaemonUrl_Testnet; set => m_DaemonUrl_Testnet = value; }

    public String WalletPassword { get => m_WalletPassword; set => m_WalletPassword = value; }

    public String RpcUsername { get => m_RpcUsername; set => m_RpcUsername = value; }

    public String RpcPassword { get => m_RpcPassword; set => m_RpcPassword = value; }

  }

}
