﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="F5.aspx.cs" Inherits="MyWeb.F5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>Application的值：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
    </p>
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    <p>&nbsp;</p>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </form>
</body>
</html>
