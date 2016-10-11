Public Class MyCustomRenderer
  Inherits FrameworkElement
  ' Default size for our rectangle. 
  Private m_rectWidth As Double = 105, m_rectHeight As Double = 55

  ' Allow user to override the defaults.
  Public Property RectHeight() As Double
    Get
      Return m_rectHeight
    End Get
    Set(ByVal value As Double)
      m_rectHeight = value
    End Set
  End Property
  Public Property RectWidth() As Double
    Get
      Return m_rectWidth
    End Get
    Set(ByVal value As Double)
      m_rectWidth = value
    End Set
  End Property

  Protected Overloads Overrides Sub OnRender(ByVal drawCtx As DrawingContext)
    ' Do parent rendering first.
    MyBase.OnRender(drawCtx)

    ' Add our custom rendering.
    Dim rect As New Rect()
    rect.Width = m_rectWidth
    rect.Height = m_rectHeight
    drawCtx.DrawRectangle(Brushes.LightBlue, New Pen(Brushes.Blue, 5), rect)
  End Sub
End Class
