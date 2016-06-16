<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>頁面3</title>
</head>
<body>
    <h1>頁面3</h1>
    <p>VV1的值：<%=ViewData["VV1"] %></p>
    <p>VV2的值：<%=ViewData["VV2"] %></p>
    <p><%
            if((int)ViewData["VV1"]>1000)       
                Response.Write("<span style='font-weight:bold;color:blue'>"+ViewData["VV1"]+"</span>的值達標");
            else       
                Response.Write(string.Format("<span style='font-weight:bold;color:red'>{0}</span>的值未達標",ViewData["VV1"]));       
              
       %>
    </p>
    <table style="width:600px;border:1px solid blue;">
        <%
            for (int i = 1; i <= 9; i++)
            {
                Response.Write("<tr>");
                for (int j = 1; j <= 9; j++)
                {
                    Response.Write("<td style='border:1px solid blue;padding:10px;'>");
                    Response.Write(string.Format("{0}*{1}={2}", i, j, i * j));
                    Response.Write("</td>");
                }
                Response.Write("</tr>");
            }
        %>
    </table>
    <table style="width:600px;border:1px solid blue;">
        <% for (int i = 1; i <= 9; i++) { %>
        <tr>
            <% for (int j = 1; j <= 9; j++) { %>                
                <td style="border:1px solid blue;padding:10px;">
                    <%Response.Write(string.Format("{0}*{1}={2}", i, j, i * j));%>
                </td>
            <%}%>
        </tr>
        <%}%>        
    </table>
    <%:ViewData["VV3"] %>
    <%:ViewData["VV4"] %>
    <%:ViewData["VV5"] %>
</body>
</html>
