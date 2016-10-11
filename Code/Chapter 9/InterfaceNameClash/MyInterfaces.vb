' Draw image to a Form.
Public Interface IDrawToForm
  Sub Draw()
End Interface

' Draw to buffer in memory.
Public Interface IDrawToMemory
  Sub Draw()
End Interface

' Render to the printer
Public Interface IDrawToPrinter
  Sub Draw()
End Interface