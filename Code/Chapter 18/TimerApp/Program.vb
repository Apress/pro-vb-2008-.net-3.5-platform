Option Explicit On
Option Strict On

Imports System.Threading

Module Program
  Sub Main()
    Console.WriteLine("***** Working with Timer type *****")
    Console.WriteLine()

    ' Pass in the delegate instance, data to send the 
    ' method 'pointed to', time to wait before starting
    ' and interval of time between calles. 
    Dim t As Timer = New Timer(AddressOf PrintTime, "Hi", 0, 1000)

    Console.WriteLine("Hit key to terminate...")
    Console.ReadLine()
  End Sub

  Sub PrintTime(ByVal state As Object)
    Console.WriteLine("Time is: {0}, Param is: {1}", _
      DateTime.Now.ToLongTimeString, state.ToString())
  End Sub
End Module
