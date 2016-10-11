Option Explicit On
Option Strict On

Public Class Car
End Class

Module Program
  Sub Main()
    Console.WriteLine("***** This example does not do much beyond showing *****")
    Console.WriteLine("*****        how to declare a generic type         *****")
    Console.WriteLine()

    ' A list of Cars.
    Dim myCars As New List(Of Car)
    myCars.Add(New Car())
    Console.WriteLine("myCars contains {0} items", _
    myCars.Count)

    ' A list of Integers.
    Dim MyInts As New List(Of Integer)
    MyInts.Add(50)
    ' No unboxing!
    Dim val As Integer = MyInts.Count
    Console.WriteLine("myInts contains {0} items", MyInts.Count)
    Console.ReadLine()
  End Sub
End Module

