<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge_5_EpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 131px;
            height: 150px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="Logo" class="auto-style1" src="epic-spies-logo.jpg" /></div>
        <h2 class="auto-style2">Asset Performance Tracker</h2>
        <p>
            Asset Name:
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Elections Rigged: <asp:TextBox ID="riggedTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Acts of Subterfuge Performed:
            <asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
