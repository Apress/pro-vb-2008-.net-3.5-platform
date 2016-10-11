' If we did not implement the MustOverride Draw() method, Circle would also be
' considered abstract, and would have to be marked MustInherit!
Public Class Circle
  Inherits Shape
  Public Sub New()
  End Sub
  Public Sub New(ByVal name As String)
    MyBase.New(name)
  End Sub
  Public Overrides Sub Draw()
    Console.WriteLine("Drawing {0} the Circle", shapeName)
  End Sub
End Class


' Hexagon DOES override Draw().
Public Class Hexagon
  Inherits Shape
  Public Sub New()
  End Sub
  Public Sub New(ByVal name As String)
    MyBase.New(name)
  End Sub
  Public Overrides Sub Draw()
    Console.WriteLine("Drawing {0} the Hexagon", shapeName)
  End Sub
End Class

' This class extends Circle and hides the inherited Draw() method.
Public Class ThreeDCircle
  Inherits Circle

  ' Hide the shapeName field above me.
  Protected Shadows shapeName As String

  ' Hide any Draw() implementation above me.
  Public Shadows Sub Draw()
    Console.WriteLine("Drawing a 3D Circle")
  End Sub
End Class

