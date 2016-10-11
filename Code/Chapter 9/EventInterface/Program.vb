Module Program
  Sub Main()
    Console.WriteLine("***** Interfaces as event enablers *****")
    Dim myCar As New Car("SlugBug", 10)

    ' Make sink object.
    Console.WriteLine("***** Creating Sinks! *****")
    Dim sink As New CarEventSink("First Sink")
    Dim otherSink As New CarEventSink("Second Sink")

    ' Pass both sinks to car.
    myCar.Connect(sink)
    myCar.Connect(otherSink)

    ' Speed up (this will trigger the events).
    For i As Integer = 0 To 5
      myCar.Accelerate(20)
    Next

    ' Detach from first sink.
    myCar.Disconnect(sink)

    ' Speed up again (only otherSink will be called).
    For i As Integer = 0 To 5
      myCar.Accelerate(20)
    Next

    ' Detach from other sink.
    myCar.Disconnect(otherSink)
    Console.ReadLine()
  End Sub
End Module
