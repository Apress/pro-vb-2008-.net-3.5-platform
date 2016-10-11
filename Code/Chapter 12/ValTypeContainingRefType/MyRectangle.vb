Structure MyRectangle
  ' The MyRectangle structure contains a reference type member.
  Public rectInfo As ShapeInfo

  Public top, left, bottom, right As Integer

  Public Sub New(ByVal info As String)
    rectInfo = New ShapeInfo(info)
    top = 10 : left = 10
    bottom = 10 : right = 100
  End Sub
End Structure
