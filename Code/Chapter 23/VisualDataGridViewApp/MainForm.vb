Public Class MainForm
  Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'InventoryDataSet.Inventory' table. You can move, or remove it, as needed.
    Me.InventoryTableAdapter.Fill(Me.InventoryDataSet.Inventory)
  End Sub

  Private Sub btnUpdateInventory_Click(ByVal sender As System.Object, _
                                       ByVal e As System.EventArgs) Handles btnUpdateInventory.Click
    ' This will push any changes within the Inventory table back to 
    ' the database for processing. 
    Me.InventoryTableAdapter.Update(Me.InventoryDataSet.Inventory)

    ' Get fresh copy for grid.
    Me.InventoryTableAdapter.Fill(Me.InventoryDataSet.Inventory)
  End Sub

#Region "Add new row"
  Private Sub btnAddRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRow.Click
    ' Get data from widgets
    Dim id As Integer = Integer.Parse(txtCarID.Text)
    Dim make As String = txtMake.Text
    Dim color As String = txtColor.Text
    Dim petName As String = txtPetName.Text

    ' Use custom adapter to add row.
    InventoryTableAdapter.Insert(id, make, color, petName)

    ' Refill table data.
    Me.InventoryTableAdapter.Fill(Me.InventoryDataSet.Inventory)
  End Sub

  'Private Sub btnAddRow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddRow.Click
  '  ' Get new Row.
  '  Dim newRow As InventoryDataSet.InventoryRow = InventoryDataSet.Inventory.NewInventoryRow()
  '  newRow.CarID = Integer.Parse(txtCarID.Text)
  '  newRow.Make = txtMake.Text
  '  newRow.Color = txtColor.Text
  '  newRow.PetName = txtPetName.Text
  '  InventoryDataSet.Inventory.AddInventoryRow(newRow)

  '  ' Use custom adapter to add row.
  '  InventoryTableAdapter.Update(InventoryDataSet.Inventory)

  '  ' Refill table data.
  '  Me.InventoryTableAdapter.Fill(Me.InventoryDataSet.Inventory)
  'End Sub
#End Region

End Class
