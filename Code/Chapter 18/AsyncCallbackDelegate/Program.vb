Option Explicit On
Option Strict On

Imports System.Threading
Imports System.Runtime.Remoting.Messaging

' Our delegate.
Public Delegate Function BinaryOp(ByVal x As Integer, _
ByVal y As Integer) As Integer

Module Program
  Sub Main()
    Console.WriteLine("*****  AsyncCallbackDelegate Example *****")
    Console.WriteLine()

    Console.WriteLine("Main() invoked on thread {0}.", _
      Thread.CurrentThread.ManagedThreadId)
    Dim b As BinaryOp = New BinaryOp(AddressOf Add)

    Dim itfAR As IAsyncResult = _
      b.BeginInvoke(10, 10, New AsyncCallback(AddressOf AddComplete), _
      "Main() thanks you for adding these numbers.")

    ' Other work performed here...

    Console.ReadLine()
  End Sub

#Region "Target for AsynchCallback delegate"
  ' Don't forget to add a 'imports' directive for 
  ' System.Runtime.Remoting.Messaging!
  Sub AddComplete(ByVal itfAR As IAsyncResult)
    Console.WriteLine("AddComplete() invoked on thread {0}.", _
      Thread.CurrentThread.GetHashCode)
    Console.WriteLine("Your addition is complete")

    ' Now get the result.
    Dim ar As AsyncResult = CType(itfAR, AsyncResult)
    Dim b As BinaryOp = CType(ar.AsyncDelegate, BinaryOp)
    Console.WriteLine("10 + 10 is {0}.", b.EndInvoke(itfAR))

    ' Retrieve the informational object and cast it to string
    Dim msg As String = CType(itfAR.AsyncState, String)
    Console.WriteLine(msg)
  End Sub
#End Region

  Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
    Console.WriteLine("Add() invoked on thread {0}.", _
      Thread.CurrentThread.ManagedThreadId)
    Thread.Sleep(5000)
    Return x + y
  End Function
End Module
