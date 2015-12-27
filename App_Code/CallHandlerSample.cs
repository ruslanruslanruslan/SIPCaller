using System;
using System.Net;

using SIPSorcery.SIP;
using SIPSorcery.SIP.App;


public class CallHandlerSample
{
  /// <summary>
  /// Calls the specified username.
  /// </summary>
  /// <param name="username">The username.</param>
  /// <param name="password">The password.</param>
  /// <param name="server">The server.</param>
  /// <param name="port">The port.</param>
  /// <param name="dialedNumber">The dialed number.</param>
  public static void Call(string username, string password, string server, int port, string dialedNumber)
	{
		if (string.IsNullOrEmpty(dialedNumber))
			return;

    try
    {
      // Set up the SIP transport infrastructure.
      var sipTransport = new SIPTransport(SIPDNSManager.ResolveSIPService, new SIPTransactionEngine());
      var udpChannel = new SIPUDPChannel(new IPEndPoint(IPAddress.Any, 5060));
      sipTransport.AddSIPChannel(udpChannel);

      // Create a SIP user agent client that can be used to initiate calls to external SIP devices and place a call.
      var uac = new SIPClientUserAgent(sipTransport, null, null, null, null);
      var uri = /*"sip:" + */username + "@" + server + ":" + port;
      var from = /*"<sip:" + */username + "@" + server/* + ">"*/;
      var to = /*"<sip:" + */dialedNumber/* + ">"*/;
      var callDescriptor = new SIPCallDescriptor(username, password, uri, from, to, null, null, null, 
        SIPCallDirection.Out, "application/sdp", null, null);
      uac.Call(callDescriptor);

      sipTransport.Shutdown();
    }
    catch (Exception ex)
    {
      Console.WriteLine("Exception Main. " + ex);
    }
  }
}
