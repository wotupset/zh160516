<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data3.aspx.cs" Inherits="MyWeb.Data.Data3" %>

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
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="產品編號" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None" Height="300px" Width="350px">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <EditRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <Fields>
                <asp:BoundField DataField="產品編號" HeaderText="產品編號" ReadOnly="True" SortExpression="產品編號" />
                <asp:BoundField DataField="產品" HeaderText="產品" SortExpression="產品" />
                <asp:BoundField DataField="供應商編號" HeaderText="供應商編號" SortExpression="供應商編號" />
                <asp:BoundField DataField="類別編號" HeaderText="類別編號" SortExpression="類別編號" />
                <asp:BoundField DataField="單位數量" HeaderText="單位數量" SortExpression="單位數量" />
                <asp:BoundField DataField="單價" HeaderText="單價" SortExpression="單價" />
                <asp:BoundField DataField="庫存量" HeaderText="庫存量" SortExpression="庫存量" />
            </Fields>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=localhost;Initial Catalog=中文北風;User ID=SQLUser;Password=1234" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [產品編號], [產品], [供應商編號], [類別編號], [單位數量], [單價], [庫存量] FROM [產品資料]"></asp:SqlDataSource>
    </form>
</body>
</html>
