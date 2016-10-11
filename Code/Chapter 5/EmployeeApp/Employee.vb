''' <summary>
''' This is the Employee class
''' </summary>
''' <remarks></remarks>
Partial Public Class Employee

#Region "Members"
  ''' <summary>
  ''' This method gives a pay increase to the
  ''' employee.
  ''' </summary>
  ''' <param name="amount"></param>
  ''' <remarks></remarks>
  Public Sub GiveBonus(ByVal amount As Single)
    currPay += amount
  End Sub

  ''' <summary>
  ''' This method displays the state of the object.
  ''' </summary>
  ''' <remarks></remarks>
  Public Sub DisplayStats()
    Console.WriteLine("Name: {0}", empName)
    Console.WriteLine("Age: {0}", empAge)
    Console.WriteLine("SSN: {0}", empSSN)
    Console.WriteLine("ID: {0}", empID)
    Console.WriteLine("Pay: {0}", currPay)
  End Sub
#End Region

End Class
