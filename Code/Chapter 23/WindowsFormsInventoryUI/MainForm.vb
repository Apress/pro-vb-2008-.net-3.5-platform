Imports AutoLotDisconnectedLayer
Imports System.Configuration

Public Class MainForm
  Private dal As InventoryDALDisLayer = Nothing

  Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    ' Assume we have an App.config file
    ' storing the connection string. 
    Dim cnStr As String = ConfigurationManager.ConnectionStrings("AutoLotSqlProvider").ConnectionString

    ' Create our data access object.
    dal = New InventoryDALDisLayer(cnStr)

    ' Fill up our grid!
    inventoryGrid.DataSource = dal.GetAllInventory()
  End Sub

  Private Sub btnUpdateInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateInventory.Click
    Dim changedDT As DataTable = DirectCast(inventoryGrid.DataSource, DataTable)
    ' Commit our changes. 
    dal.UpdateInventory(changedDT)
  End Sub
End Class
