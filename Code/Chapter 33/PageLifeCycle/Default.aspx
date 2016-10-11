<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Show Page Event Sequence"></asp:Label><br />
            <br />
            <asp:Button ID="btnPostback" runat="server" OnClick="btnPostback_Click" Text="Postback" />
            <asp:Button ID="btnTriggerError" runat="server" OnClick="btnTriggerError_Click" Text="Trigger Error" /><br />
            <br />
            <asp:Label ID="lblPageEvents" runat="server"></asp:Label>&nbsp;</div>
    
    </div>
    </form>
</body>
</html>
