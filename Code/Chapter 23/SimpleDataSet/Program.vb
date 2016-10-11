Option Explicit On
Option Strict On

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Module Program

  Sub Main()
    Console.WriteLine("***** Fun with DataSets *****" & vbLf)

    ' Create the DataSet object and add a few properties.
    Dim carsInventoryDS As New DataSet("Car Inventory")

    carsInventoryDS.ExtendedProperties("TimeStamp") = DateTime.Now
    carsInventoryDS.ExtendedProperties("DataSetID") = Guid.NewGuid()
    carsInventoryDS.ExtendedProperties("Company") = "Intertech Training"

    ' Create data columns that map to the 
    ' 'real' columns in the Inventory table 
    ' of the AutoLot database.
    Dim carIDColumn As New DataColumn("CarID", GetType(Integer))
    carIDColumn.Caption = "Car ID"
    carIDColumn.ReadOnly = True
    carIDColumn.AllowDBNull = False
    carIDColumn.Unique = True
    carIDColumn.AutoIncrement = True
    carIDColumn.AutoIncrementSeed = 0
    carIDColumn.AutoIncrementStep = 1

    Dim carMakeColumn As New DataColumn("Make", GetType(String))
    Dim carColorColumn As New DataColumn("Color", GetType(String))
    Dim carPetNameColumn As New DataColumn("PetName", GetType(String))
    carPetNameColumn.Caption = "Pet Name"

    ' Now add DataColumns to a DataTable.
    Dim inventoryTable As New DataTable("Inventory")
    inventoryTable.Columns.AddRange(New DataColumn() {carIDColumn, carMakeColumn, _
                                                      carColorColumn, carPetNameColumn})

    ' Now add some rows to the Inventory Table.
    Dim carRow As DataRow = inventoryTable.NewRow()
    carRow("Make") = "BMW"
    carRow("Color") = "Black"
    carRow("PetName") = "Hamlet"
    inventoryTable.Rows.Add(carRow)

    carRow = inventoryTable.NewRow()
    ' Column 0 is the autoincremented ID field, 
    ' so start at 1.

    carRow(1) = "Saab"
    carRow(2) = "Red"
    carRow(3) = "Sea Breeze"
    inventoryTable.Rows.Add(carRow)

    ' Mark the primary key of this table.
    inventoryTable.PrimaryKey = New DataColumn() {inventoryTable.Columns(0)}

    ' Finally, add our table to the DataSet.
    carsInventoryDS.Tables.Add(inventoryTable)

    ' Now print the DataSet.
    PrintDataSet(carsInventoryDS)

    ' Save and load as XML.
    DataSetAsXml(carsInventoryDS)

    ' Save and load as binary.
    DataSetAsBinary(carsInventoryDS)

    ' Uncomment to test.
    ManipulateDataRowState()
    Console.ReadLine()
  End Sub

#Region "DataSet as XML"
  Private Sub DataSetAsXml(ByVal carsInventoryDS As DataSet)
    ' Save this DataSet as XML.
    carsInventoryDS.WriteXml("carsDataSet.xml")
    carsInventoryDS.WriteXmlSchema("carsDataSet.xsd")

    ' Clear out DataSet.
    carsInventoryDS.Clear()

    ' Load DataSet from XML file.
    carsInventoryDS.ReadXml("carsDataSet.xml")
  End Sub
#End Region

#Region "DataSet as Binary"
  Private Sub DataSetAsBinary(ByVal carsInventoryDS As DataSet)
    ' Set binary serialization flag.
    carsInventoryDS.RemotingFormat = SerializationFormat.Binary

    ' Save this DataSet as binary.
    Dim fs As New FileStream("BinaryCars.bin", FileMode.Create)
    Dim bFormat As New BinaryFormatter()
    bFormat.Serialize(fs, carsInventoryDS)
    fs.Close()

    ' Clear out DataSet.
    carsInventoryDS.Clear()

    ' Load DataSet from binary file.
    fs = New FileStream("BinaryCars.bin", FileMode.Open)
    Dim data As DataSet = DirectCast(bFormat.Deserialize(fs), DataSet)
  End Sub
#End Region

#Region "DataRowState manipulation test"
  Private Sub ManipulateDataRowState()
    Console.WriteLine(vbLf & vbLf & "***** Fun with RowState *****" & vbLf)
    ' Create a temp DataTable for testing.
    Dim temp As New DataTable("Temp")
    temp.Columns.Add(New DataColumn("TempColumn", GetType(Integer)))

    ' RowState = Detatched. 
    Dim row As DataRow = temp.NewRow()
    Console.WriteLine("After calling NewRow(): {0}", row.RowState)

    ' RowState = Added.
    temp.Rows.Add(row)
    Console.WriteLine("After calling Rows.Add(): {0}", row.RowState)

    ' RowState = Added.
    row("TempColumn") = 10
    Console.WriteLine("After first assignment: {0}", row.RowState)

    ' RowState = Unchanged.
    temp.AcceptChanges()
    Console.WriteLine("After calling AcceptChanges: {0}", row.RowState)

    ' RowState = Modified.
    row("TempColumn") = 11
    Console.WriteLine("After second assignment: {0}", row.RowState)

    ' RowState = Deleted.
    temp.Rows(0).Delete()
    Console.WriteLine("After calling Delete: {0}", row.RowState)
  End Sub
#End Region

#Region "Print out DataSet"
  Private Sub PrintDataSet(ByVal ds As DataSet)
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
        Console.Write(dt.Columns(curCol).ColumnName + "" & vbTab)
      Next
      Console.WriteLine("" & vbLf & "----------------------------------")
      PrintTable(dt)
    Next
  End Sub
#End Region

#Region "Print out DataTable using DataTableReader"
  Private Sub PrintTable(ByVal dt As DataTable)
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
