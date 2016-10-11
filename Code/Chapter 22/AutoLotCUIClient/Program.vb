Imports AutoLotConnectedLayer
Imports System.Configuration

Module Program
  Sub Main()
    Console.WriteLine("***** The AutoLot Console UI *****" & vbLf)

    ' Get connection string from app.config.
    Dim cnStr As String = ConfigurationManager.ConnectionStrings("AutoLotSqlProvider").ConnectionString
    Dim userDone As Boolean = False
    Dim userCommand As String = String.Empty

    ' Create our InventoryDAL object.
    Dim invDAL As New InventoryDAL()
    invDAL.OpenConnection(cnStr)

    ' Keep asking for input until user clicks the Q key.
    Try
      ShowInstructions()

      Do
        Console.Write("Please enter your command: ")
        userCommand = Console.ReadLine()
        Console.WriteLine()
        Select Case userCommand.ToUpper()
          Case "I"
            InsertNewCar(invDAL)
            Exit Select
          Case "U"
            UpdateCarPetName(invDAL)
            Exit Select
          Case "D"
            DeleteCar(invDAL)
            Exit Select
          Case "L"
            ListInventory(invDAL)
            Exit Select
          Case "S"
            ShowInstructions()
            Exit Select
          Case "C"
            ClearConsole()
            Exit Select
          Case "P"
            LookUpPetName(invDAL)
            Exit Select
          Case "Q"
            userDone = True
            Exit Select
          Case Else
            Console.WriteLine("Bad data!  Try again")
            Exit Select
        End Select
      Loop While Not userDone
    Catch ex As Exception
      Console.WriteLine(ex.Message)
    Finally
      invDAL.CloseConnection()
    End Try
  End Sub

#Region "Show Instructions / Clear"
  Private Sub ShowInstructions()
    Console.WriteLine("I: Inserts a new car.")
    Console.WriteLine("U: Updates an existing car.")
    Console.WriteLine("D: Deletes an existing car.")
    Console.WriteLine("L: Lists current inventory.")
    Console.WriteLine("S: Shows these instructions.")
    Console.WriteLine("C: Clears console and show instructions.")
    Console.WriteLine("P: Looks up pet name.")
    Console.WriteLine("Q: Quits program.")
  End Sub

  Private Sub ClearConsole()
    Console.Clear()
    ShowInstructions()
  End Sub
#End Region

#Region "ListInventory method"
  Private Sub ListInventory(ByVal invDAL As InventoryDAL)
    Dim dt As DataTable = invDAL.GetAllInventory()
    DisplayTable(dt)
  End Sub

  Private Sub DisplayTable(ByVal dt As DataTable)
    For curCol As Integer = 0 To dt.Columns.Count - 1
      ' Print out the column names.
      Console.Write(dt.Columns(curCol).ColumnName.Trim() & vbTab)
    Next
    Console.WriteLine(vbLf & "----------------------------------")
    For curRow As Integer = 0 To dt.Rows.Count - 1

      ' Print the DataTable.
      For curCol As Integer = 0 To dt.Columns.Count - 1
        Console.Write(dt.Rows(curRow)(curCol).ToString().Trim() & vbTab)
      Next
      Console.WriteLine()
    Next
  End Sub
#End Region

#Region "Delete Car"
  Private Sub DeleteCar(ByVal invDAL As InventoryDAL)
    ' Get ID of car to delete.
    Console.Write("Enter ID of Car to delete: ")
    Dim id As Integer = Integer.Parse(Console.ReadLine())

    ' Just in case we have a primary key 
    ' violation!
    Try
      invDAL.DeleteCar(id)
    Catch ex As Exception
      Console.WriteLine(ex.Message)
    End Try
  End Sub
#End Region

#Region "Update pet name / Get pet name"
  Private Sub UpdateCarPetName(ByVal invDAL As InventoryDAL)
    ' First get the user data.
    Dim carID As Integer
    Dim newCarPetName As String

    Console.Write("Enter Car ID: ")
    carID = Integer.Parse(Console.ReadLine())
    Console.Write("Enter New Pet Name: ")
    newCarPetName = Console.ReadLine()

    ' Now pass to data access library.
    invDAL.UpdateCarPetName(carID, newCarPetName)
  End Sub

  Private Sub LookUpPetName(ByVal invDAL As InventoryDAL)
    ' Get ID of car to look up.
    Console.Write("Enter ID of Car to look up: ")
    Dim id As Integer = Integer.Parse(Console.ReadLine())

    Console.WriteLine("Petname of {0} is {1}.", id, invDAL.LookUpPetName(id))
  End Sub
#End Region

#Region "Insert new car"
  Private Sub InsertNewCar(ByVal invDAL As InventoryDAL)
    ' First get the user data.
    Dim newCarID As Integer
    Dim newCarColor As String, newCarMake As String, newCarPetName As String

    Console.Write("Enter Car ID: ")
    newCarID = Integer.Parse(Console.ReadLine())
    Console.Write("Enter Car Color: ")
    newCarColor = Console.ReadLine()
    Console.Write("Enter Car Make: ")
    newCarMake = Console.ReadLine()
    Console.Write("Enter Pet Name: ")
    newCarPetName = Console.ReadLine()

    ' Now pass to data access library.
    invDAL.InsertAuto(newCarID, newCarColor, newCarMake, newCarPetName)
  End Sub
#End Region

End Module
