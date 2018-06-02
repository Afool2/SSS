<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginAndSignup.aspx.cs" Inherits="LoginAndSignup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
        用户名: <asp:TextBox ID="UserName" runat="server"></asp:TextBox><br/>
          密码: <asp:TextBox ID="Password" runat="server"></asp:TextBox><br/>
        <asp:Button ID="LogIn" runat="server" Text="登录" OnClick="LogIn_Click" />
        <asp:Button ID="Signup" runat="server" Text="注册" OnClick="Signup_Click" />
    </div>
    </form>
</body>
</html>
