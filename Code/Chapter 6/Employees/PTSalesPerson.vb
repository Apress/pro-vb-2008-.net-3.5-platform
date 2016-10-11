Public NotInheritable Class PTSalesPerson
  Inherits SalesPerson

  Public Sub New(ByVal fullName As String, ByVal empAge As Integer, _
      ByVal empID As Integer, ByVal currPay As Single, _
      ByVal ssn As String, ByVal numbOfSales As Integer)
    ' Pass these arguments to the parent's constructor.
    MyBase.New(fullName, empAge, empID, currPay, ssn, numbOfSales)
  End Sub
  ' Assume other members here...
End Class
