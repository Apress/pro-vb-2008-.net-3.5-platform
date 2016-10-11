Imports AutoLotConnectedLayer
Imports System.Data
Imports System.Collections.Generic

Public Class VbAutoLotWCFService
  Implements IAutoLotService
  Private Const ConnString As String = "Data Source=(local)\SQLEXPRESS;Initial Catalog" & _
    "=AutoLot;Integrated Security=True"

  Public Sub InsertCar(ByVal id As Integer, ByVal make As String, _
                       ByVal color As String, ByVal petname As String) _
                       Implements IAutoLotService.InsertCar
    Dim d As New InventoryDAL()
    d.OpenConnection(ConnString)
    d.InsertAuto(id, color, make, petname)
    d.CloseConnection()
  End Sub

  Public Sub InsertCarWithDetails(ByVal car As InventoryRecord) Implements IAutoLotService.InsertCar
    Dim d As New InventoryDAL()
    d.OpenConnection(ConnString)
    d.InsertAuto(car.ID, car.Color, car.Make, car.PetName)
    d.CloseConnection()
  End Sub

  Public Function GetInventory() As InventoryRecord() Implements IAutoLotService.GetInventory
    ' First, get the DataTable from the database.
    Dim d As New InventoryDAL()
    d.OpenConnection(ConnString)
    Dim dt As DataTable = d.GetAllInventory()
    d.CloseConnection()

    ' Now make a List<T> to contain the records.
    Dim records As New List(Of InventoryRecord)()

    ' Copy the data table into List<> of custom contracts. 
    Dim reader As DataTableReader = dt.CreateDataReader()
    While reader.Read()
      Dim r As New InventoryRecord()
      r.ID = CInt(reader("CarID"))
      r.Color = DirectCast(reader("Color"), String).Trim()
      r.Make = DirectCast(reader("Make"), String).Trim()
      r.PetName = DirectCast(reader("PetName"), String).Trim()
      records.Add(r)
    End While

    ' Transform List<T> to array of InventoryRecord types.
    Return DirectCast(records.ToArray(), InventoryRecord())
  End Function
End Class
