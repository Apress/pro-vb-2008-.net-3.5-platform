Option Explicit On
Option Strict On

Class Car
  Public Sub New(ByVal pn As String, ByVal cs As Integer)
    petName = pn
    currSp = cs
  End Sub
  Public petName As String
  Public currSp As Integer
  Public r As Radio
End Class

Class Radio
  Public favoriteStation As Double
  Public Sub New(ByVal station As Double)
    favoriteStation = station
  End Sub
End Class