Public Class Car
  Private currSpeed As Integer
  Private petName As String

  Public Sub New()
  End Sub

  Public Sub New(ByVal name As String, ByVal speed As Integer)
    petName = name
    currSpeed = speed
  End Sub

  Public Overrides Function ToString() As String
    Return String.Format("{0} is going {1} MPH", petName, currSpeed)
  End Function
End Class
