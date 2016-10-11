<%@ Page Language="VB" AutoEventWireup="false" 
CodeFile="Default.aspx.vb" 
Inherits="_Default" Theme = "CrazyOrange"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <hr />
        &nbsp;<br />
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Fun with Themes"></asp:Label><br />
        <br />
        <asp:Button ID="btnNoTheme" runat="server" Text="No Theme" />
        <asp:Button ID="btnGreenTheme" runat="server" Text="Basic Green" />
        <asp:Button ID="btnOrangeTheme" runat="server" Text="Crazy Orange" /><br />
        <br />
        <br />
        <hr />
    
    </div>
        &nbsp;<asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:Button ID="Button2" runat="server" SkinID="BigFontButton" Text="Button" /><br />
        &nbsp;<br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
