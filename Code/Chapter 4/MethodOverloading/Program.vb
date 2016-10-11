'''''''''''''''''''''''''''''''''''''''''''''''
' This program illustrates the use of 
' method overloading.
'''''''''''''''''''''''''''''''''''''''''''''''
Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Method Overloading *****")
    ' Calls Integer version of Add()
    Console.WriteLine(Add(10, 10))
    ' Calls Long verson of Add()
    Console.WriteLine(Add(900000000000, 900000000000))
    ' Calls Double version of Add()
    Console.WriteLine(Add(4.3, 4.4))
  End Sub

End Module

#Region "Add() overloads"
Module MathUtils
  Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
    Return x + y
  End Function
  Function Add(ByVal x As Double, ByVal y As Double) As Double
    Return x + y
  End Function
  Function Add(ByVal x As Long, ByVal y As Long) As Long
    Return x + y
  End Function
End Module
#End Region

#Region "Just for an example..."
Class MathUtilsClass
  Overloads Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
    Return x + y
  End Function
  Overloads Function Add(ByVal x As Double, ByVal y As Double) As Double
    Return x + y
  End Function
  Overloads Function Add(ByVal x As Long, ByVal y As Long) As Long
    Return x + y
  End Function
End Class
#End Region

#Region "Uncomment to generate errors..."
'Module LotsOfErrors
'  ' Compiler error! Methods can't differ only by
'  ' ByRef/ByVal
'  Sub TestSub(ByVal a As Integer)
'  End Sub
'  Sub TestSub(ByRef a As Integer)
'  End Sub
'  Sub TestSub(ByVal a As Integer, Optional ByVal b As Integer = 0)
'  End Sub
'End Module
#End Region