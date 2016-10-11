Option Explicit On
Option Strict On

Public Class CarCollection(Of T As Car)
  Implements IEnumerable(Of T)

  Private myCars As New List(Of T)

  ' Error! System.Object does not have a 
  ' property named PetName.
  Public Sub PrintPetName(ByVal pos As Integer)
    Console.WriteLine(myCars(pos).PetName)
  End Sub

  ' Type indexer.
  Default Public Property Item(ByVal index As Integer) As T
    Get
      Return myCars(index)
    End Get
    Set(ByVal value As T)
      myCars.Add(value)
    End Set
  End Property

  Public Sub ClearCars()
    myCars.Clear()
  End Sub

  Public Function CarCount() As Integer
    Return myCars.Count()
  End Function

#Region "Interface implementations"
  Public Function GetEnumeratorGeneric() As IEnumerator(Of T) _
    Implements IEnumerable(Of T).GetEnumerator
    Return myCars.GetEnumerator()
  End Function

  Public Function GetEnumerator() As IEnumerator _
    Implements IEnumerable.GetEnumerator
    Return myCars.GetEnumerator()
  End Function
#End Region

End Class
