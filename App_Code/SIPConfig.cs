using System;
using System.Collections.Generic;
using Sipek.Common;
/// <summary>
/// Summary description for SIPConfig
/// </summary>
internal class SIPConfig : IConfiguratorInterface
{
  private List<IAccount> accounts = new List<IAccount>();
  private bool aaFlag = false;
  private bool cfbFlag = false;
  private bool cfnrFlag = false;
  private bool cfufFlag = false;
  private bool dndFlag = false;
  private string cfbNumber = string.Empty;
  private string cfnrNumber = string.Empty;
  private string cfuNumber = string.Empty;
  private bool publishEnabled = false;
  private int sipPort = 5060;
  private List<string> codecList = new List<string>();
  
  internal SIPConfig(SIPAccount account, int port)
  {
    sipPort = port;
    accounts.Add(account);
    codecList.Add("PCMA");
  }

  public bool AAFlag
  {
    get { return aaFlag; }
    set { aaFlag = value; }
  }
  public List<IAccount> Accounts
  {
    get { return accounts; }
  }
  public bool CFBFlag
  {
    get { return cfbFlag; }
    set { cfbFlag = value; }
  }
  public string CFBNumber
  {
    get { return cfbNumber; }
    set { cfbNumber = value; }
  }
  public bool CFNRFlag
  {
    get { return cfnrFlag; }
    set { cfnrFlag = value; }
  }
  public string CFNRNumber
  {
    get { return cfnrNumber; }
    set { cfnrNumber = value; }
  }
  public bool CFUFlag
  {
    get { return cfufFlag; }
    set { cfufFlag = value; }
  }
  public string CFUNumber
  {
    get { return cfuNumber; }
    set { cfuNumber = value; }
  }
  public List<string> CodecList
  {
    get { return codecList; }
    set { codecList = value; }
  }
  public int DefaultAccountIndex
  {
    get { return 0; }
  }
  public bool DNDFlag
  {
    get { return dndFlag; }
    set { dndFlag = value; }
  }
  public bool IsNull
  {
    get { return false; }
  }
  public bool PublishEnabled
  {
    get { return publishEnabled; }
    set { publishEnabled = value; }
  }
  public int SIPPort
  {
    get { return sipPort; }
    set { sipPort = value; }
  }
  public void Save()
  {
    throw new NotImplementedException();
  }
}
