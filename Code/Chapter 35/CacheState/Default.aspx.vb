Option Explicit On
Option Strict On

Imports System.Data
Imports AutoLotConnectedLayer

Partial Class _Default
  Inherits System.Web.UI.Page
  Private cnStr As String = "Data Source=(local)\SQLEXPRESS;Initial Catalog=AutoLot;Integrated Security=True"

  Protected Sub btnAddCar_Click(ByVal sender As Object, _
                                ByVal e As EventArgs) Handles btnAddCar.Click
    ' Update the Inventory table
    ' and call RefreshGrid().
    Dim dal As New InventoryDAL()
    dal.OpenConnection(cnStr)

    dal.InsertAuto(Integer.Parse(txtCarID.Text), txtCarColor.Text, _
                   txtCarMake.Text, txtCarPetName.Text)
    dal.CloseConnection()
    RefreshGrid()
  End Sub

  Private Sub RefreshGrid()
    ' Populate grid.
    Dim dal As New InventoryDAL()
    dal.OpenConnection(cnStr)
    Dim theCars As DataTable = dal.GetAllInventory()
    carsGridView.DataSource = theCars
    carsGridView.DataBind()
    dal.CloseConnection()
  End Sub

  Protected Sub Page_Load(ByVal sender As Object, _
  ByVal e As System.EventArgs) Handles Me.Load
    carsGridView.DataSource = CType(Cache("AppDataTable"), DataTable)
    carsGridView.DataBind()
  End Sub
End Class
