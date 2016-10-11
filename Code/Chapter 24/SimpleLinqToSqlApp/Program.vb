Imports System.Data.Linq

Module Program
  Const cnStr As String = _
     "Data Source=(local)\SQLEXPRESS;Initial Catalog=AutoLot;" & _
     "Integrated Security=True"

  Sub Main()
    Console.WriteLine("***** LINQ to SQL Sample App *****")
    Console.WriteLine()

    ' Create a AutoLotDatabase object.
    Dim db As New AutoLotDatabase(cnStr)

    ' Note we can now use the Inventory field of AutoLotDatabase.
    Console.WriteLine("-> Contents of Inventory Table from AutoLot database:")
    For Each car In From c In db.Inventory Select c
      Console.WriteLine(car.ToString())
    Next

    Console.WriteLine()
    ShowOnlyBimmers(db)
    Console.ReadLine()
  End Sub

#Region "Show only BMWs"
  Sub ShowOnlyBimmers(ByVal db As AutoLotDatabase)
    Console.WriteLine("***** Only BMWs *****")

    ' Get the BMWs.
    Dim bimmers = From s In db.Inventory _
    Where (s.Make = "BMW") _
    Order By s.CarID Select s

    For Each c In bimmers
      Console.WriteLine(c.ToString())
    Next
  End Sub
#End Region

End Module

