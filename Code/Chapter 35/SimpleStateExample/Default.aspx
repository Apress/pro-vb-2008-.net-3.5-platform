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
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Simple State Example"></asp:Label>
            <hr />
        </div>
        <asp:Button ID="btnSetCar" runat="server" OnClick="btnSetCar_Click" Text="Set Favorite Car" />
        <asp:TextBox ID="txtFavCar" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="btnGetCar" runat="server" OnClick="btnGetCar_Click" Text="Get Favorite Car" />&nbsp;
        <asp:Label ID="lblFavCar" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
