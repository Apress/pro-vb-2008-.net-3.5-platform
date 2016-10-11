Option Explicit On
Option Strict On

Public Class Car
  ' The custom delegate. 
  Public Delegate Sub CarDelegate(ByVal sender As Object, ByVal args As CarEventArgs)

  ' This ArrayList will hold onto the delegates
  ' sent from the caller. 
  Private arConnections As New ArrayList()

  ' This event has been customized!
  Public Custom Event EngineStart As CarDelegate
    AddHandler(ByVal value As CarDelegate)
      Console.WriteLine("Added connection")
      arConnections.Add(value)
    End AddHandler

    RemoveHandler(ByVal value As CarDelegate)
      Console.WriteLine("Removed connection")
      arConnections.Remove(value)
    End RemoveHandler

    RaiseEvent(ByVal sender As Object, ByVal e As CarEventArgs)
      For Each h As CarDelegate In arConnections
        Console.WriteLine("Raising event")
        h.Invoke(sender, e)
      Next
    End RaiseEvent
  End Event

  Public Sub Start()
    RaiseEvent EngineStart(Me, New CarEventArgs("Enjoy the ride"))
  End Sub
End Class
