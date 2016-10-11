Imports System.Runtime.CompilerServices

Module Program
  Sub Main()
    Console.WriteLine("***** Extending an interface *****")

    ' Call IBasicMath members from MyCalc object.
    Dim c As New MyCalc()
    Console.WriteLine("1 + 2 = {0}", c.Add(1, 2))
    Console.WriteLine("1 - 2 = {0}", c.Subtract(1, 2))
    Console.ReadLine()
  End Sub
End Module

' Define a normal CLR interface in VB.
Interface IBasicMath
  Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
End Interface

' Implementation of IBasicMath.
Class MyCalc
  Implements IBasicMath
  Public Function Add(ByVal x As Integer, _
    ByVal y As Integer) As Integer Implements IBasicMath.Add
    Return x + y
  End Function
End Class

Module MathExtensions
  ' Extend IBasicMath with this method and this
  ' implementation.
  <Extension()> _
  Public Function Subtract(ByVal itf As IBasicMath, _
    ByVal x As Integer, ByVal y As Integer) As Integer
    Return x - y
  End Function
End Module
