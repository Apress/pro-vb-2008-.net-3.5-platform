Option Explicit On
Option Strict On

Public Class Person
  ' Made public for simplicity.
  Public currAge As Integer
  Public fName As String
  Public lName As String

  Public Sub New()
  End Sub
  Public Sub New(ByVal firstName As String, ByVal lastName As String, _
  ByVal age As Integer)
    currAge = age
    fName = firstName
    lName = lastName
  End Sub

  Public Overrides Function ToString() As String
    Return String.Format("{0}, {1} is {2} years old.", lName, fName, currAge)
  End Function
End Class
