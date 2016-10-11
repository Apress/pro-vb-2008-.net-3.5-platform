Option Explicit On
Option Strict On

' A simple Car type for testing
Public Class Car
  Public PetName As String
  Public Speed As Integer
  Public Sub New(ByVal name As String, ByVal sp As Integer)
    PetName = name : Speed = sp
  End Sub
  Public Sub New()
  End Sub
End Class

Public Class SportsCar
  Inherits Car
  Public Sub New(ByVal p As String, ByVal s As Integer)
    MyBase.New(p, s)
  End Sub
  ' Assume additional SportsCar methods.
End Class

Public Class MiniVan
  Inherits Car
  Public Sub New(ByVal p As String, ByVal s As Integer)
    MyBase.New(p, s)
  End Sub
  ' Assume additional MiniVan methods.
End Class
