Option Strict On
Option Explicit On

Public Class MainForm
  ' A collection of Car objects.
  Private listCars As New List(Of Car)()

  ' View of the DataTable.
  Private coltsOnlyView As DataView

  ' Our DataTable.
  Private inventoryTable As New DataTable("Inventory")

  Public Sub New()
    InitializeComponent()

    ' Fill the list with some cars.
    listCars.Add(New Car("Chucky", "BMW", "Green"))
    listCars.Add(New Car("Tiny", "Yugo", "White"))
    listCars.Add(New Car("Ami", "Jeep", "Tan"))
    listCars.Add(New Car("Pain Inducer", "Caravan", "Pink"))
    listCars.Add(New Car("Fred", "BMW", "Pea Soup Green"))
    listCars.Add(New Car("Sidd", "BMW", "Black"))
    listCars.Add(New Car("Mel", "Firebird", "Red"))
    listCars.Add(New Car("Sarah", "Colt", "Black"))

    ' Make a data table.
    CreateDataTable()

    ' Make a view.
    CreateDataView()
  End Sub

#Region "Create the DataTable object and bind to grid."
  Private Sub CreateDataTable()
    ' Create table schema
    Dim carMakeColumn As New DataColumn("Make", GetType(String))
    Dim carColorColumn As New DataColumn("Color", GetType(String))
    Dim carPetNameColumn As New DataColumn("PetName", GetType(String))
    carPetNameColumn.Caption = "Pet Name"
    inventoryTable.Columns.AddRange(New DataColumn() {carMakeColumn, carColorColumn, carPetNameColumn})

    ' Iterate over the array list to make rows.
    For Each c As Car In listCars
      Dim newRow As DataRow = inventoryTable.NewRow()
      newRow("Make") = c.carMake
      newRow("Color") = c.carColor
      newRow("PetName") = c.carPetName
      inventoryTable.Rows.Add(newRow)
    Next

    ' Bind the DataTable to the carInventoryGridView.
    carInventoryGridView.DataSource = inventoryTable
  End Sub
#End Region

#Region "Handler for Remove Button's Click event."
  ' Remove this row from the DataRowCollection.
  Private Sub btnRemoveRow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveRow.Click
    Try
      inventoryTable.Rows((Integer.Parse(txtRowToRemove.Text))).Delete()
      inventoryTable.AcceptChanges()
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub
#End Region

#Region "Handler / helper function for filtering logic"
  Private Sub btnDisplayMakes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDisplayMakes.Click
    ' Build a filter based on user input.
    Dim filterStr As String = String.Format("Make= '{0}'", txtMakeToView.Text)

    ' Find all rows matching the filter.
    Dim makes As DataRow() = inventoryTable.Select(filterStr)

    ' Show what we got!
    If makes.Length = 0 Then
      MessageBox.Show("Sorry, no cars...", "Selection error!")
    Else
      Dim strMake As String = String.Empty
      For i As Integer = 0 To makes.Length - 1
        Dim temp As DataRow = makes(i)
        strMake &= temp("PetName").ToString() & Chr(10)
      Next
      MessageBox.Show(strMake, String.Format("{0} type(s):", txtMakeToView.Text))
    End If
  End Sub
#End Region

#Region "Change BMWs to Yugos (oh, the horror...)"
  Private Sub btnChangeBeemersToYugos_Click(ByVal sender As Object, _
                                            ByVal e As EventArgs) Handles btnChangeBeemersToYugos.Click
    ' Make sure user has not lost his or her mind.
    If DialogResult.Yes = MessageBox.Show("Are you sure?? BMWs are much nicer than Yugos!", _
                                          "Please Confirm!", MessageBoxButtons.YesNo) Then
      ' Build a filter.
      Dim filterStr As String = "Make='BMW'"

      ' Find all rows matching the filter.
      Dim makes As DataRow() = inventoryTable.Select(filterStr)
      For i As Integer = 0 To makes.Length - 1

        ' Change all Beemers to Yugos!
        makes(i)("Make") = "Yugo"
      Next
    End If
  End Sub
#End Region

#Region "Create our view object."
  Private Sub CreateDataView()
    ' Set the table that is used to construct this view.
    coltsOnlyView = New DataView(inventoryTable)

    ' Now configure the views using a filter.
    coltsOnlyView.RowFilter = "Make = 'Colt'"

    ' Bind to the new grid.
    dataGridColtsView.DataSource = coltsOnlyView
  End Sub
#End Region

#Region "car ID > 5 (not called, but here for example...)"
  Private Sub ShowCarsWithIdGreaterThanFive()
    ' Now show the pet names of all cars with ID greater than 5.
    ' (Assuming you did have an ID column!)
    Dim properIDs As DataRow()
    Dim newFilterStr As String = "ID > 5"
    properIDs = inventoryTable.Select(newFilterStr)

    Dim strIDs As String = String.Empty
    For i As Integer = 0 To properIDs.Length - 1
      Dim temp As DataRow = properIDs(i)
      strIDs &= temp("PetName").ToString() & " is ID " & temp("ID").ToString() & Chr(10)
    Next
    MessageBox.Show(strIDs, "Pet names of cars where ID > 5")
  End Sub
#End Region

#Region "This is just to see the row numbers"
  Private Sub carInventoryGridView_RowPostPaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs) Handles carInventoryGridView.RowPostPaint
    ' This extra code will simply make it easier to visualize the # of the rows. 
    Using b As New SolidBrush(Color.Black)
      e.Graphics.DrawString((e.RowIndex).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4)
    End Using
  End Sub

  Private Sub dataGridColtsView_RowPostPaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs) Handles dataGridColtsView.RowPostPaint
    ' A more funky font. 
    Using b As New SolidBrush(Color.Green)
      e.Graphics.DrawString((e.RowIndex).ToString(), New Font("Times New Roman", 11, FontStyle.Italic Or FontStyle.Bold), b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4)
    End Using
  End Sub
#End Region

End Class
