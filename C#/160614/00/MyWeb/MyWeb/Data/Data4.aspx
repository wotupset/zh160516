<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data4.aspx.cs" Inherits="MyWeb.Data.Data4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="產品編號" DataSourceID="SqlDataSource1" GridLines="Both" Height="250px" Width="300px">
            <EditItemTemplate>
                產品編號:
                <asp:Label ID="產品編號Label1" runat="server" Text='<%# Eval("產品編號") %>' />
                <br />
                產品:
                <asp:TextBox ID="產品TextBox" runat="server" Text='<%# Bind("產品") %>' />
                <br />
                供應商編號:
                <asp:TextBox ID="供應商編號TextBox" runat="server" Text='<%# Bind("供應商編號") %>' />
                <br />
                類別編號:
                <asp:TextBox ID="類別編號TextBox" runat="server" Text='<%# Bind("類別編號") %>' />
                <br />
                單位數量:
                <asp:TextBox ID="單位數量TextBox" runat="server" Text='<%# Bind("單位數量") %>' />
                <br />
                單價:
                <asp:TextBox ID="單價TextBox" runat="server" Text='<%# Bind("單價") %>' />
                <br />
                庫存量:
                <asp:TextBox ID="庫存量TextBox" runat="server" Text='<%# Bind("庫存量") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="更新" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
            </EditItemTemplate>
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <InsertItemTemplate>
                產品編號:
                <asp:TextBox ID="產品編號TextBox" runat="server" Text='<%# Bind("產品編號") %>' />
                <br />
                產品:
                <asp:TextBox ID="產品TextBox" runat="server" Text='<%# Bind("產品") %>' />
                <br />
                供應商編號:
                <asp:TextBox ID="供應商編號TextBox" runat="server" Text='<%# Bind("供應商編號") %>' />
                <br />
                類別編號:
                <asp:TextBox ID="類別編號TextBox" runat="server" Text='<%# Bind("類別編號") %>' />
                <br />
                單位數量:
                <asp:TextBox ID="單位數量TextBox" runat="server" Text='<%# Bind("單位數量") %>' />
                <br />
                單價:
                <asp:TextBox ID="單價TextBox" runat="server" Text='<%# Bind("單價") %>' />
                <br />
                庫存量:
                <asp:TextBox ID="庫存量TextBox" runat="server" Text='<%# Bind("庫存量") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="插入" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
            </InsertItemTemplate>
            <ItemTemplate>
                <h2>產品：<asp:Label ID="產品Label" runat="server" Text='<%# Bind("產品") %>' /></h2>                
                <p>產品編號：<asp:Label ID="產品編號Label" runat="server" Text='<%# Eval("產品編號") %>' />
                &nbsp;&nbsp;&nbsp; 供應商編號：<asp:Label ID="供應商編號Label" runat="server" Text='<%# Bind("供應商編號") %>' /></p>                
                <h3>單價：<asp:Label ID="單價Label" runat="server" Text='<%# Bind("單價") %>' /></h3>                
                <p>單位數量：<asp:Label ID="單位數量Label" runat="server" Text='<%# Bind("單位數量") %>' />
                &nbsp;&nbsp; 庫存量：<asp:Label ID="庫存量Label" runat="server" Text='<%# Bind("庫存量") %>' /></p>
                <p style="text-align:right">類別編號：<asp:Label ID="類別編號Label" runat="server" Text='<%# Bind("類別編號") %>' /></p>                
            </ItemTemplate>
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        </asp:FormView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=localhost;Initial Catalog=中文北風;User ID=SQLUser;Password=1234" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [產品編號], [產品], [供應商編號], [類別編號], [單位數量], [單價], [庫存量] FROM [產品資料]"></asp:SqlDataSource>
    </form>
</body>
</html>
