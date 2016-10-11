' A simple Car class.
Public Class Car
  Public ReadOnly MaxSpeed As Integer
  Private currSpeed As Integer

  Public Sub New(ByVal max As Integer)
    MaxSpeed = max
  End Sub
  Public Sub New()
    MaxSpeed = 55
  End Sub

  Public Property Speed() As Integer
    Get
      Return currSpeed
    End Get
    Set(ByVal value As Integer)
      currSpeed = value
      If currSpeed > MaxSpeed Then
        currSpeed = MaxSpeed
      End If
    End Set
  End Property
End Class
