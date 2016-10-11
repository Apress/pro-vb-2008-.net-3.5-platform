Class Person
  Public fullName As String
  Public age As Integer

  Public Sub New(ByVal n As String, ByVal a As Integer)
    fullName = n
    age = a
  End Sub
  Public Sub New()
  End Sub

  Public Overrides Function ToString() As String
    Return String.Format("Name: {0}, Age: {1}", fullName, age)
  End Function
End Class
