Public Class MathService
  Implements IBasicMath

  Public Function Add(ByVal x As Integer, ByVal y As Integer) As Integer Implements IBasicMath.Add
    Return x + y
  End Function
End Class
