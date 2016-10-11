Option Explicit On
Option Strict On

Public Structure Point(Of T)
  Private xPos, yPos As T

  Public Sub New(ByVal x As T, ByVal y As T)
    xPos = x : yPos = y
  End Sub

#Region "Properties for (x, y) values"
  Public Property X() As T
    Get
      Return xPos
    End Get
    Set(ByVal value As T)
      xPos = value
    End Set
  End Property
  Public Property Y() As T
    Get
      Return xPos
    End Get
    Set(ByVal value As T)
      yPos = value
    End Set
  End Property
#End Region

  Public Overrides Function ToString() As String
    Return String.Format("({0}, {1})", xPos, yPos)
  End Function
End Structure