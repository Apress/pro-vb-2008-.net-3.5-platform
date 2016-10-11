' Add the following import.
Imports AutoLotConnectedLayer
Imports System.Windows.Forms

Public Class CreditCheckWF
  Inherits SequentialWorkflowActivity

  ' ID of customer to check.
  Private custID As Integer
  Public Property ID() As Integer
    Get
      Return custID
    End Get
    Set(ByVal value As Integer)
      custID = value
    End Set
  End Property

  Private checkOK As Boolean
  Public Property CreditOK() As Boolean
    Get
      Return checkOK
    End Get
    Set(ByVal value As Boolean)
      checkOK = value
    End Set
  End Property

  Private Sub ValidateCredit(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ' Pretend that we have preformed some exotic
    ' credit validation here...
    Dim r As New Random()
    Dim value As Integer = r.Next(500)
    If value > 300 Then
      CreditOK = True
    Else
      CreditOK = False
    End If
  End Sub

  Private Sub ProcessCreditRisk(ByVal sender As System.Object, _
    ByVal e As System.EventArgs)
    ' Ideally we would store the connection string externally.
    Dim dal As New InventoryDAL()
    dal.OpenConnection( _
     "Data Source=(local)\SQLEXPRESS;Integrated Security=SSPI;" & _
     "Initial Catalog=AutoLot")
    Try
      dal.ProcessCreditRisk(False, ID)
    Finally
      dal.CloseConnection()
    End Try
  End Sub

  Private Sub PurchaseCar(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ' Here, we will opt for simplicity. However, we could easily update
    ' AutoLotDAL.dll with a new method to place a new order within the Orders table.
    MessageBox.Show("Your credit has been approved!")
  End Sub

  Private Sub CreditDenied(ByVal sender As System.Object, ByVal e As System.EventArgs)
    MessageBox.Show("You are a CREDIT RISK!", _
  "Order Denied!")
  End Sub
End Class
