<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge_2_ConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            Your Note Taking Preference?<br />
            <br />
            <asp:RadioButton ID="pencilRadioButton" runat="server" Text="Pencil" GroupName="Note" />
        <br />
        <asp:RadioButton ID="penRadioButton" runat="server" Text="Pen" GroupName="Note" />
        <br />
        <asp:RadioButton ID="phoneRadioButton" runat="server" Text="Phone" GroupName="Note" />
        <br />
        <asp:RadioButton ID="tabletRadioButton" runat="server" Text="Tablet" GroupName="Note" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" Text="OK" OnClick="okButton_Click" />
        <br />
        <br />
        <asp:Image ID="resultImage" runat="server" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
