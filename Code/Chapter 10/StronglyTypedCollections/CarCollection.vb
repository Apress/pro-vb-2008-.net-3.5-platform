Option Explicit On
Option Strict On

Public Class CarCollection
  Implements IEnumerable
  Private arCars As New ArrayList()

  Public Function GetCar(ByVal pos As Integer) As Car
    Return CType(arCars(pos), Car)
  End Function

  Public Sub AddCar(ByVal c As Car)
    arCars.Add(c)
  End Sub

  Public Sub ClearCars()
    arCars.Clear()
  End Sub

  Public ReadOnly Property Count() As Integer
    Get
      Return arCars.Count
    End Get
  End Property

  Public Function GetEnumerator() As IEnumerator _
  Implements IEnumerable.GetEnumerator
    Return arCars.GetEnumerator()
  End Function

  ' The 'indexer' of this custom collection.
  Default Public Property Item(ByVal c As Integer) As Car
    Get
      Return CType(arCars(c), Car)
    End Get
    Set(ByVal value As Car)
      arCars.Insert(c, value)
    End Set
  End Property

End Class
