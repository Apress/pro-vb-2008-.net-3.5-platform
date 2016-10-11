Option Explicit On
Option Strict On

Public Class Car
  ' Our delegate type.
  Public Delegate Sub CarDelegateHandler(ByVal msg As String)

  ' Because delegates are simply classes, we can create
  ' member variables.
  Private almostDeadList As CarDelegateHandler
  Private explodedList As CarDelegateHandler

#Region "Registration / unregistration methods"
  ' Now with type-safe multicasting!
  Public Sub OnAboutToBlow(ByVal clientMethod As CarDelegateHandler)
    almostDeadList = CType(System.Delegate.Combine(almostDeadList, _
      clientMethod), CarDelegateHandler)
  End Sub
  Public Sub OnExploded(ByVal clientMethod As CarDelegateHandler)
    explodedList = CType(System.Delegate.Combine(explodedList, _
      clientMethod), CarDelegateHandler)
  End Sub

  ' To remove a target from the list.
  Public Sub RemoveAboutToBlow(ByVal clientMethod As CarDelegateHandler)
    almostDeadList = CType(System.Delegate.Remove(almostDeadList, _
      clientMethod), CarDelegateHandler)
  End Sub

  Public Sub RemoveExploded(ByVal clientMethod As CarDelegateHandler)
    explodedList = CType(System.Delegate.Remove(explodedList, _
      clientMethod), CarDelegateHandler)
  End Sub
#End Region

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
    If carIsDead Then
      If explodedList IsNot Nothing Then
        explodedList("Sorry, this car is dead...")
      End If
    Else
      currSpeed += delta
      If 10 = maxSpeed - currSpeed AndAlso almostDeadList IsNot Nothing Then
        almostDeadList("Careful buddy!  Gonna blow!")
      End If
      If currSpeed >= maxSpeed Then
        carIsDead = True
      Else
        Console.WriteLine("->CurrSpeed = {0} ", currSpeed)
      End If
    End If
  End Sub
End Class