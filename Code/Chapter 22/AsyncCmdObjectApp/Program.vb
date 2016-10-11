Imports System.Data.SqlClient
Imports System.Threading

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with ASNYC Data Readers *****" & vbLf)

    ' Create and open a connection that is async-aware.
    Dim cn As New SqlConnection()
    cn.ConnectionString = "Data Source=(local)\SQLEXPRESS" & _
    ";Integrated Security=SSPI;" & _
    "Initial Catalog=AutoLot;Asynchronous Processing=true"
    cn.Open()

    ' Create a SQL command object that waits for approx 2 seconds.
    Dim strSQL As String = "WaitFor Delay '00:00:02';Select * From Inventory"
    Dim myCommand As New SqlCommand(strSQL, cn)

    ' Execute the reader on a second thread. 
    Dim itfAsynch As IAsyncResult
    itfAsynch = myCommand.BeginExecuteReader(CommandBehavior.CloseConnection)

    ' Do something while other thread works. 
    While Not itfAsynch.IsCompleted
      Console.WriteLine("Working on main thread...")
      Thread.Sleep(1000)
    End While
    Console.WriteLine()

    ' All done! Get reader and loop over results. 
    Dim myDataReader As SqlDataReader = myCommand.EndExecuteReader(itfAsynch)
    While myDataReader.Read()
      Console.WriteLine("-> Make: {0}, PetName: {1}, Color: {2}.", _
                        myDataReader("Make").ToString().Trim(), _
                        myDataReader("PetName").ToString().Trim(), _
                        myDataReader("Color").ToString().Trim())
    End While
    myDataReader.Close()
  End Sub
End Module
