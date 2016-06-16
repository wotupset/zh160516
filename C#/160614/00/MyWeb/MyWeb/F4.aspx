<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="F4.aspx.cs" Inherits="MyWeb.F4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>填寫資料如下：</h1>
    <form id="form1" runat="server">    
        <p>帳號：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></p>
        <p>密碼：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></p>
        <p>身份證字號：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></p>
        <p>生日：<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></p>
        <p>性別：<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></p>
        <p>學歷：<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></p>
        <p>電子郵件：<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></p>
    </form>
</body>
</html>
