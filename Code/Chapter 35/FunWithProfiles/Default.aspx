<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
  <title>Untitled Page</title>
</head>
<body>
  <form id="form1" runat="server">
  <div>
      <hr />
  
  </div>
      <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Fun with Profiles"></asp:Label><br />
      <hr />
      <br />
      <asp:Label ID="Label2" runat="server" Text="Street Address"></asp:Label>
      <asp:TextBox ID="txtStreetAddress" runat="server"></asp:TextBox><br />
      <br />
      <asp:Label ID="Label3" runat="server" Text="City"></asp:Label>
      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
      <asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br />
      <br />
      <asp:Label ID="Label4" runat="server" Text="State"></asp:Label>
      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
      <asp:TextBox ID="txtState" runat="server"></asp:TextBox><br />
      <br />
      <asp:Button ID="btnSubmit" runat="server" Text="Submit Data" /><br />
      <br />
      <asp:Label ID="lblUserData" runat="server"></asp:Label>
  </form>
</body>
</html>