' VB
Option Strict On

Public Delegate Function GetTime() As String

Module Test
  Sub LambdaNoArgs()
    Console.WriteLine("***** Lambdas with No Params! *****" + vbLf)

    ' Register w/ delegate as a lambda expression. 
    Dim t As New GetTime(Function() DateTime.Now.ToString())

    ' This will execute the lambda expression.
    Console.WriteLine(t)

    Console.ReadLine()
  End Sub
End Module
