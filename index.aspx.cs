using System;


//namespace CSASPNETMessageBox
//{
public partial class index : System.Web.UI.Page
{

  protected void Page_Load(object sender, EventArgs e)
  {
    if (Request.Cookies["sipServerName"] != null)
      tbSIPServer.Text = Server.HtmlEncode(Request.Cookies["sipServerName"].Value);
    if (Request.Cookies["sipUserName"] != null)
      tbUserName.Text = Server.HtmlEncode(Request.Cookies["sipUserName"].Value);
    //if (Request.Cookies["sipUserPassword"] != null)
    //	tbUserPassword.Text = Server.HtmlEncode(Request.Cookies["sipUserPassword"].Value);
    if (Request.Cookies["sipSourceCallerID"] != null)
      tbSourceCallerID.Text = Server.HtmlEncode(Request.Cookies["sipSourceCallerID"].Value);
    if (Request.Cookies["sipTargetCallerID"] != null)
      tbTargetCallerID.Text = Server.HtmlEncode(Request.Cookies["sipTargetCallerID"].Value);
  }

  protected void AddLog(string text)
  {
    MessageBox messageBox = new MessageBox();
    messageBox.MessageText = text;
    PopupBox.Text = messageBox.Show(this);
  }

  protected void btnStartCall_Click(object sender, EventArgs e)
  {
    Response.Cookies["sipServerName"].Value = tbSIPServer.Text;
    Response.Cookies["sipUserName"].Value = tbUserName.Text;
    //Response.Cookies["sipUserPassword"].Value = tbUserPassword.Text;
    Response.Cookies["sipSourceCallerID"].Value = tbSourceCallerID.Text;
    Response.Cookies["sipTargetCallerID"].Value = tbTargetCallerID.Text;

    if (!string.IsNullOrEmpty(tbSIPServer.Text) && !string.IsNullOrEmpty(tbUserName.Text) && !string.IsNullOrEmpty(tbSourceCallerID.Text) && //tbSourceCallerID - необязательный параметр!
      !string.IsNullOrEmpty(tbUserPassword.Text) && !string.IsNullOrEmpty(tbTargetCallerID.Text))
      CallHandlerSample.Call(tbUserName.Text, tbUserPassword.Text, tbSIPServer.Text, 5060, tbTargetCallerID.Text);
    else
      AddLog("type all data");
    AddLog("call finished");
  }

}