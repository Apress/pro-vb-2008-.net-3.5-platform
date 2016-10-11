' This program illustrates constant data and read only fields.

#Region "MyMathClass"
Public Class MyMathClass
  Public Shared ReadOnly PI As Double
  Shared Sub New()
    PI = 3.14
  End Sub
End Class
#End Region

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Const *****")
    Console.WriteLine("The value of PI is: {0}", MyMathClass.PI)

    ' Error! Can't change a constant!
    ' MyMathClass.PI = 3.1444

    Console.ReadLine()
  End Sub

  Sub LocalConstStringVariable()
    ' A local constant data point.
    Const fixedStr As String = "Fixed String Data"
    Console.WriteLine(fixedStr)

    ' Error!
    ' fixedStr = "This will not work!"
  End Sub

End Module

