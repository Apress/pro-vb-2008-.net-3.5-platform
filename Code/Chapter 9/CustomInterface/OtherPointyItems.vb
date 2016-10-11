' These types are just for testing purposes.
' They illustrate how the same interface can be
' supported in unique heirarchies.

Public Class PitchFork
  Implements IPointy
  Public ReadOnly Property Points() As Byte Implements IPointy.Points
    Get
      Return 3
    End Get
  End Property
End Class

Public Class Fork
  Implements IPointy

  Public ReadOnly Property Points() As Byte Implements IPointy.Points
    Get
      Return 4
    End Get
  End Property
End Class

Public Class Knife
  Implements IPointy

  Public ReadOnly Property Points() As Byte Implements IPointy.Points
    Get
      Return 1
    End Get
  End Property
End Class