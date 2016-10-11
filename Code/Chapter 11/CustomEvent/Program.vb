Option Explicit On
Option Strict On

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Custom Events *****")
    Console.WriteLine()

    Dim c As New Car()

    ' Dynamically hook into event.
    AddHandler c.EngineStart, AddressOf EngineStartHandler
    c.Start()

    ' Just to trigger our custom logic.
    RemoveHandler c.EngineStart, AddressOf EngineStartHandler

    ' Just to test we are no longer sending event. 
    c.Start()
    Console.ReadLine()
  End Sub

  ' Our handler must match this signature given that 
  ' EngineStart has been prototyped using the System.EventHandler delegate.
  Public Sub EngineStartHandler(ByVal sender As Object, ByVal e As EventArgs)
    Console.WriteLine("Car has started")
  End Sub
End Module