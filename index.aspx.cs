using System;
using System.Web;

using System.Web.Services;
using Ozeki.Media.MediaHandlers;
using Ozeki.VoIP;
using Ozeki.VoIP.SDK;



//namespace CSASPNETMessageBox
//{
public partial class index : System.Web.UI.Page
{

  private static CallHandlerSample _callHandlerSample;

	protected void AddLog(string text)
	{
		MessageBox messageBox = new MessageBox();
		messageBox.MessageText = text;
		PopupBox.Text = messageBox.Show(this);
	}

	protected void btnStartCall_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(tbSIPServer.Text) && !string.IsNullOrEmpty(tbUserName.Text) && !string.IsNullOrEmpty(tbSourceCallerID.Text) && //tbSourceCallerID - необязательный параметр!
			!string.IsNullOrEmpty(tbUserPassword.Text) && !string.IsNullOrEmpty(tbTargetCallerID.Text))
		{
			try
			{
				_callHandlerSample = new CallHandlerSample(tbSourceCallerID.Text, tbUserName.Text, tbUserPassword.Text, tbSIPServer.Text);
				_callHandlerSample.Call(tbTargetCallerID.Text);
			}
			catch (Exception ex)
			{
				AddLog(ex.Message); //как подтянуть ексепшены вызываемых процедур?
			}
		}
		else
		{
			AddLog("type all data");
		}
		AddLog("call finished");
	}

}