Imports System.Data.SqlClient
Imports System.Data.Common

Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Data Readers *****" & vbLf)

    ' Create a connection string via the builder object.
    Dim cnStrBuilder As New SqlConnectionStringBuilder()
    cnStrBuilder.InitialCatalog = "AutoLot"
    cnStrBuilder.DataSource = "(local)\SQLEXPRESS"
    cnStrBuilder.ConnectTimeout = 30
    cnStrBuilder.IntegratedSecurity = True

    Dim cn As New SqlConnection()
    cn.ConnectionString = cnStrBuilder.ConnectionString
    cn.Open()

    ShowConnectionStatus(cn)

    ' Create a SQL command object.
    Dim strSQL As String = "Select * From Inventory;Select * from Customers"
    Dim myCommand As New SqlCommand(strSQL, cn)

    ' Obtain a data reader a la ExecuteReader().
    Dim myDataReader As SqlDataReader
    myDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)

    ' Loop over the results.
    Do
      While myDataReader.Read()
        Console.WriteLine("***** Record *****")
        For i As Integer = 0 To myDataReader.FieldCount - 1
          Console.WriteLine("{0} = {1}", myDataReader.GetName(i), myDataReader.GetValue(i).ToString().Trim())
        Next
        Console.WriteLine()
      End While
    Loop While myDataReader.NextResult()

    ' Because we specified CommandBehavior.CloseConnection, we 
    ' don't need to explicitly call Close() on the connection.
    myDataReader.Close()
    Console.ReadLine()
  End Sub

#Region "Show Cn Helper method"
  Sub ShowConnectionStatus(ByVal cn As DbConnection)
    ' Show various stats about current connection object.
    Console.WriteLine("***** Info about your connection *****")
    Console.WriteLine("Database location: {0}", cn.DataSource)
    Console.WriteLine("Database name: {0}", cn.Database)
    Console.WriteLine("Timeout: {0}", cn.ConnectionTimeout)
    Console.WriteLine("Connection state: {0}" & Chr(10), cn.State.ToString())
  End Sub
#End Region

End Module
