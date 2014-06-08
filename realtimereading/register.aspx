<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="realtimereading.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtFirstName" runat="server" placeholder="First name"></asp:TextBox><br />
        <asp:TextBox ID="txtLastName" runat="server" placeholder="Last name"></asp:TextBox><br />
        <asp:TextBox ID="txtEmail" runat="server" placeholder="Email address"></asp:TextBox><br />
        <asp:TextBox ID="txtUsername" runat="server" placeholder="Username"></asp:TextBox><br />
        <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox><br />
        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
    </div>
    </form>
</body>
</html>
