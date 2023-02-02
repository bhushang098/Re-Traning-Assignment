<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Registration.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="User Naml"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="tb_user_name" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email ID"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="tb_email" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="tb_age" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="tb_password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Conf password"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="tb_conform_pass"   runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lbl_validation" runat="server" Text="validation Messahe"></asp:Label>
            <br />
        </div>
        <asp:Button ID="btn_submit" runat="server" OnClick="btn_submit_Click" Text="Submit" />
    </form>
</body>
</html>
