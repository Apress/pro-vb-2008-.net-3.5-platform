' Car event sink.
Public Class CarEventSink
  Implements IEngineEvents
  Private name As String

  Public Sub New(ByVal sinkName As String)
    name = sinkName
  End Sub

  Public Sub AboutToBlow(ByVal msg As String) _
    Implements IEngineEvents.AboutToBlow
    Console.WriteLine("{0} reporting: {1}", name, msg)
  End Sub
  Public Sub Exploded(ByVal msg As String) _
    Implements IEngineEvents.Exploded
    Console.WriteLine("{0} reporting: {1}", name, msg)
  End Sub
End Class
