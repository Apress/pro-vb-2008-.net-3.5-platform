Option Explicit On
Option Strict On

Imports System.Threading

' Our custom delegate. 
Public Delegate Function BinaryOp(ByVal x As Integer, _
ByVal y As Integer) As Integer

Module Program
  Sub Main()
    Console.WriteLine("***** Async Delegate Invocation *****")
    Console.WriteLine()

    ' Print out the ID of the executing thread.
    Console.WriteLine("Main() invoked on thread {0}.", _
      Thread.CurrentThread.ManagedThreadId)

    ' Invoke Add() on a secondary thread.
    Dim b As BinaryOp = New BinaryOp(AddressOf Add)
    Dim itfAR As IAsyncResult = b.BeginInvoke(10, 10, Nothing, Nothing)

    While Not itfAR.AsyncWaitHandle.WaitOne(2000, True)
      ' Do other work on primary thread...
      Console.WriteLine("Doing more work in Main()!")
      Thread.Sleep(1000)
    End While

    ' Obtain the result of the Add() 
    ' method when ready.
    Dim answer As Integer = b.EndInvoke(itfAR)
    Console.WriteLine("10 + 10 is {0} .", answer)
    Console.ReadLine()
  End Sub

  Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
    ' Print out the ID of the executing thread.
    Console.WriteLine("Add() invoked on thread {0}.", _
      Thread.CurrentThread.ManagedThreadId)

    '  Pause to simulate a lengthy operation.
    Thread.Sleep(5000)
    Return x + y
  End Function
End Module
