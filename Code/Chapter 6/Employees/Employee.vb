''' <summary>
''' This class represents an employee.
''' </summary>
''' <remarks></remarks>
Partial Public MustInherit Class Employee

#Region "Functionality for the benefits package"
  Public Class BenefitPackage
    Public Enum BenefitPackageLevel
      Standard
      Gold
      Platinum
    End Enum
    ' Assume we have other members that represent
    ' 401K plans, dental/health benefits, and so on.
    Public Function ComputePayDeduction() As Double
      Return 125.0
    End Function
  End Class

  ' Contain a BenefitPackage object.
  Protected empBenefits As New BenefitPackage()

  ' Expose certain benefit behaviors of object.
  Public Function GetBenefitCost() As Double
    Return empBenefits.ComputePayDeduction()
  End Function
  ' Expose object through a custom property.
  Public Property Benefits() As BenefitPackage
    Get
      Return empBenefits
    End Get
    Set(ByVal value As BenefitPackage)
      empBenefits = value
    End Set
  End Property
#End Region

#Region "Members"
  ''' <summary>
  ''' This method gives a pay increase to the
  ''' employee.
  ''' </summary>
  ''' <param name="amount"></param>
  ''' <remarks></remarks>
  Public Overridable Sub GiveBonus(ByVal amount As Single)
    currPay += amount
  End Sub


  ''' <summary>
  ''' This method displays the state of the object.
  ''' </summary>
  ''' <remarks></remarks>
  Public Overridable Sub DisplayStats()
    Console.WriteLine("Name: {0}", empName)
    Console.WriteLine("Age: {0}", empAge)
    Console.WriteLine("SSN: {0}", empSSN)
    Console.WriteLine("ID: {0}", empID)
    Console.WriteLine("Pay: {0}", currPay)
  End Sub
#End Region

End Class
