' The abstract base class of the hierarchy.
Public MustInherit Class Shape
  Protected shapeName As String

  Public Sub New()
    shapeName = "NoName"
  End Sub
  Public Sub New(ByVal s As String)
    shapeName = s
  End Sub

  Public MustOverride Sub Draw()

  Public Property PetName() As String
    Get
      Return shapeName
    End Get
    Set(ByVal value As String)
      shapeName = value
    End Set
  End Property
End Class
