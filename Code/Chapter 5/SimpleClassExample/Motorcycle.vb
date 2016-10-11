Public Class Motorcycle
  Public driverIntensity As Integer
  Public driverName As String

  Public Sub SetDriverName(ByVal name As String)
    ' These two line are functionally identical.
    driverName = name
    Me.driverName = name
  End Sub

  Public Sub PopAWheely()
    For i As Integer = 0 To driverIntensity
      Console.WriteLine("Yeeeeeee Haaaaaeewww!")
    Next
  End Sub

#Region "Constructors"
  Public Sub New()
    Console.WriteLine("In default c-tor")
  End Sub

  Public Sub New(ByVal intensity As Integer)
    Me.New(intensity, "")
    Console.WriteLine("In c-tor taking an Integer")
  End Sub

  Public Sub New(ByVal name As String)
    Me.New(5, name)
    Console.WriteLine("In c-tor taking a String")
  End Sub

  Public Sub New(ByVal intensity As Integer, ByVal name As String)
    Console.WriteLine("In master c-tor")
    If intensity > 10 Then
      intensity = 10
    End If
    driverIntensity = intensity
    driverName = name
  End Sub
#End Region

End Class



