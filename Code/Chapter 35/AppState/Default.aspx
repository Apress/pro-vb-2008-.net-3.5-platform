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
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Fun with Application State"></asp:Label><br />
            <br />
            <hr />
            <br />
            <asp:Button ID="btnShowAppVariables" runat="server" OnClick="btnShowAppVariables_Click"
                Text="Show App Variables" /><br />
            <br />
            <asp:Label ID="lblAppVariables" runat="server"></asp:Label><br />
            <br />
            <br />
            <asp:Button ID="btnSetNewSP" runat="server" OnClick="btnSetNewSP_Click" Text="Set New Sales Person" />
            <asp:TextBox ID="txtNewSP" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnShowCarOnSale" runat="server" Text="Show Car On Sale" />
            <asp:Label ID="lblCurrCarOnSale" runat="server"></asp:Label></div>
    
    </div>
    </form>
</body>
</html>
