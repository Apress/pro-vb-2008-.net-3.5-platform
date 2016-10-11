' The pointy behavior as a read-only property.
Public Interface IPointy
  ReadOnly Property Points() As Byte
End Interface

' Models the ability to render a type in stunning 3D.
Public Interface IDraw3D
  Sub Draw3D()
End Interface
