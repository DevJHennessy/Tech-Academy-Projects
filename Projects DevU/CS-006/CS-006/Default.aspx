<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_006.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            color: #FF3300;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            background-color: #FFFF00;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <h1>Head Line 1</h1>
    <h2>Head Line 2</h2>
    <h3>Head Line 3</h3>
    <h4>Head Line 4</h4>
    <h5>Head Line 5</h5>
    <h6>Head Line 6</h6>
    <p class="auto-style1">
        This is some text that I want to <span class="auto-style2">apply</span> a style to.</p>
    <p>
        <a href="http://www.learningvisualstudio.net">Add a Hyperlink.

        </a>
    </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.microsoft.com" Target="_blank">This is another hyperlink.</asp:HyperLink>
    </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/favicon-96x96.png" />
        <br />
        <br />
        <table class="auto-style3">
            <tr>
                <td>Player</td>
                <td>Year</td>
                <td>Home runs</td>
            </tr>
            <tr>
                <td>Sammy sosa</td>
                <td>2005</td>
                <td>100</td>
            </tr>
            <tr>
                <td>Mark Macguire</td>
                <td>2005</td>
                <td>102</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
    </form>
    <ol>
        <li>First Item</li>
        <li>Second Item</li>
        <li>Third Item</li>
    </ol>
    <p>
        &nbsp;</p>
    <ul>
        <li class="auto-style4">This is blah</li>
        <li class="auto-style4">This is more blah</li>
        <li class="auto-style4">Again, more blah.</li>
    </ul>
</body>
</html>
