<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Home Page2</title>
</head>
<body>
    <h1>Home Page2頁面</h1>
    <h1>Home Page2頁面</h1>
    <p>值1：<%=ViewData["V1"] %></p>
    <p>值2：<%=ViewData["V2"] %></p>    
    <p><%
           for (int i = 1; i <= 10; i++)
               Response.Write(i + ". 巨匠電腦<br />");
        %></p>
    <%=ViewData["V3"] %>
</body>
</html>
