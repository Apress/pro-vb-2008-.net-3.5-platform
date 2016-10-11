Option Explicit On
Option Strict On

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Custom Generic Types *****")
    Console.WriteLine()

    ' Make a Point Integers.
    Dim intPt As New Point(Of Integer)(100, 100)
    Console.WriteLine("intPt.ToString()={0} ", intPt.ToString())
    Console.WriteLine()

    ' Point using double.
    Dim dblPt As New Point(Of Double)(5.6, 3.23)
    Console.WriteLine("dblPt.ToString()={0} ", dblPt.ToString())
    Console.WriteLine()

    ' Swap 2 Points.
    Dim p1 As New Point(Of Integer)(10, 43)
    Dim p2 As New Point(Of Integer)(6, 987)
    Console.WriteLine("Before swap: {0} , {1} ", p1, p2)

    ' Here we are swapping two points of type Integer.
    Swap(Of Point(Of Integer))(p1, p2)

    ' Could also simply write the following
    ' given type inference.
    ' Swap(p1, p2)

    Console.WriteLine("After swap: {0} , {1} ", p1, p2)
    Console.ReadLine()
  End Sub

  ' This generic method can swap any two items of type 'T'
  Public Function Swap(Of T)(ByRef a As T, ByRef b As T) As T
    Console.WriteLine("T is a {0}.", GetType(T))
    Dim temp As T
    temp = a
    a = b
    b = temp
  End Function
End Module
