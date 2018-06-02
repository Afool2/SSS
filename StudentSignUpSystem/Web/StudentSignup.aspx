<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentSignup.aspx.cs" Inherits="StudentSignup" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        欢迎 [ <%=Session["username"] %> ], 请填写您的报名信息 <br/>
        姓名： <asp:TextBox ID="StudentName" runat="server"></asp:TextBox><br/>
        身份证号：<asp:TextBox ID="IDCardNumber" runat="server"></asp:TextBox><br/>
        性别： <asp:DropDownList runat="server" ID="Gender"> 
                <asp:ListItem Text="男" Value="0"></asp:ListItem>
                <asp:ListItem Text="女" Value="1"></asp:ListItem>
            </asp:DropDownList>
        生日: <input type="date" runat="server"/><br/>
        学历: <asp:DropDownList runat="server" ID="EducationalBackground"> 
                <asp:ListItem Text="初中" Value="初中"></asp:ListItem>
                <asp:ListItem Text="高中" Value="高中"></asp:ListItem>
                <asp:ListItem Text="中专" Value="中专"></asp:ListItem>
                <asp:ListItem Text="中技" Value="中技"></asp:ListItem>
                <asp:ListItem Text="中职" Value="中职"></asp:ListItem>
                
            </asp:DropDownList>
        报读专业：<asp:DropDownList runat="server" ID="SignupMajor"> 
                <asp:ListItem Text="计算机网络应用" Value="计算机网络应用"></asp:ListItem>
                <asp:ListItem Text="汽车维修" Value="汽车维修"></asp:ListItem>
                <asp:ListItem Text="电子商务" Value="电子商务"></asp:ListItem>
                <asp:ListItem Text="电子技术应用" Value="电子技术应用"></asp:ListItem>
                <asp:ListItem Text="多媒体制作" Value="多媒体制作"></asp:ListItem>
                <asp:ListItem Text="数控加工" Value="数控加工"></asp:ListItem>
            </asp:DropDownList>
        
    </div>
    </form>
</body>
</html>
