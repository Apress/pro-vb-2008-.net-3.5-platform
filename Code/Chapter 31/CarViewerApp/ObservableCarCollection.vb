Imports System.Collections.ObjectModel

Public Class CarList
  Inherits ObservableCollection(Of Car)
  Public Sub New()
    ' Add a few entries to the list.
    Add(New Car(40, "BMW", "Black", "Sidd"))
    Add(New Car(55, "VW", "Black", "Mary"))
    Add(New Car(100, "Ford", "Tan", "Mel"))
    Add(New Car(0, "Yugo", "Green", "Clunker"))
  End Sub
End Class

#Region "Simple Car Class"
Public Class Car
  Private sp As Integer
  Private mk As String
  Private clr As String
  Private pName As String

  Public Property Speed() As Integer
    Get
      Return sp
    End Get
    Set(ByVal value As Integer)
      sp = value
    End Set
  End Property

  Public Property Make() As String
    Get
      Return mk
    End Get
    Set(ByVal value As String)
      mk = value
    End Set
  End Property
  Public Property Color() As String
    Get
      Return clr
    End Get
    Set(ByVal value As String)
      clr = value
    End Set
  End Property
  Public Property PetName() As String
    Get
      Return pName
    End Get
    Set(ByVal value As String)
      pName = value
    End Set
  End Property

  Public Sub New(ByVal CarSpeed As Integer, ByVal CarMake As String, _
                 ByVal CarColor As String, ByVal CarName As String)
    Speed = CarSpeed
    Make = CarMake
    Color = CarColor
    PetName = CarName
  End Sub
  Public Sub New()
  End Sub

  Public Overloads Overrides Function ToString() As String
    Return String.Format("{0} the {1} {2} is going {3} MPH", PetName, Color, Make, Speed)
  End Function
End Class
#End Region
