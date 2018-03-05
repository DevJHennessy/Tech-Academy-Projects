<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_059_LocalDbExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Customers</h2>
        <br />
        <asp:GridView ID="customersGridView" runat="server">
        </asp:GridView>
        <p>&nbsp;</p>
        
        Name:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        Address: <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
        <br />
         City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="cityTextBox" runat="server"></asp:TextBox>
        <br />
         State:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="stateTextBox" runat="server"></asp:TextBox>
        <br />
         Zip:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="zipTextBox" runat="server"></asp:TextBox>
        <br />
         Notes:&nbsp;&nbsp; <asp:TextBox ID="notesTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" Text="Save Data" OnClick="okButton_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
