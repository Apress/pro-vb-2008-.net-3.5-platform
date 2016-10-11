Option Explicit On
Option Strict On

#Region "Non-generic members"
Module NonGenericMethods
  Public Function Swap(ByRef a As Integer, ByRef b As Integer) As Integer
    Dim temp As Integer
    temp = a
    a = b
    b = temp
  End Function
  Public Function Swap(ByRef a As Double, ByRef b As Double) As Double
    Dim temp As Double
    temp = a
    a = b
    b = temp
  End Function
End Module
#End Region

Module Program

#Region "Generic methods"
  ' This generic method can swap any two items of type 'T'.
  Public Function Swap(Of T)(ByRef a As T, ByRef b As T) As T
    Console.WriteLine("T is a {0}.", GetType(T))
    Dim temp As T
    temp = a
    a = b
    b = temp
  End Function

  ' Display the base class of 'T'.
  Sub DisplayBaseClass(Of T)()
    Console.WriteLine("Base class of {0} is: {1}.", _
      GetType(T), GetType(T).BaseType)
  End Sub
#End Region

  Sub Main()
    Console.WriteLine("***** Fun with Generic Methods *****" & vbLf)

    ' Swap two Integers.
    Dim a, b As Integer
    a = 10 : b = 40
    Console.WriteLine("Before swap: a={0}, b={1}", a, b)
    Swap(Of Integer)(a, b)
    Console.WriteLine("After swap: a={0}, b={1}", a, b)
    Console.WriteLine()

    ' Swap two Strings.
    Dim s1, s2 As String
    s1 = "Generics" : s2 = "Rock"
    Console.WriteLine("Before swap: s1={0}, s2={1}", s1, s2)
    Swap(Of String)(s1, s2)
    Console.WriteLine("After swap: s1={0}, s2={1}", s1, s2)
    Console.WriteLine()

    ' Compiler will infer System.Boolean.
    Dim b1, b2 As Boolean
    b1 = True : b2 = False
    Console.WriteLine("Before swap: b1={0}, b2={1}", b1, b2)
    Swap(b1, b2)
    Console.WriteLine("Before swap: b1={0}, b2={1}", b1, b2)
    Console.WriteLine()

    ' Must specify 'T' when a generic 
    ' method takes no parameters. 
    DisplayBaseClass(Of Boolean)()
    DisplayBaseClass(Of String)()
    DisplayBaseClass(Of Integer)()
    Console.ReadLine()
  End Sub
End Module
