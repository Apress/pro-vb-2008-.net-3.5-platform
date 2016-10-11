#Region "Circle Class"
' If we did not implement the MustOverride Draw() method, Circle would also be
' considered abstract, and would have to be marked MustInherit!
Public Class Circle
  Inherits Shape
  Implements IDraw3D

  Public Sub New()
  End Sub
  Public Sub New(ByVal name As String)
    MyBase.New(name)
  End Sub
  Public Overrides Sub Draw()
    Console.WriteLine("Drawing {0} the Circle", shapeName)
  End Sub

  Public Sub Draw3D() Implements IDraw3D.Draw3D
    Console.WriteLine("Drawing circle in 3D!")
  End Sub
End Class
#End Region

#Region "Hexagon Class"
' Hexagon DOES override Draw().
Public Class Hexagon
  Inherits Shape
  Implements IPointy, IDraw3D

  Public Sub New()
  End Sub
  Public Sub New(ByVal name As String)
    MyBase.New(name)
  End Sub
  Public Overrides Sub Draw()
    Console.WriteLine("Drawing {0} the Hexagon", shapeName)
  End Sub

  Public ReadOnly Property Points() As Byte Implements IPointy.Points
    Get
      Return 6
    End Get
  End Property

  Public Sub Draw3D() Implements IDraw3D.Draw3D
    Console.WriteLine("Drawing Hexagon in 3D!")
  End Sub
End Class
#End Region

#Region "ThreeDCircle Class"
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
#End Region