<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge_4_EpicSpies.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 164px;
            height: 190px;
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
        <h1>Spy New Assignment Form</h1>
        <p>
            Spy Code Name:
            <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:
            <asp:TextBox ID="assignmentTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment<asp:Calendar ID="previousCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment<asp:Calendar ID="startCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected End Date of New Assignment<asp:Calendar ID="endCalendar" runat="server"></asp:Calendar>
        </p>
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Assign Spy" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
