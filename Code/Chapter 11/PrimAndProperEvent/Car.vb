Option Explicit On
Option Strict On

Public Class Car
  ' Constant for maximum speed.
  Public Const maxSpeed As Integer = 100

  'Internal state data.
  Private currSpeed As Integer
  Private petName As String

  'Is the car still operational?
  Private carIsDead As Boolean

  'A car has a radio.
  Private theMusicBox As Radio = New Radio

  ' This car can send these events.
  Public Event Exploded(ByVal sender As Object, ByVal e As CarEventArgs)
  Public Event AboutToBlow(ByVal sender As Object, ByVal e As CarEventArgs)

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

  Public Sub Accelerate(ByVal delta As Integer)
    If carIsDead Then
      ' If the car is doomed, sent out the Exploded notification.
      RaiseEvent Exploded(Me, New CarEventArgs("This car is doomed..."))
    Else
      currSpeed += delta
      ' Are we almost doomed?  If so, send out AboutToBlow notification.
      If 10 = maxSpeed - currSpeed Then
        RaiseEvent AboutToBlow(Me, New CarEventArgs("Slow down!"))
      End If
      If currSpeed >= maxSpeed Then
        carIsDead = True
      Else
        Console.WriteLine("->CurrSpeed = {0} ", currSpeed)
      End If
    End If
  End Sub
End Class
