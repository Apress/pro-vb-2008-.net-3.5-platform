<%@ Page Language="VB" %>
<%@ Import Namespace="AutoLotConnectedLayer" %>
<%@ Assembly Name="AutoLotDAL" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
  Protected Sub btnFillData_Click(ByVal sender As Object, ByVal e As EventArgs)
    Dim dal As New InventoryDAL()
    dal.OpenConnection("Data Source=(local)\SQLEXPRESS;" & _
      "Initial Catalog=AutoLot;Integrated Security=True")
    carsGridView.DataSource = dal.GetAllInventory()
    carsGridView.DataBind()
    dal.CloseConnection()
  End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Cars Inventory</title>
</head>
<body>
  <form id="form1" runat="server">
  <div>
    <asp:Label ID="lblInfo" runat="server" Text="Click on the Button to Fill the Grid">
    </asp:Label>
    <br />
    <br />
    <asp:GridView ID="carsGridView" runat="server">
    </asp:GridView>
    <br />
    <asp:Button ID="btnFillData" runat="server" Text="Fill Grid" OnClick="btnFillData_Click" />
  </div>
  </form>
</body>
</html>
