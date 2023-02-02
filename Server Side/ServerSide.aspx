<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerSide.aspx.cs" Inherits="Server_Side.ServerSide" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="application_count" runat="server" Text="Application Count"></asp:Label>
            <br />
            <br />
            <asp:Label ID="session_count" runat="server" Text="Session Count"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_hellow" runat="server" Text="Say Hellow" OnClick="btn_hellow_Click" />
            <br />
        </div>
    </form>
</body>
</html>
