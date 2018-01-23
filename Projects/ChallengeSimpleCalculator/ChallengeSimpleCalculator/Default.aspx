<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            font-size: large;
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Simple Calculator</h1>
        <p>
            <span class="auto-style3">First Value:</span>
            <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <span class="auto-style3">Second Value:</span><span class="auto-style2"> </span>
            <asp:TextBox ID="secondTextBox" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="+" />
&nbsp;<asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" Text="-" />
&nbsp;<asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="*" />
&nbsp;<asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" />
        </p>
        <asp:Label ID="resultLabel" runat="server" BackColor="#0066FF" style="font-weight: 700; font-size: x-large"></asp:Label>
    </form>
</body>
</html>
