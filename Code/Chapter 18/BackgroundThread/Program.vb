Option Explicit On
Option Strict On

Imports System.Threading

#Region "Printer class"
Public Class Printer
  Public Sub PrintNumbers()
    ' Display Thread info.
    Console.WriteLine("-> {0} is executing PrintNumbers()", _
      Thread.CurrentThread.Name)

    ' Print out numbers.
    Console.Write("Your numbers: ")
    For i As Integer = 0 To 10
      Console.Write(i & ", ")
      Thread.Sleep(2000)
    Next
    Console.WriteLine()
  End Sub
End Class
#End Region

Module Program
  Sub Main()
    Console.WriteLine("***** Background Threads *****")
    Console.WriteLine()

    Dim p As Printer = New Printer
    Dim bgroundThread As Thread = New Thread(AddressOf p.PrintNumbers)

    ' Comment out the line below to force all threads to complete
    ' before this app domain shuts down. 
    bgroundThread.IsBackground = True

    bgroundThread.Start()
  End Sub
End Module
