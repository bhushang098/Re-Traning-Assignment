<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadCookie.aspx.cs" Inherits="Cookies_demo.ReadCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_read_cookie" runat="server" OnClick="btn_read_cookie_Click" Text="Read Cookie" />
            <br />
            <br />
            <asp:Label ID="Label_current_time" runat="server" Text="Current Time"></asp:Label>
            <br />
            <br />
            Cookie 
            <asp:Label ID="Label_time" runat="server" Text="Time"></asp:Label>
        </div>
    </form>
</body>
</html>
