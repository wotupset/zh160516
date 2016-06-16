<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Main</title>
</head>
<body>    
    <form action="/Login/LoginDone" method="post">
        <table>
            <tr>
                <td colspan="2" style="text-align:center">會員登入</td>
            </tr>
            <tr>
                <td>帳號：</td>
                <td><input type="text" name="Account" required="required" placeholder="請輸入帳號" /></td>
            </tr>
            <tr>
                <td>密碼：</td>
                <td><input type="password" name="Password" required="required" placeholder="請輸入密碼" /></td>
            </tr>
            <tr>
                <td colspan="2"  style="text-align:center"><input type="submit" value="登入" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
