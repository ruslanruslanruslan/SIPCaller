using Sipek.Common;
/// <summary>
/// Summary description for SIPAccount
/// </summary>
internal class SIPAccount : IAccount
{
  private string accountName = string.Empty;
  private string displayName = string.Empty;
  private string domainName = string.Empty;
  private bool enabled = true;
  private string hostName = string.Empty;
  private string id = string.Empty;
  private int index = 0;
  private string password = string.Empty;
  private string proxyAddress = string.Empty;
  private int regState = 0;
  private ETransportMode transportMode = ETransportMode.TM_UDP;
  private string userName = string.Empty;

  public SIPAccount(string username, string password, string server)
  {
    accountName = username;
    displayName = username;
    userName = username;
    id = username;
    this.password = password;
    hostName = server;
  }

  public string AccountName
  {
    get { return accountName; }
    set { accountName = value; }
  }
  public string DisplayName
  {
    get { return displayName; }
    set { displayName = value; }
  }
  public string DomainName
  {
    get { return domainName; }
    set { domainName = value; }
  }
  public bool Enabled
  {
    get { return enabled; }
    set { enabled = value; }
  }
  public string HostName
  {
    get { return hostName; }
    set { hostName = value; }
  }
  public string Id
  {
    get { return id; }
    set { id = value; }
  }
  public int Index
  {
    get { return index; }
    set { index = value; }
  }
  public string Password
  {
    get { return password; }
    set { password = value; }
  }
  public string ProxyAddress
  {
    get { return proxyAddress; }
    set { proxyAddress = value; }
  }
  public int RegState
  {
    get { return regState; }
    set { regState = value; }
  }
  public ETransportMode TransportMode
  {
    get { return transportMode; }
    set { transportMode = value; }
  }
  public string UserName
  {
    get { return userName; }
    set { userName = value; }
  }
}
