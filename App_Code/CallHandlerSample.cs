using Sipek.Common;
using Sipek.Common.CallControl;
using Sipek.Sip;

public class CallHandlerSample
{
  private int call;

  public delegate void StateChanged(string state);

  public event StateChanged OnAccountStateChanged;
  public event StateChanged OnCallStateChanged;

  CCallManager CallManager
  {
    get { return CCallManager.Instance; }
  }

  protected CallHandlerSample()
  {
    CallManager.CallStateRefresh += new DCallStateRefresh(CallStateRefresh);
    pjsipRegistrar.Instance.AccountStateChanged += new DAccountStateChanged(AccountStateChanged);
    CallManager.StackProxy = pjsipStackProxy.Instance;
  }

  private void AccountStateChanged(int accountId, int accState)
  {
    OnAccountStateChanged(accState.ToString());
  }

  private void CallStateRefresh(int sessionId)
  {
    OnCallStateChanged(CallManager[sessionId].StateId.ToString());
  }

  private sealed class CallHandlerSampleCreator
  {
    private static readonly CallHandlerSample instance = new CallHandlerSample();
    public static CallHandlerSample Instance
    {
      get { return instance; }
    }
  }
  public static CallHandlerSample CallHandler
  {
    get { return CallHandlerSampleCreator.Instance; }
  }

  /// <summary>
  /// Calls the specified username.
  /// </summary>
  /// <param name="username">The username.</param>
  /// <param name="password">The password.</param>
  /// <param name="server">The server.</param>
  /// <param name="port">The port.</param>
  /// <param name="dialedNumber">The dialed number.</param>
  public void Call(string username, string password, string server, int port, string dialedNumber)
  {
    var Config = new SIPConfig(new SIPAccount(username, password, server), port);
    CallManager.Config = Config;
    pjsipStackProxy.Instance.Config = Config;
    pjsipRegistrar.Instance.Config = Config;

    CallManager.Initialize(pjsipStackProxy.Instance);
    pjsipRegistrar.Instance.registerAccounts();

    call = CallManager.CreateSimpleOutboundCall(dialedNumber);
  }

  public void Release()
  {
    CallManager.OnUserRelease(call);
  }

}
