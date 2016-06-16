<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data6.aspx.cs" Inherits="MyWeb.Data.Data6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>產品編修</h1>
    <form id="form1" runat="server">
    
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4" DataKeyNames="產品編號" DataSourceID="SqlDataSource1" DefaultMode="Edit" ForeColor="#333333" GridLines="None" Height="400px" Width="300px">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#FFFFC0" Font-Bold="True" />
            <FieldHeaderStyle BackColor="#FFFF99" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="產品編號" HeaderText="產品編號：" ReadOnly="True" SortExpression="產品編號" >
                <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="產品" HeaderText="產品：" SortExpression="產品" >
                <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="供應商：">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource11" DataTextField="供應商" DataValueField="供應商編號" SelectedValue='<%# Bind("供應商編號") %>'>
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource11" runat="server" ConnectionString="Data Source=localhost;Initial Catalog=中文北風;User ID=SQLUser;Password=1234" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [供應商編號], [供應商] FROM [供應商]"></asp:SqlDataSource>
                    </EditItemTemplate>
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="產品類別：">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource12" DataTextField="類別名稱" DataValueField="類別編號" SelectedValue='<%# Bind("類別編號") %>'>
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource12" runat="server" ConnectionString="Data Source=localhost;Initial Catalog=中文北風;User ID=SQLUser;Password=1234" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [類別編號], [類別名稱] FROM [產品類別]"></asp:SqlDataSource>
                    </EditItemTemplate>
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:TemplateField>
                <asp:BoundField DataField="單位數量" HeaderText="單位數量：" SortExpression="單位數量">
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="單價" HeaderText="單價：" SortExpression="單價">
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="庫存量" HeaderText="庫存量：" SortExpression="庫存量">
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:CheckBoxField DataField="不再銷售" HeaderText="不再銷售：" SortExpression="不再銷售">
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:CheckBoxField>
                <asp:TemplateField HeaderText="資料操作：">
                    <EditItemTemplate>
                        <asp:Button ID="Button1" runat="server" Text="確定修改" CommandName="Update" OnClientClick="javascript:return confirm('是否確定修改此產品資料？');" />
                        <input id="Reset1" type="reset" value="重新填寫" />
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:Button ID="Button2" runat="server" Text="確定新增" CommandName="Insert" OnClientClick="javascript:return confirm('是否確定新增此產品資料？');" />
                        <input id="Reset2" type="reset" value="重新填寫" />
                    </InsertItemTemplate>
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:TemplateField>
            </Fields>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=localhost;Initial Catalog=中文北風;User ID=SQLAdmin;Password=1234" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [產品編號], [產品], [供應商編號], [類別編號], [單位數量], [單價], [庫存量], [不再銷售] FROM [產品資料] WHERE ([產品編號] = @產品編號)" DeleteCommand="DELETE FROM [產品資料] WHERE [產品編號] = @產品編號" InsertCommand="INSERT INTO [產品資料] ([產品編號], [產品], [供應商編號], [類別編號], [單位數量], [單價], [庫存量], [不再銷售]) VALUES (@產品編號, @產品, @供應商編號, @類別編號, @單位數量, @單價, @庫存量, @不再銷售)" UpdateCommand="UPDATE [產品資料] SET [產品] = @產品, [供應商編號] = @供應商編號, [類別編號] = @類別編號, [單位數量] = @單位數量, [單價] = @單價, [庫存量] = @庫存量, [不再銷售] = @不再銷售 WHERE [產品編號] = @產品編號">
            <DeleteParameters>
                <asp:Parameter Name="產品編號" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="產品編號" Type="Int32" />
                <asp:Parameter Name="產品" Type="String" />
                <asp:Parameter Name="供應商編號" Type="Int32" />
                <asp:Parameter Name="類別編號" Type="Int32" />
                <asp:Parameter Name="單位數量" Type="String" />
                <asp:Parameter Name="單價" Type="Decimal" />
                <asp:Parameter Name="庫存量" Type="Int16" />
                <asp:Parameter Name="不再銷售" Type="Boolean" />
            </InsertParameters>
            <SelectParameters>
                <asp:QueryStringParameter Name="產品編號" QueryStringField="pid" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="產品" Type="String" />
                <asp:Parameter Name="供應商編號" Type="Int32" />
                <asp:Parameter Name="類別編號" Type="Int32" />
                <asp:Parameter Name="單位數量" Type="String" />
                <asp:Parameter Name="單價" Type="Decimal" />
                <asp:Parameter Name="庫存量" Type="Int16" />
                <asp:Parameter Name="不再銷售" Type="Boolean" />
                <asp:Parameter Name="產品編號" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </form>
</body>
</html>
