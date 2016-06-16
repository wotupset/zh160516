<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="F3.aspx.cs" Inherits="MyWeb.F3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>加入會員</h1>  
    <form id="form1" runat="server">
        <p>帳號：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>密碼：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>身份證字號：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>生日：<asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            </asp:Calendar>
        </p>
        <p>性別：<asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="公">男生</asp:ListItem>
            <asp:ListItem Value="母">女生</asp:ListItem>
            </asp:RadioButtonList></p>
        <p>學歷：<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>國中</asp:ListItem>
            <asp:ListItem>高中</asp:ListItem>
            <asp:ListItem>大專</asp:ListItem>
            <asp:ListItem>研究所</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>電子郵件：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="送出" PostBackUrl="~/F4.aspx" />
            &nbsp;<input type="reset" value="重置" /></p>
    </form>
</body>
</html>
