' Change to a Structure to see the change
' in program behavior. 
Public Class MyPoint
  Implements IComparable
  Public x As Integer, y As Integer

  Public Sub New(ByVal xPos As Integer, ByVal yPos As Integer)
    x = xPos
    y = yPos
  End Sub

  Public Overrides Function ToString() As String
    Return String.Format("[{0}, {1}]", Me.x, Me.y)
  End Function

#Region "Add/Subtract methods"
  ' Adding two MyPoint objects to yeild a new (larger) MyPoint.
  Public Shared Function Add(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As MyPoint
    Return New MyPoint(p1.x + p2.x, p1.y + p2.y)
  End Function

  ' Subtracting two MyPoint objects to yeild a new (smaller) MyPoint.
  Public Shared Function Subtract(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As MyPoint
    Return New MyPoint(p1.x - p2.x, p1.y - p2.y)
  End Function
#End Region

#Region "Overloaded + and - Operators"
  ' Overloaded operator +.
  Public Shared Operator +(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As MyPoint
    Return New MyPoint(p1.x + p2.x, p1.y + p2.y)
  End Operator

  ' Overloaded operator -.
  Public Shared Operator -(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As MyPoint
    Return New MyPoint(p1.x - p2.x, p1.y - p2.y)
  End Operator
#End Region

#Region "Overridden methods of System.Object"
  Public Overrides Function Equals(ByVal o As Object) As Boolean
    If TypeOf o Is MyPoint Then
      If Me.ToString() = o.ToString() Then
        Return True
      End If
    End If
    Return False
  End Function

  Public Overrides Function GetHashCode() As Integer
    Return Me.ToString().GetHashCode()
  End Function
#End Region

#Region "overload the = and <> operators"
  Public Shared Operator =(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As Boolean
    Return p1.Equals(p2)
  End Operator
  Public Shared Operator <>(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As Boolean
    Return Not p1.Equals(p2)
  End Operator
#End Region

#Region "IComparable implementation"
  Public Function CompareTo(ByVal obj As Object) As Integer _
  Implements IComparable.CompareTo
    If TypeOf obj Is MyPoint Then
      Dim p As MyPoint = CType(obj, MyPoint)
      If Me.x > p.x AndAlso Me.y > p.y Then
        Return 1
      End If
      If Me.x < p.x AndAlso Me.y < p.y Then
        Return -1
      Else
        Return 0
      End If
    Else
      Throw New ArgumentException()
    End If
  End Function
#End Region

#Region "The overloaded comparison ops"
  Public Shared Operator <(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As Boolean
    Return (p1.CompareTo(p2) < 0)
  End Operator
  Public Shared Operator >(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As Boolean
    Return (p1.CompareTo(p2) > 0)
  End Operator
  Public Shared Operator <=(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As Boolean
    Return (p1.CompareTo(p2) <= 0)
  End Operator
  Public Shared Operator >=(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As Boolean
    Return (p1.CompareTo(p2) >= 0)
  End Operator
#End Region

End Class
