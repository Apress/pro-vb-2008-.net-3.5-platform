<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Dynamic Controls"></asp:Label>
            <hr />
            <br />
            <asp:Panel ID="myPanel" runat="server" Height="50px" Width="125px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                <asp:Button ID="Button1" runat="server" Text="Button" /><br />
                <asp:HyperLink ID="HyperLink1" runat="server">HyperLink
                </asp:HyperLink>
            </asp:Panel>
            <br />
            <asp:Button ID="btnRemovePanelItems" runat="server" Text="Clear Panel" />
            <asp:Button ID="btnAddWidgets" runat="server" Text="Add Controls" />
            <asp:Button ID="btnGetTextBoxValues" runat="server" Text="Get Textbox Values" /><br />
            <br />
            <asp:Label ID="lblTextBoxText" runat="server"></asp:Label><br />
            <br />
            <asp:Label ID="lblControlInfo" runat="server"></asp:Label><br />
            <hr />
            &nbsp;
        </div>
    </form>
</body>
</html>
