<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="Login_Redirection.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
             <asp:Label ID="Label1" runat="server" Text="user name"></asp:Label>
               <asp:TextBox ID="tb_user_name" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
             <asp:TextBox ID="tb_password" runat="server"></asp:TextBox>
            <br />
            <br />
            
            <br />
            <br />
            <br />
           
             <asp:Button ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click" />

            <br />

            <br />
             <asp:Label ID="registerlabel" runat="server" Text="New User ?"></asp:Label>
           

        &nbsp;<asp:Button ID="btn_register_go" runat="server" Text="Register Here" OnClick="btn_register_go_Click" />
            <br />
           
        </div>
    </form>
</body>
</html>
