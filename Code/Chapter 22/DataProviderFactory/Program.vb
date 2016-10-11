Imports System.Configuration
Imports System.Data.Common

Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Data Provider Factories *****" & vbLf)
    Dim dp As String = _
      ConfigurationManager.AppSettings("provider")
    Dim cnStr As String = _
      ConfigurationManager.ConnectionStrings("AutoLotSqlProvider").ConnectionString


    ' Get the factory provider.
    Dim df As DbProviderFactory = DbProviderFactories.GetFactory(dp)

    ' Now make connection object.
    Dim cn As DbConnection = df.CreateConnection()
    Console.WriteLine("Your connection object is a: {0}", cn.GetType().FullName)
    cn.ConnectionString = cnStr
    cn.Open()

    ' Make command object.
    Dim cmd As DbCommand = df.CreateCommand()
    Console.WriteLine("Your command object is a: {0}", cmd.GetType().FullName)
    cmd.Connection = cn
    cmd.CommandText = "Select * From Inventory"

    ' Print out data with data reader.
    ' Because we specified CommandBehavior.CloseConnection, we 
    ' don't need to explicitly call Close() on the connection.
    Dim dr As DbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
    Console.WriteLine("Your data reader object is a: {0}", dr.GetType().FullName)

    Console.WriteLine(vbLf & "***** Current Inventory *****")
    While dr.Read()
      Console.WriteLine("-> Car #{0} is a {1}.", dr("CarID"), dr("Make").ToString().Trim())
    End While
    dr.Close()

    Console.ReadLine()
  End Sub

End Module
