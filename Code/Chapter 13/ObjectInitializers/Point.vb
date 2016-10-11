Public Enum PointColor
  LightBlue
  BloodRed
  Gold
End Enum

Public Class Point
  Public xPos, yPos As Integer
  Private c As PointColor

  Public Sub New(ByVal color As PointColor)
    xPos = 0
    yPos = 0
    c = color
  End Sub
  Public Sub New()
  End Sub

  Public Sub New(ByVal x As Integer, ByVal y As Integer)
    xPos = x
    yPos = y
    c = PointColor.Gold
  End Sub

  Public Property X() As Integer
    Get
      Return xPos
    End Get
    Set(ByVal value As Integer)
      xPos = value
    End Set
  End Property
  Public Property Y() As Integer
    Get
      Return yPos
    End Get
    Set(ByVal value As Integer)
      yPos = value
    End Set
  End Property

  Public Overrides Function ToString() As String
    Return String.Format("[{0}, {1}, {2}]", xPos, yPos, c)
  End Function
End Class
