Option Explicit On
Option Strict On

Public Class Car
  ' The set of connected client.
  Private clientSinks As New ArrayList()

  ' The client calls these methods to connect
  ' to, or detatch from, the event notification.
  Public Sub Connect(ByVal sink As IEngineEvents)
    clientSinks.Add(sink)
  End Sub
  Public Sub Disconnect(ByVal sink As IEngineEvents)
    clientSinks.Remove(sink)
  End Sub

  ' Constant for maximum speed.
  Public Const maxSpeed As Integer = 100

  'Internal state data.
  Private currSpeed As Integer
  Private petName As String

  'Is the car still operational?
  Private carIsDead As Boolean

  'A car has a radio.
  Private theMusicBox As Radio = New Radio

  ' Constructors.
  Public Sub New()
  End Sub
  Public Sub New(ByVal name As String, ByVal currSp As Integer)
    currSpeed = currSp
    petName = name
  End Sub

  Public Sub CrankTunes(ByVal state As Boolean)
    theMusicBox.TurnOn(state)
  End Sub

  ' See if Car has overheated.
  Public Sub Accelerate(ByVal delta As Integer)
    ' If the car is doomed, sent out event to 
    ' each connected client. 
    If carIsDead Then
      For Each i As IEngineEvents In clientSinks
        i.Exploded("Sorry!  This car is toast!")
      Next
    Else
      currSpeed += delta
      If (maxSpeed - currSpeed) = 10 Then
        For Each i As IEngineEvents In clientSinks
          i.AboutToBlow("Careful! About to blow!")
        Next
      End If
      If currSpeed >= maxSpeed Then
        carIsDead = True
      Else
        Console.WriteLine("=> CurrSpeed = {0} ", currSpeed)
      End If
    End If
  End Sub
End Class