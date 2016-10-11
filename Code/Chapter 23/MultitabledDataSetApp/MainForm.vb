Imports System.Data.SqlClient
Imports System.Configuration

Public Class MainForm
  ' Form wide DataSet.
  Private autoLotDS As New DataSet("AutoLot")

  ' Make use of command builders to simplify data adapter configuration.
  Private sqlCBInventory As SqlCommandBuilder
  Private sqlCBCustomers As SqlCommandBuilder
  Private sqlCBOrders As SqlCommandBuilder

  ' Our data adapters (for each table).
  Private invTableAdapter As SqlDataAdapter
  Private custTableAdapter As SqlDataAdapter
  Private ordersTableAdapter As SqlDataAdapter

  ' Form wide connection string.
  Private cnStr As String = String.Empty


#Region "Ctor logic"
  Public Sub New()
    InitializeComponent()

    ' Get connection string.
    cnStr = ConfigurationManager.ConnectionStrings("AutoLotSqlProvider").ConnectionString

    ' Create adapters.
    invTableAdapter = New SqlDataAdapter("Select * from Inventory", cnStr)
    custTableAdapter = New SqlDataAdapter("Select * from Customers", cnStr)
    ordersTableAdapter = New SqlDataAdapter("Select * from Orders", cnStr)

    ' Autogenerate commands.
    sqlCBInventory = New SqlCommandBuilder(invTableAdapter)
    sqlCBOrders = New SqlCommandBuilder(ordersTableAdapter)
    sqlCBCustomers = New SqlCommandBuilder(custTableAdapter)

    ' Add tables to DS.
    invTableAdapter.Fill(autoLotDS, "Inventory")
    custTableAdapter.Fill(autoLotDS, "Customers")
    ordersTableAdapter.Fill(autoLotDS, "Orders")

    ' Build relations between tables.
    BuildTableRelationship()

    ' Bind to grids
    dataGridViewInventory.DataSource = autoLotDS.Tables("Inventory")
    dataGridViewCustomers.DataSource = autoLotDS.Tables("Customers")
    dataGridViewOrders.DataSource = autoLotDS.Tables("Orders")
  End Sub
#End Region

#Region "Build table relationships"
  Private Sub BuildTableRelationship()
    ' Create CustomerOrder data relation object.
    Dim dr As New DataRelation("CustomerOrder", _
                               autoLotDS.Tables("Customers").Columns("CustID"), _
                               autoLotDS.Tables("Orders").Columns("CustID"))
    autoLotDS.Relations.Add(dr)

    ' Create InventoryOrder data relation object.
    dr = New DataRelation("InventoryOrder", _
                          autoLotDS.Tables("Inventory").Columns("CarID"), _
                          autoLotDS.Tables("Orders").Columns("CarID"))
    autoLotDS.Relations.Add(dr)
  End Sub
#End Region

#Region "Button Click handlers"
  Private Sub btnUpdateDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateDatabase.Click
    Try
      invTableAdapter.Update(autoLotDS, "Inventory")
      custTableAdapter.Update(autoLotDS, "Customers")
      ordersTableAdapter.Update(autoLotDS, "Orders")
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub btnGetOrderInfo_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnGetOrderInfo.Click
    Dim strOrderInfo As String = String.Empty
    Dim drsCust As DataRow() = Nothing
    Dim drsOrder As DataRow() = Nothing

    ' Get the customer ID in the text box.
    Dim custID As Integer = Integer.Parse(Me.txtCustID.Text)

    ' Now based on custID, get the correct row in Customers table.
    drsCust = autoLotDS.Tables("Customers").Select( _
      String.Format("CustID = {0}", custID))
    strOrderInfo += String.Format("Customer {0}: {1} {2}" & Chr(10), _
      drsCust(0)("CustID").ToString(), _
      drsCust(0)("FirstName").ToString().Trim(), _
      drsCust(0)("LastName").ToString().Trim())

    ' Navigate from customer table to order table.
    drsOrder = drsCust(0).GetChildRows(autoLotDS.Relations("CustomerOrder"))

    ' Get order number.
    For Each r As DataRow In drsOrder
      strOrderInfo += String.Format("Order Number: {0}" & Chr(10), r("OrderID"))
    Next

    ' Now navigate from order table to inventory table.
    Dim drsInv As DataRow() = _
      drsOrder(0).GetParentRows(autoLotDS.Relations("InventoryOrder"))

    ' Get Car info.
    For Each r As DataRow In drsInv
      strOrderInfo += String.Format("Make: {0}" & Chr(10), r("Make"))
      strOrderInfo += String.Format("Color: {0}" & Chr(10), r("Color"))
      strOrderInfo += String.Format("Pet Name: {0}" & Chr(10), r("PetName"))
    Next
    MessageBox.Show(strOrderInfo, "Order Details")
  End Sub
#End Region

End Class
