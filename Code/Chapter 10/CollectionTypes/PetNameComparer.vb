Imports System.Collections

Public Class PetNameComparer
  Implements IComparer

  Public Sub New()
  End Sub
  Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
    Dim t1 As Car = CType(x, Car)
    Dim t2 As Car = CType(y, Car)
    Return String.Compare(t1.Name, t2.Name)
  End Function
End Class
