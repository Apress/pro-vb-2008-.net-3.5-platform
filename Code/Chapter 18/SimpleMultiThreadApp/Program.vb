Option Explicit On
Option Strict On

Imports System.Threading
Imports System.Windows.Forms

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
    Console.WriteLine("***** The Amazing Thread App *****")
    Console.Write("Do you want [1] or [2] threads? ")
    Dim threadCount As String = Console.ReadLine()

    ' Name the current thread.
    Dim primaryThread As Thread = Thread.CurrentThread
    primaryThread.Name = "Primary"

    '  Display Thread info.
    Console.WriteLine("-> {0} is executing Main()", Thread.CurrentThread.Name)

    ' Make worker class.
    Dim p As Printer = New Printer()

    ' How many threads does the user want?
    Select Case threadCount
      Case "2"
        ' They want an extra thread.
        Dim backgroundThread As Thread = New Thread(AddressOf p.PrintNumbers)
        backgroundThread.Name = "Secondary"
        backgroundThread.Start()
      Case "1"
        p.PrintNumbers()
      Case Else
        Console.WriteLine("I don't know what you want...you get 1 thread.")
        p.PrintNumbers()
    End Select

    MessageBox.Show("I'm busy!", "Work on main thread...")
    Console.ReadLine()
  End Sub
End Module
