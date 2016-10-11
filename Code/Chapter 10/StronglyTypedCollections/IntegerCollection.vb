Option Explicit On
Option Strict On

Public Class IntegerCollection
  Implements IEnumerable

  Private arInts As New ArrayList()

  Public Function GetInt(ByVal pos As Integer) As Integer
    Return CType(arInts(pos), Integer)
  End Function

  Public Sub AddInt(ByVal i As Integer)
    arInts.Add(i)
  End Sub

  Public Sub ClearInts()
    arInts.Clear()
  End Sub

  Public ReadOnly Property Count() As Integer
    Get
      Return arInts.Count
    End Get
  End Property

  Public Function GetEnumerator() As IEnumerator _
  Implements IEnumerable.GetEnumerator
    Return arInts.GetEnumerator()
  End Function

  ' The 'indexer' of this custom collection.
  Default Public Property Item(ByVal c As Integer) As Integer
    Get
      Return CType(arInts(c), Integer)
    End Get
    Set(ByVal value As Integer)
      arInts.Insert(c, value)
    End Set
  End Property
End Class
