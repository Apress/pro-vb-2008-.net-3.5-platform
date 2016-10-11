<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Fun with Cookies"></asp:Label><br />
            <hr />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Cookie Name:"></asp:Label>
            <asp:TextBox ID="txtCookieName" runat="server"></asp:TextBox><br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Cookie Value:"></asp:Label><asp:TextBox
                ID="txtCookieValue" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="btnNewCookie" runat="server" OnClick="btnNewCookie_Click" Text="Write This Cookie" /><br />
            <br />
            <hr />
            <br />
            <asp:Button ID="btnShowCookie" runat="server" OnClick="btnShowCookie_Click" Text="Show Cookie Data" /><br />
            <br />
            <asp:Label ID="lblCookieData" runat="server"></asp:Label>
        </div>
    
    </div>
    </form>
</body>
</html>
