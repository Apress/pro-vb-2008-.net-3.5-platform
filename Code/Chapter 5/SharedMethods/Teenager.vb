Public Class Teenager
  Public Shared r As Random = New Random()

  Public Shared Function GetRandomNumber(ByVal upperLimit As Short) As Integer
    Return r.Next(upperLimit)
  End Function

  Public Shared Function Complain() As String
    Dim messages As String() = _
      {"Do I have to?", "He started it!", "I'm too tired...", _
       "I hate school!", "You are sooooooo wrong!"}
    Return messages(GetRandomNumber(5))
  End Function
End Class
