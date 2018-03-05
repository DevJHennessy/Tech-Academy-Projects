<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_068_BootstrapExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div class="container">

        <div class="page-header">
            <h1>Page Header</h1>
            <p class="lead">By line (lead)</p>
        </div>

        <div class="row">
            <div class="col-md-8 col-sm-6 col-8">
                Dummy Text. kfdkgfkdgjlsd fkldfksdfksdflskd flsdkflsdk fdfkgjdfhbgreb refbrfdfns dfnsdnfndjf. tkgdkgtuwlkmfm. oqkkndkndfkdlfl.
            </div>
            <div class="col-md-4 col-sm-6 col-4">
                More Dummy Text. fdjfsdjfjkrnfewnriehbg da f;lewihrsf jdnf;IEWFNDFNNnfjkjkgbtrjkntgjk. fgfkldgfhdgirtjjkler. dfjsdkjfnrertbkdfkk. mkfneskgnf.
            </div>
        </div>

        <div class="form-group">
            <label>TextBox: </label>
            <asp:TextBox ID="testTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label>DropDrownList:</label>
            <asp:DropDownList ID="testDropDownList" runat="server" CssClass="form-control">
                <asp:ListItem Text="Option 1" Value="Small" />
                <asp:ListItem Text="Option 2" Value="Medium" />
                <asp:ListItem Text="Option 3" Value="Large" />
            </asp:DropDownList>
        </div>

        <div class="checkbox"><label><asp:CheckBox ID="testCheckBox" runat="server"></asp:CheckBox> CheckBox</label></div>

        <div class="radio"><label><asp:RadioButton ID="testRadioButton1" runat="server" GroupName="TestGroup"></asp:RadioButton> RadionButton1</label></div>
        <div class="radio"><label><asp:RadioButton ID="testRadioButton2" runat="server" GroupName="TestGroup"></asp:RadioButton> RadioButton2</label></div>

        <asp:Button ID="testButton" runat="server" Text="Test" CssClass="btn btn-lg btn-primary" />

    </div>
    </form>
    <script src="scripts/jquery-3.3.1.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>

</body>
</html>
