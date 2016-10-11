Public Class Rectangle
  Private m_topLeft As New Point()
  Private m_bottomRight As New Point()

  Public Property TopLeft() As Point
    Get
      Return m_topLeft
    End Get
    Set(ByVal value As Point)
      m_topLeft = value
    End Set
  End Property
  Public Property BottomRight() As Point
    Get
      Return m_bottomRight
    End Get
    Set(ByVal value As Point)
      m_bottomRight = value
    End Set
  End Property

  Public Overrides Function ToString() As String
    Return String.Format("[TopLeft: {0}, {1}, BottomRight: {2}, {3}]", _
 m_topLeft.X, m_topLeft.Y, m_bottomRight.X, m_bottomRight.Y)
  End Function
End Class
