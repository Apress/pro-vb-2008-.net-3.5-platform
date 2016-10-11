Option Explicit On
Option Strict On

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Custom Events *****")
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

  Public Sub EngineStartHandler(ByVal sender As Object, ByVal e As CarEventArgs)
    Console.WriteLine("Message from {0}: {1}", sender, e.msgData)
  End Sub
End Module