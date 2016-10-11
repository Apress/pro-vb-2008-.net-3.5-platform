' Salespeople need to know their number of sales.
Public Class SalesPerson
  Inherits Employee
  Private numberOfSales As Integer
  Public Property SalesNumber() As Integer
    Get
      Return numberOfSales
    End Get
    Set(ByVal value As Integer)
      numberOfSales = value
    End Set
  End Property

#Region "Constructors"
  Public Sub New()
  End Sub

  ' As a general rule, all subclasses should explicitly call an appropriate
  ' base class constructor.
  Public Sub New(ByVal fullName As String, ByVal empAge As Integer, _
    ByVal empID As Integer, ByVal currPay As Single, _
    ByVal ssn As String, ByVal numbOfSales As Integer)
    ' Pass these arguments to the parent's constructor.
    MyBase.New(fullName, empAge, empID, currPay, ssn)

    ' This belongs with us!
    numberOfSales = numbOfSales
  End Sub
#End Region

  ' A salesperson's bonus is influenced by the number of sales.
  Public NotOverridable Overrides Sub GiveBonus(ByVal amount As Single)
    Dim salesBonus As Integer = 0
    If numberOfSales >= 0 AndAlso numberOfSales <= 100 Then
      salesBonus = 10
    Else
      If numberOfSales >= 101 AndAlso numberOfSales <= 200 Then
        salesBonus = 15
      Else
        salesBonus = 20
      End If
    End If
    MyBase.GiveBonus(amount * salesBonus)
  End Sub

  Public Overrides Sub DisplayStats()
    MyBase.DisplayStats()
    Console.WriteLine("Number of Sales: {0}", numberOfSales)
  End Sub

End Class

