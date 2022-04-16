using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
