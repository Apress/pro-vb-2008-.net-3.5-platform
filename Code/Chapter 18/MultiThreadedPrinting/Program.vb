Option Explicit On
Option Strict On

Imports System.Threading

#Region "Printer class"
Public Class Printer
  ' Lock token.
  Private threadLock As Object = New Object()

  Public Sub PrintNumbers()
    SyncLock threadLock
      Console.WriteLine("-> {0} is executing PrintNumbers()", _
        Thread.CurrentThread.Name)
      Console.Write("Your numbers: ")
      For i As Integer = 0 To 10
        Dim r As Random = New Random()
        Thread.Sleep(100 * r.Next(5))
        Console.Write(i & ", ")
      Next
      Console.WriteLine()
    End SyncLock
  End Sub
End Class
#End Region

Module Program
  Sub Main()
    Console.WriteLine("***** Synchronizing Threads *****")
    Console.WriteLine()

    Dim p As Printer = New Printer()

    ' Make 11 threads that are all pointing to the same
    ' method on the same object.
    Dim threads(10) As Thread
    For i As Integer = 0 To 10
      threads(i) = New Thread(AddressOf p.PrintNumbers)
      threads(i).Name = String.Format("Worker thread #{0}", i)
    Next

    ' Now start each one.
    For Each t As Thread In threads
      t.Start()
    Next
    Console.ReadLine()
  End Sub
End Module
