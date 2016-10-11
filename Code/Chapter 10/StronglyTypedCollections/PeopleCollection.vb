Option Explicit On
Option Strict On

Public Class PeopleCollection
  Implements IEnumerable
  Private arPeople As New ArrayList()

  Public Function GetPerson(ByVal pos As Integer) As Person
    Return CType(arPeople(pos), Person)
  End Function

  Public Sub AddPerson(ByVal p As Person)
    arPeople.Add(p)
  End Sub

  Public Sub ClearPeople()
    arPeople.Clear()
  End Sub

  Public ReadOnly Property Count() As Integer
    Get
      Return arPeople.Count
    End Get
  End Property

  Public Function GetEnumerator() As IEnumerator _
  Implements IEnumerable.GetEnumerator
    Return arPeople.GetEnumerator()
  End Function

  ' The 'indexer' of this custom collection.
  Default Public Property Item(ByVal p As Integer) As Person
    Get
      Return CType(arPeople(p), Person)
    End Get
    Set(ByVal value As Person)
      arPeople.Insert(p, value)
    End Set
  End Property

End Class
