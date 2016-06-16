<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data5.aspx.cs" Inherits="MyWeb.Data.Data5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        #ProductItem {
            width:100%;
        }
        #ProductItem table {
            width:100%;
        }
        #ProductItem td {
            padding:10px;
        }
        .Title {
            font-weight:bold;
            font-size:16pt;
        }
        .Header {
            text-align:right;
            font-weight:bold;
        }

    </style>
</head>
<body>
    <h1>資料頁面5</h1>
    <form id="form1" runat="server">    
        <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataKeyField="產品編號" DataSourceID="SqlDataSource1" ForeColor="#333333" Width="800px">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <ItemTemplate>
                <table id="ProductItem">
                    <tr>
                        <td style="width:150px;text-align:center"><img src="/Data/GetProductImage.ashx?pid=<%# Eval("產品編號") %>" /></td>
                        <td>
                            <table style="width:100%">
                                <tr>
                                    <td colspan="4" class="Title"><asp:Label ID="產品Label" runat="server" Text='<%# Eval("產品") %>' /></td>
                                </tr>
                                <tr>
                                    <td class="Header">產品編號：</td>
                                    <td><asp:Label ID="產品編號Label" runat="server" Text='<%# Eval("產品編號") %>' /></td>
                                    <td class="Header">單價：</td>
                                    <td><asp:Label ID="Label1" runat="server" Text='<%# Eval("單價") %>' /></td>
                                </tr>
                                 <tr>                                    
                                    <td class="Header">單位數量：</td>
                                    <td><asp:Label ID="Label2" runat="server" Text='<%# Eval("單位數量") %>' /></td>
                                    <td class="Header">庫存量：</td>
                                    <td><asp:Label ID="庫存量Label" runat="server" Text='<%# Eval("庫存量") %>' /></td>
                                </tr>
                                <tr>                                    
                                    <td class="Header">供應商：</td>
                                    <td><asp:Label ID="供應商Label" runat="server" Text='<%# Eval("供應商") %>' /></td>
                                    <td class="Header">產品類別：</td>
                                    <td><asp:Label ID="類別名稱Label" runat="server" Text='<%# Eval("類別名稱") %>' /></td>
                                </tr>
                                <tr>
                                    <td colspan="4">&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>                
            </ItemTemplate>
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=localhost;Initial Catalog=中文北風;User ID=SQLUser;Password=1234" ProviderName="System.Data.SqlClient" SelectCommand="SELECT 產品資料.產品編號, 產品資料.產品, 供應商.供應商, 產品類別.類別名稱, 產品資料.單位數量, 產品資料.單價, 產品資料.庫存量 FROM 供應商 INNER JOIN 產品資料 ON 供應商.供應商編號 = 產品資料.供應商編號 INNER JOIN 產品類別 ON 產品資料.類別編號 = 產品類別.類別編號"></asp:SqlDataSource>
    </form>
</body>
</html>
