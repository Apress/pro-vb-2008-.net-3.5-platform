#Region "The Cloneable Point type"
Public Class Point
  Implements ICloneable
  Public xPos, yPos As Integer

  ' Point ‘has-a’ PointDescription.
  Public desc As New PointDescription()

  Sub New()
  End Sub
  Sub New(ByVal x As Integer, ByVal y As Integer)
    xPos = x : yPos = y
  End Sub
  Sub New(ByVal x As Integer, ByVal y As Integer, ByVal name As String)
    xPos = x : yPos = y
    desc.petName = name
  End Sub

  Public Overrides Function ToString() As String
    Return String.Format("X = {0} ; Y = {1} ; Name = {2} : ID = {3}", _
      xPos, yPos, desc.petName, desc.pointID)
  End Function

  ' Now we need to adjust for the PointDescription member.
  Public Function Clone() As Object Implements System.ICloneable.Clone
    Dim newPoint As Point = CType(Me.MemberwiseClone(), Point)
    Dim currentDesc As PointDescription = New PointDescription()
    currentDesc.petName = Me.desc.petName
    currentDesc.pointID = Me.desc.pointID
    newPoint.desc = currentDesc
    Return newPoint
  End Function
End Class
#End Region

#Region "Class that maintains Point data"
' This class represents data about
' a given Point.
Public Class PointDescription
  Public petName As String
  Public pointID As Guid
  Public Sub New()
    Me.petName = "No-name"
    pointID = Guid.NewGuid
  End Sub
End Class
#End Region