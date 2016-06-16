<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data2.aspx.cs" Inherits="MyWeb.Data.Data2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>資料頁面2</h1>
    <form id="form1" runat="server">
    <p>請選擇職稱：<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="職稱" DataValueField="職稱" AutoPostBack="True"></asp:DropDownList>
        &nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=localhost;Initial Catalog=中文北風;User ID=SQLUser;Password=1234" ProviderName="System.Data.SqlClient" SelectCommand="SELECT DISTINCT [職稱] FROM [員工]"></asp:SqlDataSource>
        </p>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="800px" AutoGenerateColumns="False" DataKeyNames="員工編號" DataSourceID="SqlDataSource2">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="員工編號" HeaderText="員工編號" ReadOnly="True" SortExpression="員工編號" />
                <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                <asp:BoundField DataField="職稱" HeaderText="職稱" SortExpression="職稱" />
                <asp:BoundField DataField="稱呼" HeaderText="稱呼" SortExpression="稱呼" />
                <asp:BoundField DataField="薪資" HeaderText="薪資" SortExpression="薪資" />
                <asp:BoundField DataField="雇用日期" HeaderText="雇用日期" SortExpression="雇用日期" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=localhost;Initial Catalog=中文北風;User ID=SQLUser;Password=1234" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [員工編號], [姓名], [職稱], [稱呼], [薪資], [雇用日期] FROM [員工] WHERE ([職稱] = @職稱)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="職稱" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
