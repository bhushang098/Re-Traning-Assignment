<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WriteCookie.aspx.cs" Inherits="Cookies_demo.WriteCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Button ID="btn_redirect" runat="server" OnClick="btn_redirect_Click" Text="Redirect" />
            <br />
            <br />
            <asp:Label ID="lbl_cookie_info" runat="server" Text="Cookie Info"></asp:Label>
        </div>
    </form>
</body>
</html>
