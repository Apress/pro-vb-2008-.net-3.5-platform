' VB
Option Strict On

Public Delegate Function BinaryOp(ByVal x As Integer, ByVal y As Integer) As Integer

#Region "Simple Math"
Public Class SimpleMath
  Public Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
    Return x + y
  End Function
  Public Function Subtract(ByVal x As Integer, _
    ByVal y As Integer) As Integer
    Return x - y
  End Function
End Class
#End Region

Module Program
  Sub Main()
    Console.WriteLine("***** Lambdas with Multiple Params! *****")

    ' Register w/ delegate as a lambda expression. 
    Dim b As New BinaryOp(Function(x, y) x + y)

    ' What method is b pointing to?
    DisplayDelegateInfo(b)

    Console.WriteLine(b(10, 10))
    Console.ReadLine()
  End Sub

  Sub DisplayDelegateInfo(ByVal delObj As System.Delegate)
    For Each d As System.Delegate In delObj.GetInvocationList()
      Console.WriteLine("Method Name: {0}", d.Method)
      Console.WriteLine("Type Name: {0}", d.Target)
    Next
  End Sub
End Module


