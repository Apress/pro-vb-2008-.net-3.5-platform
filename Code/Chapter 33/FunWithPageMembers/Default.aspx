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
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Fun with Members of the Page Type"></asp:Label><br />
            <br />
            <asp:Button ID="btnGetBrowserStats" runat="server" OnClick="btnGetBrowserStats_Click"
                Text="Show Browser Stats" /><br />
            <br />
            <asp:Label ID="lblOutput" runat="server"></asp:Label><br />
            <br />
            <asp:Button ID="btnGetFormData" runat="server" OnClick="btnGetFormData_Click" Text="Show vaule in Textbox" />
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblFormData" runat="server"></asp:Label><br />
            <br />
            <asp:Button ID="btnHttpResponse" runat="server" OnClick="btnHttpResponse_Click" Text="Trigger Response.Write() logic" /><br />
            <br />
            <asp:Button ID="btnSomeTraining" runat="server" OnClick="btnSomeTraining_Click" Text="Go to Intertech Training" /></div>
    
    </div>
    </form>
</body>
</html>
