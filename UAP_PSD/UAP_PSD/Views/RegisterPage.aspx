<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="UAP_PSD.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelRegister1" runat="server" Text="GymMe - Register"></asp:Label>
        </div>
        <div>
            <asp:Label ID="LabelRegUsername" runat="server" Text="Username :"></asp:Label>
            <asp:TextBox ID="TextBoxRegUsername" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelRegEmail" runat="server" Text="Email :"></asp:Label>
            <asp:TextBox ID="TextBoxRegEmail" runat="server"></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="LabelRegGender" runat="server" Text="Gender :"></asp:Label>
             <asp:RadioButton ID="Male" runat="server" /><asp:RadioButton ID="Female" runat="server" />
        </div>
        <div>
            <asp:Label ID="LabelRegPassword" runat="server" Text="Password :"></asp:Label>
            <asp:TextBox ID="TextBoxRegPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelRegConfPassword" runat="server" Text="Confirm Password :"></asp:Label>
            <asp:TextBox ID="TextBoxRegConfPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelRegDOB" runat="server" Text="Date Of Birth :"></asp:Label>
            <asp:Calendar ID="RegDOB" runat="server" OnSelectionChanged="RegDOB_SelectionChanged"></asp:Calendar>
        </div>
        <div>
            <asp:Label ID="ErrorLabelRegister" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
            <asp:Button ID="ButtonRegister" runat="server" Text="Register" />
    </form>
</body>
</html>
