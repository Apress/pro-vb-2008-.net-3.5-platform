' Managers need to know their number of stock options.
Public Class Manager
  Inherits Employee
  Private numberOfOptions As Integer
  Public Property StockOptions() As Integer
    Get
      Return numberOfOptions
    End Get
    Set(ByVal value As Integer)
      numberOfOptions = value
    End Set
  End Property

#Region "Constructors"
  Public Sub New()
  End Sub
  ' This time, use the VB 2005 "MyBase" keyword to call a custom
  ' constructor on the base class.
  Public Sub New(ByVal fullName As String, ByVal empAge As Integer, _
    ByVal empID As Integer, ByVal currPay As Single, _
    ByVal ssn As String, ByVal numbOfOpts As Integer)
    ' Pass these arguments to the parent's constructor.
    MyBase.New(fullName, empAge, empID, currPay, ssn)

    ' This belongs with us!
    numberOfOptions = numbOfOpts
  End Sub
#End Region

  Public Overrides Sub GiveBonus(ByVal amount As Single)
    MyBase.GiveBonus(amount)
    Dim r As New Random()
    numberOfOptions += r.Next(500)
  End Sub

  Public Overrides Sub DisplayStats()
    MyBase.DisplayStats()
    Console.WriteLine("Number of Stock Options: {0}", numberOfOptions)
  End Sub
End Class
