Imports System.Data.SqlClient
Imports System.Configuration

Imports AutoLotDataSetTableAdapters
Imports AutoLotDataSet

Public Class MainForm
  ' Form wide strongly typed DataSet.
  Private autoLotDS As New AutoLotDataSet()

  ' Custom data adapters (for each table).
  Private invTableAdapter As InventoryTableAdapter
  Private custTableAdapter As CustomersTableAdapter
  Private ordersTableAdapter As OrdersTableAdapter


#Region "Ctor logic"
  Public Sub New()
    InitializeComponent()

    ' Get Adapters.
    invTableAdapter = New InventoryTableAdapter()
    custTableAdapter = New CustomersTableAdapter()
    ordersTableAdapter = New OrdersTableAdapter()

    ' Add tables to DS.
    invTableAdapter.Fill(autoLotDS.Inventory)
    custTableAdapter.Fill(autoLotDS.Customers)
    ordersTableAdapter.Fill(autoLotDS.Orders)

    ' Bind to grids
    dataGridViewInventory.DataSource = autoLotDS.Tables("Inventory")
    dataGridViewCustomers.DataSource = autoLotDS.Tables("Customers")
    dataGridViewOrders.DataSource = autoLotDS.Tables("Orders")
  End Sub
#End Region

#Region "Button Click handlers"
  Private Sub btnUpdateDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateDatabase.Click
    Try
      invTableAdapter.Update(autoLotDS.Inventory)
      custTableAdapter.Update(autoLotDS.Customers)
      ordersTableAdapter.Update(autoLotDS.Orders)
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
    drsOrder = drsCust(0).GetChildRows(autoLotDS.Relations("FK_Orders_Customers"))

    ' Get order number.
    For Each r As DataRow In drsOrder
      strOrderInfo += String.Format("Order Number: {0}" & Chr(10), r("OrderID"))
    Next

    ' Now navigate from order table to inventory table.
    Dim drsInv As DataRow() = _
      drsOrder(0).GetParentRows(autoLotDS.Relations("FK_Orders_Inventory"))

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
