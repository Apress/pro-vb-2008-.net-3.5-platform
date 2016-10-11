Option Explicit On
Option Strict On

Imports System.Threading

#Region "Printer class"
Public Class Printer
  Public Sub PrintNumbers()
    SyncLock Me
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
    Console.WriteLine("Main thread started. ThreadID = {0}", _
      Thread.CurrentThread.GetHashCode)
    Dim p As Printer = New Printer
    Dim workItem As WaitCallback = AddressOf PrintTheNumbers

    ' Queue the method 10 times
    For i As Integer = 0 To 9
      ThreadPool.QueueUserWorkItem(workItem, p)
    Next
    Console.WriteLine("All tasks queued")
    Console.ReadLine()
  End Sub

  Sub PrintTheNumbers(ByVal state As Object)
    Dim task As Printer = CType(state, Printer)
    task.PrintNumbers()
  End Sub
End Module
