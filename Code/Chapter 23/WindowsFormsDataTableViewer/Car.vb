Class Car
  ' Public for simplicity.
  Public carPetName As String
  Public carMake As String
  Public carColor As String

  Public Sub New(ByVal petName As String, ByVal make As String, ByVal color As String)
    carPetName = petName
    carColor = color
    carMake = make
  End Sub
End Class