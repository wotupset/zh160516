<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>LoginDone</title>
</head>
<body>
    <h1>填寫資料如下</h1>
    <p>帳號：<%=ViewData["aa"] %></p>
    <p><%=ViewData["bb"] %></p>
</body>
</html>
