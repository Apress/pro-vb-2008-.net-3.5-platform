' Need these to get definitions of common interfaces,
' and various Connection objects for our test.
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports System.Data.OleDb

' Need to reference System.Data.OracleClient.dll to nab this namespace!
Imports System.Data.OracleClient
Imports System.Configuration

' A list of possible providers.
Enum DataProvider
  SqlServer
  OleDb
  Odbc
  Oracle
  None
End Enum

Module Program

  Sub Main()
    Console.WriteLine("**** Very Simple Connection Factory *****" & vbLf)

    ' Read the provider key.
    Dim dataProvString As String = ConfigurationManager.AppSettings("provider")

    ' Transform string to enum.
    Dim dp As DataProvider = DataProvider.None
    If [Enum].IsDefined(GetType(DataProvider), dataProvString) Then
      dp = DirectCast([Enum].Parse(GetType(DataProvider), dataProvString), DataProvider)
    Else
      Console.WriteLine("Sorry, no provider exists!")
    End If

    ' Get a specific connection.
    Dim myCn As IDbConnection = GetConnection(dp)
    If myCn IsNot Nothing Then
      Console.WriteLine("Your connection is a {0}", myCn.GetType().Name)
    End If

    ' Open, use, and close connection.
    Console.ReadLine()
  End Sub

#Region "GetConnection() helper method"
  ' This method returns a specific connection object
  ' based on the value of a DataProvider enum.
  Private Function GetConnection(ByVal dp As DataProvider) As IDbConnection
    Dim conn As IDbConnection = Nothing
    Select Case dp
      Case DataProvider.SqlServer
        conn = New SqlConnection()
        Exit Select
      Case DataProvider.OleDb
        conn = New OleDbConnection()
        Exit Select
      Case DataProvider.Odbc
        conn = New OdbcConnection()
        Exit Select
      Case DataProvider.Oracle
        conn = New OracleConnection()
        Exit Select
    End Select
    Return conn
  End Function
#End Region
End Module
