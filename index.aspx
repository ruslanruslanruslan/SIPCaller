<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

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
            <asp:Literal ID="Literal2" runat="server" Text="SIP Server:"></asp:Literal>
          </td>
          <td>
            <asp:TextBox ID="textBoxSIPServer" runat="server"></asp:TextBox>
          </td>
        </tr>
        <tr>
          <td>
            <asp:Literal ID="Literal1" runat="server" Text="Operator's telephone number:"></asp:Literal>
          </td>
          <td>
            <asp:TextBox ID="textBoxOperator" runat="server"></asp:TextBox>
          </td>
        </tr>
        <tr>
          <td>
            <asp:Literal ID="Literal4" runat="server" Text="Customer's telephone number:"></asp:Literal>
          </td>
          <td>
            <asp:TextBox ID="textBoxCallbackPhone" runat="server"></asp:TextBox>
          </td>
        </tr>
        <tr>
          <td>
            <asp:Button ID="ButtonStartCall" runat="server" OnClick="ButtonStartCall_Click" Text="Submit" />
          </td>
        </tr>
      </table>
    </div>
  </form>
</body>
</html>
