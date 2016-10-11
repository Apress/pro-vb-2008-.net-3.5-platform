Public Interface IDrawable
  Sub Draw()
End Interface

Public Interface IPrintable
  Inherits IDrawable
  Sub Print()
End Interface

Public Interface IRenderToMemory
  Inherits IPrintable
  Sub Render()
End Interface
