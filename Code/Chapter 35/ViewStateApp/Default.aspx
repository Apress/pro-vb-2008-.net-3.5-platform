<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" EnableViewState ="false"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Fun with View State"></asp:Label><br />
            <hr />
            &nbsp;</div>
            <asp:ListBox ID="myListBox" runat="server">
            </asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnPostback" runat="server" Text="Submit" />&nbsp;<br />
        <br />
        <asp:Button ID="btnAddToVS" runat="server" OnClick="btnAddToVS_Click" Text="Add Value to ViewState" /><br />
        <br />
        <asp:Label ID="lblVSValue" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
