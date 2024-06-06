<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="UAP_PSD.Views.LoginPaage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="GymMe - Login"></asp:Label>
        </div>
        <div>
            <asp:Label ID="LabelUsername" runat="server" Text="Username :"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="LabelPassword" runat="server" Text="Password :"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
        <div>
            <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
        </div>
    </form>
</body>
</html>
