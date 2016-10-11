Imports System.Data.SqlClient
Imports System.Data.Common

Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Data Adapters *****" & vbLf)

    ' Hard-coded connection string (modify if needed).
    Dim cnStr As String = "Integrated Security = SSPI;Initial Catalog=AutoLot;" & "Data Source=(local)\SQLEXPRESS"

    ' Caller creates the DataSet object.
    Dim ds As New DataSet("AutoLot")

    ' Inform adapter of the Select command text and connection.
    Dim dAdapt As New SqlDataAdapter("Select * From Inventory", cnStr)

    ' Now map DB column names to user-friendly names. 
    Dim custMap As DataTableMapping = _
      dAdapt.TableMappings.Add("Inventory", "Current Inventory")
    custMap.ColumnMappings.Add("CarID", "Car ID")
    custMap.ColumnMappings.Add("PetName", "Name")

    ' Fill our DataSet with a new table, named Inventory.
    dAdapt.Fill(ds, "Inventory")

    ' Display contents of DataSet.
    PrintDataSet(ds)
    Console.ReadLine()
  End Sub

#Region "Print out DataSet"
  Sub PrintDataSet(ByVal ds As DataSet)
    ' Print out any name and extended properties. 
    Console.WriteLine("DataSet is named: {0}", ds.DataSetName)
    For Each de As System.Collections.DictionaryEntry In ds.ExtendedProperties
      Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value)
    Next
    Console.WriteLine()

    For Each dt As DataTable In ds.Tables
      Console.WriteLine("=> {0} Table:", dt.TableName)
      For curCol As Integer = 0 To dt.Columns.Count - 1

        ' Print out the column names.
        Console.Write(dt.Columns(curCol).ColumnName.Trim() & vbTab)
      Next
      Console.WriteLine("" & Chr(10) & "----------------------------------")
      PrintTable(dt)
    Next
  End Sub

  Sub PrintTable(ByVal dt As DataTable)
    ' Get the DataTableReader type.
    Dim dtReader As DataTableReader = dt.CreateDataReader()

    ' The DataTableReader works just like the DataReader.
    While dtReader.Read()
      For i As Integer = 0 To dtReader.FieldCount - 1
        Console.Write("{0}" & vbTab, dtReader.GetValue(i).ToString().Trim())
      Next
      Console.WriteLine()
    End While
    dtReader.Close()
  End Sub
#End Region

End Module
