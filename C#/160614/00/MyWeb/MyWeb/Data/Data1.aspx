<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data1.aspx.cs" Inherits="MyWeb.Data.Data1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>資料頁面1</h1>
    <form id="form1" runat="server">
            
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="員工編號" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="800px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="員工編號" HeaderText="員工編號" ReadOnly="True" SortExpression="員工編號" />
                <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                <asp:BoundField DataField="職稱" HeaderText="職稱" SortExpression="職稱" />
                <asp:BoundField DataField="稱呼" HeaderText="稱呼" SortExpression="稱呼" />
                <asp:BoundField DataField="薪資" HeaderText="薪資" SortExpression="薪資" />
                <asp:BoundField DataField="雇用日期" HeaderText="雇用日期" SortExpression="雇用日期" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=localhost;Initial Catalog=中文北風;User ID=SQLUser;Password=1234" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [員工編號], [姓名], [職稱], [稱呼], [薪資], [雇用日期] FROM [員工]"></asp:SqlDataSource>
            
    </form>
</body>
</html>
