Public Class Garage
  Implements System.Collections.IEnumerable

  Private myCars() As Car = New Car(3) {}

  Public Sub New()
    myCars(0) = New Car("Fred", 40)
    myCars(1) = New Car("Zippy", 60)
    myCars(2) = New Car("Mabel", 0)
    myCars(3) = New Car("Max", 80)
  End Sub

  Public Function GetEnumerator() As System.Collections.IEnumerator _
    Implements System.Collections.IEnumerable.GetEnumerator
    Return myCars.GetEnumerator()
  End Function
End Class


