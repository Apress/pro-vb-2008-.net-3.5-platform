Public Class Car
  ' The 'state' of the Car.
  Public petName As String
  Public currSpeed As Integer

#Region "Constructors"
  ' A custom default constructor.
  Public Sub New()
    petName = "Chuck"
    currSpeed = 10
  End Sub

  ' Here, currSpeed will receive the
  ' default value of an Integer (zero).
  Public Sub New(ByVal pn As String)
    petName = pn
  End Sub

  ' Let caller set the full 'state' of the Car.
  Public Sub New(ByVal pn As String, ByVal cs As Integer)
    petName = pn
    currSpeed = cs
  End Sub
#End Region

  ' The functionality of the Car.
  Public Sub PrintState()
    Console.WriteLine("{0} is going {1} MPH.", _
      petName, currSpeed)
  End Sub
  Public Sub SpeedUp(ByVal delta As Integer)
    currSpeed += delta
  End Sub
End Class
