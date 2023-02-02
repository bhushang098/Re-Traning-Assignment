<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Connected_Disconnected_DB.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Button ID="btn_connected" runat="server" OnClick="btn_connected_Click" Text="Connected Show" />
            <br />
            <br />
            <asp:Button ID="btn_disconnected" runat="server" OnClick="btn_disconnected_Click" Text="Disconnected Show" />
            <asp:GridView ID="dgv_result" runat="server">
            </asp:GridView>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
