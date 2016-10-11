Imports System.Data.Linq

Class AutoLotDatabase
  Inherits DataContext

  ' Define a member variable representing 
  ' the table in the database.
  Public Inventory As Table(Of Inventory)

  ' Pass connection string to base class.
  Public Sub New(ByVal connectionString As String)
    MyBase.New(connectionString)
  End Sub
End Class
