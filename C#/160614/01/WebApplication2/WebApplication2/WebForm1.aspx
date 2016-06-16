<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h2>您是第&nbsp;<asp:Literal ID="Literal1" runat="server"></asp:Literal>&nbsp;位光臨本站的訪客</h2>
    <p>上一次光臨本站的時間：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></p>
    <p>Session的值：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></p>
    <p>Application的值：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></p>
    </form>
</body>
</html>
