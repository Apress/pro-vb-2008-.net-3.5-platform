Option Strict On
Option Explicit On

Imports AutoLotDisconnectedLayer

Module Program
  Sub Main()
    Console.WriteLine("***** LINQ over DataSet *****" & vbLf)
    ' Get a DataTable containing the current Inventory
    ' of the AutoLot database.
    Dim dal As New InventoryDALDisLayer _
      ("Data Source=(local)\SQLEXPRESS;Initial Catalog=AutoLot;" & _
       "Integrated Security=True")
    Dim data As DataTable = dal.GetAllInventory()

    ' Invoke the methods that follow here!
    PrintAllCarIDs(data)
    Console.WriteLine()

    ApplyLinqQuery(data)
    Console.WriteLine()

    BuildDataTableFromQuery(data)
    Console.WriteLine()

    Console.ReadLine()
  End Sub

#Region "Print all car IDs"
  Sub PrintAllCarIDs(ByVal data As DataTable)
    Console.WriteLine("All Car IDs:")

    ' Get enumerable version of DataTable.
    Dim enumData As EnumerableRowCollection = data.AsEnumerable()

    ' Print the car ID values.
    For Each r As DataRow In enumData
      Console.WriteLine("Car ID = {0}", r("CarID"))
    Next
  End Sub
#End Region

#Region "Apply LINQ query"
  Sub ApplyLinqQuery(ByVal data As DataTable)
    ' Project a new result set containing
    ' the ID/color for rows with a CarID > 5
    Dim cars = From car In data Where _
               car.Field(Of Integer)("CarID") > 5 _
             Select New With _
             { _
               .ID = car.Field(Of Integer)("CarID"), _
               .Color = car.Field(Of String)("Color") _
             }

    Console.WriteLine("Cars with ID greater than 5:")
    For Each item In cars
      Console.WriteLine("-> CarID = {0} is {1}", item.ID, item.Color)
    Next
  End Sub
#End Region

#Region "DataTable from Query"
  Sub BuildDataTableFromQuery(ByVal data As DataTable)
    Dim cars = From car In data _
    Where car.Field(Of Integer)("CarID") > 5 _
      Select car

    ' Use this result set to build a new DataTable.
    Dim newTable As DataTable = cars.CopyToDataTable()
    For curRow As Integer = 0 To newTable.Rows.Count - 1

      ' Print the DataTable.
      For curCol As Integer = 0 To newTable.Columns.Count - 1
        Console.Write(newTable.Rows(curRow)(curCol).ToString().Trim() & vbTab)
      Next
      Console.WriteLine()
    Next
  End Sub
#End Region

End Module
