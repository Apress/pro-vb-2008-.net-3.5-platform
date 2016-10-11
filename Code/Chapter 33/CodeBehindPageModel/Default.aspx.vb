Imports AutoLotConnectedLayer

Partial Class _Default
  Inherits System.Web.UI.Page

  Protected Sub btnFillGrid_Click(ByVal sender As Object, _
   ByVal e As System.EventArgs) Handles btnFillGrid.Click
    Trace.Write("My Category", "Filling the grid!")
    Dim dal As New InventoryDAL()
    dal.OpenConnection("Data Source=(local)\SQLEXPRESS;" & _
      "Initial Catalog=AutoLot;Integrated Security=True")
    carsGridView.DataSource = dal.GetAllInventory()
    carsGridView.DataBind()
    dal.CloseConnection()
  End Sub
End Class
