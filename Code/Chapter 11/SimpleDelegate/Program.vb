Option Explicit On
Option Strict On

' Our delegate type can point to any method
' taking two integers and returning an integer. 
Public Delegate Function BinaryOp(ByVal x As Integer, ByVal y As Integer) As Integer

#Region "SimpleMath type"
' This class defines the methods which will be 'pointed to' by the delegate.
Public Class SimpleMath
  Public Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
    Return x + y
  End Function
  Public Function Subtract(ByVal x As Integer, ByVal y As Integer) As Integer
    Return x - y
  End Function
  Public Function SquareNumber(ByVal a As Integer) As Integer
    Return a * a
  End Function
End Class
#End Region

Module Program
  Sub Main()
    Console.WriteLine("***** Simple Delegate Example *****" & vbLf)

    Dim myMath As New SimpleMath()

    ' Make a delegate object and add a method to the invocation
    ' list using the AddressOf keyword.
    Dim b As BinaryOp = New BinaryOp(AddressOf myMath.Add)

    ' Invoke the method 'pointed to'
    Console.WriteLine("10 + 10 is {0} ", b.Invoke(10, 10))
    DisplayDelegateInfo(b)

    ' This is a compiler error!
    ' Dim b2 As BinaryOp = New BinaryOp(AddressOf myMath.SquareNumber)

    Console.ReadLine()
  End Sub

  Sub DisplayDelegateInfo(ByVal delObj As System.Delegate)
    For Each d As System.Delegate In delObj.GetInvocationList()
      Console.WriteLine("Method Name: {0} ", d.Method)
      Console.WriteLine("Type Name: {0} ", d.Target)
    Next
  End Sub
End Module
