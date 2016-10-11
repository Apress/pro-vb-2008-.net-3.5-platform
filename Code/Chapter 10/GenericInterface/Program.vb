Option Explicit On
Option Strict On

#Region "Generic interface and implementation class"
Public Interface IBasicMath(Of T)
  Function Add(ByVal a As T, ByVal b As T) As T
  Function Subtract(ByVal a As T, ByVal b As T) As T
  Function Multiply(ByVal a As T, ByVal b As T) As T
  Function Divide(ByVal a As T, ByVal b As T) As T
End Interface

Public Class BasicMath
  Implements IBasicMath(Of Integer)

  Public Function Add(ByVal a As Integer, ByVal b As Integer) _
    As Integer Implements IBasicMath(Of Integer).Add
    Return a + b
  End Function

  Public Function Divide(ByVal a As Integer, ByVal b As Integer) _
    As Integer Implements IBasicMath(Of Integer).Divide
    Return CInt(a / b)
  End Function

  Public Function Multiply(ByVal a As Integer, ByVal b As Integer) _
    As Integer Implements IBasicMath(Of Integer).Multiply
    Return a * b
  End Function

  Public Function Subtract(ByVal a As Integer, ByVal b As Integer) _
    As Integer Implements IBasicMath(Of Integer).Subtract
    Return a - b
  End Function
End Class
#End Region

Module Program
  Sub Main()
    Console.WriteLine("***** Generic Interfaces *****")
    Dim m As New BasicMath()
    Console.WriteLine("1 + 1 = {0} ", m.Add(1, 1))
    Console.ReadLine()
  End Sub
End Module
