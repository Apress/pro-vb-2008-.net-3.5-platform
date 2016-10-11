Option Strict On
Option Explicit On

' We will make use of the SQL server
' provider, however it would also be
' permissible to make use of the ADO.NET
' factory pattern for greater flexibility.
Imports System.Data.SqlClient

Namespace AutoLotConnectedLayer
  Public Class InventoryDAL

#Region "Connection and Disconnection details."
    ' This member will be used by all methods.
    Private sqlCn As New SqlConnection()

    Public Sub OpenConnection(ByVal connectionString As String)
      sqlCn.ConnectionString = connectionString
      sqlCn.Open()
    End Sub
    Public Sub CloseConnection()
      sqlCn.Close()
    End Sub
#End Region

#Region "Insert logic (both versions)"
    'Public Sub InsertAuto(ByVal id As Integer, ByVal color As String, _
    '                      ByVal make As String, ByVal petName As String)
    '  ' Format and execute SQL statement.
    '  Dim sql As String = String.Format("Insert Into Inventory" & _
    '                                    "(CarID, Make, Color, PetName) Values" & _
    '                                    "('{0}', '{1}', '{2}', '{3}')", id, make, color, petName)

    '  ' Execute using our connection.
    '  Using cmd As New SqlCommand(sql, Me.sqlCn)
    '    cmd.ExecuteNonQuery()
    '  End Using
    'End Sub

    Public Sub InsertAuto(ByVal id As Integer, ByVal color As String, ByVal make As String, ByVal petName As String)
      ' Note the 'placeholders' in the SQL query.
      Dim sql As String = String.Format("Insert Into Inventory" + "(CarID, Make, Color, PetName) Values" + "(@CarID, @Make, @Color, @PetName)")

      ' This command will have internal parameters.
      Using cmd As New SqlCommand(sql, Me.sqlCn)
        ' Fill params collection.
        Dim param As New SqlParameter()
        param.ParameterName = "@CarID"
        param.Value = id
        param.SqlDbType = SqlDbType.Int
        cmd.Parameters.Add(param)

        param = New SqlParameter()
        param.ParameterName = "@Make"
        param.Value = make
        param.SqlDbType = SqlDbType.[Char]
        param.Size = 10
        cmd.Parameters.Add(param)

        param = New SqlParameter()
        param.ParameterName = "@Color"
        param.Value = color
        param.SqlDbType = SqlDbType.[Char]
        param.Size = 10
        cmd.Parameters.Add(param)

        param = New SqlParameter()
        param.ParameterName = "@PetName"
        param.Value = petName
        param.SqlDbType = SqlDbType.[Char]
        param.Size = 10
        cmd.Parameters.Add(param)

        cmd.ExecuteNonQuery()
      End Using
    End Sub
#End Region

#Region "Delete logic"
    Public Sub DeleteCar(ByVal id As Integer)
      ' Get ID of car to delete, then do so.
      Dim sql As String = String.Format("Delete from Inventory where CarID = '{0}'", id)
      Using cmd As New SqlCommand(sql, Me.sqlCn)
        Try
          cmd.ExecuteNonQuery()
        Catch ex As SqlException
          Dim er As New Exception("Sorry!  That car is on order!", ex)
          Throw er
        End Try
      End Using
    End Sub
#End Region

#Region "Update logic"
    Public Sub UpdateCarPetName(ByVal id As Integer, ByVal newPetName As String)
      ' Get ID of car to modify and new pet name.
      Dim sql As String = String.Format("Update Inventory Set PetName = '{0}' Where CarID = '{1}'", newPetName, id)
      Using cmd As New SqlCommand(sql, Me.sqlCn)
        cmd.ExecuteNonQuery()
      End Using
    End Sub
#End Region

#Region "Select logic"
    Public Function GetAllInventory() As DataTable
      ' This will hold the records. 
      Dim inv As New DataTable()

      ' Prep command object.
      Dim sql As String = "Select * From Inventory"
      Using cmd As New SqlCommand(sql, Me.sqlCn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        ' Fill the DataTable with data from the reader and clean up.
        inv.Load(dr)
        dr.Close()
      End Using
      Return inv
    End Function
#End Region

#Region "Trigger stored proc logic"
    Public Function LookUpPetName(ByVal carID As Integer) As String
      Dim carPetName As String = String.Empty

      ' Establish name of stored proc.
      Using cmd As New SqlCommand("GetPetName", Me.sqlCn)
        cmd.CommandType = CommandType.StoredProcedure

        ' Input param.
        Dim param As New SqlParameter()
        param.ParameterName = "@carID"
        param.SqlDbType = SqlDbType.Int
        param.Value = carID
        param.Direction = ParameterDirection.Input
        cmd.Parameters.Add(param)

        ' Output param.
        param = New SqlParameter()
        param.ParameterName = "@petName"
        param.SqlDbType = SqlDbType.[Char]
        param.Size = 10
        param.Direction = ParameterDirection.Output
        cmd.Parameters.Add(param)

        ' Execute the stored proc.
        cmd.ExecuteNonQuery()

        ' Return output param.
        carPetName = DirectCast(cmd.Parameters("@petName").Value, String).Trim()
      End Using
      Return carPetName
    End Function
#End Region

#Region "Tx Method"
    ' A new member of the InventoryDAL class.
    Public Sub ProcessCreditRisk(ByVal throwEx As Boolean, ByVal custID As Integer)
      ' First, look up current name based on customer ID.
      Dim fName As String = String.Empty
      Dim lName As String = String.Empty

      Dim cmdSelect As New SqlCommand(String.Format("Select * from Customers where CustID = {0}", custID), sqlCn)
      Using dr As SqlDataReader = cmdSelect.ExecuteReader()
        While dr.Read()
          fName = DirectCast(dr("FirstName"), String)
          lName = DirectCast(dr("LastName"), String)
        End While
      End Using

      ' Create command objects which represent each step of the operation.
      Dim cmdRemove As New SqlCommand(String.Format("Delete from Customers where CustID = {0}", custID), sqlCn)

      Dim cmdInsert As New SqlCommand(String.Format("Insert Into CreditRisks" & _
                                                    "(CustID, FirstName, LastName) Values" & _
                                                    "({0}, '{1}', '{2}')", custID, fName, lName), sqlCn)

      ' We will get this from the Connection object.
      Dim tx As SqlTransaction = Nothing
      Try
        tx = sqlCn.BeginTransaction()

        ' Enlist the commands into this transaction.
        cmdInsert.Transaction = tx
        cmdRemove.Transaction = tx

        ' Execute the commands.
        cmdInsert.ExecuteNonQuery()
        cmdRemove.ExecuteNonQuery()

        ' Simulate error.
        If throwEx Then
          Throw New ApplicationException("Sorry!  Database error! Tx failed...")
        End If

        ' Commit it!
        tx.Commit()
      Catch ex As Exception
        Console.WriteLine(ex.Message)
        ' Any error will rollback transaction.
        tx.Rollback()
      End Try
    End Sub
#End Region

  End Class
End Namespace
