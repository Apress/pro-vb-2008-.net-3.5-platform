Public Class Triangle
  Inherits Shape
  Implements IPointy

  Public Sub New()
  End Sub
  Public Sub New(ByVal name As String)
    MyBase.New(name)
  End Sub

  Public Overrides Sub Draw()
    Console.WriteLine("Drawing {0} the Triangle", shapeName)
  End Sub

  Public ReadOnly Property Points() As Byte Implements IPointy.Points
    Get
      Return 3
    End Get
  End Property
End Class
