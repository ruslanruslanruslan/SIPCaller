<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<%@ Register src="WebUserControl.ascx" tagname="WebUserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Sample SIP Application</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <table>
        <tr>
          <td>
            <asp:Literal ID="lSIPServer" runat="server" Text="SIP Server:"></asp:Literal>
          </td>
          <td>
            <asp:TextBox ID="tbSIPServer" runat="server"></asp:TextBox>
          </td>
        </tr>
        <tr>
          <td>
            <asp:Literal ID="lUserName" runat="server" Text="User name:"></asp:Literal>
          </td>
          <td>
            <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
          </td>
        </tr>
        <tr>
          <td>
            <asp:Literal ID="lUserPassword" runat="server" Text="User password:"></asp:Literal>
          </td>
          <td>
            <asp:TextBox ID="tbUserPassword" TextMode="Password" runat="server"></asp:TextBox>
          </td>
        </tr>
        <tr>
          <td>
            <asp:Literal ID="lSourceCallerID" runat="server" Text="Operator's telephone number:"></asp:Literal>
          </td>
          <td>
            <asp:TextBox ID="tbSourceCallerID" runat="server"></asp:TextBox>
          </td>
        </tr>
        <tr>
          <td>
            <asp:Literal ID="lTargetCallerID" runat="server" Text="Customer's telephone number:"></asp:Literal>
          </td>
          <td>
            <asp:TextBox ID="tbTargetCallerID" runat="server"></asp:TextBox>
          </td>
        </tr>
        <tr>
          <td><uc1:WebUserControl ID="WebUserControl1" runat="server" />
            <asp:Button ID="btnStartCall" runat="server" OnClick="btnStartCall_Click" Text="Submit" />
          </td>
        </tr>
      </table>
        <asp:Literal ID="PopupBox" runat="server"></asp:Literal>
    </div>
  </form>
</body>
</html>
