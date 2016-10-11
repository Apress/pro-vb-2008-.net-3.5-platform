Option Explicit On
Option Strict On

Imports System.Threading

' Our custom delegate. 
Public Delegate Function BinaryOp(ByVal x As Integer, ByVal y As Integer) As Integer

Module Program
  Sub Main()
    Console.WriteLine("***** Synch Delegate Review *****")
    Console.WriteLine()

    'Print out the ID of the executing thread.
    Console.WriteLine("Main() invoked on thread {0}.", _
      Thread.CurrentThread.ManagedThreadId)

    ' Invoke Add() in a synchronous manner.
    Dim b As BinaryOp = AddressOf Add
    Dim answer As Integer = b(10, 10)

    ' These lines will not execute until 
    ' the Add() method has completed.
    Console.WriteLine("Doing more work in Main()!")
    Console.WriteLine("10 + 10 is {0}.", answer)
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
