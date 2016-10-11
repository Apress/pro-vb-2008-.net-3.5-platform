Public Class Line
  Implements IDrawToForm, IDrawToMemory, IDrawToPrinter

  ' This single class method defines an implementation for
  ' each interface method.
  Public Sub Draw() Implements IDrawToForm.Draw, _
    IDrawToMemory.Draw, IDrawToPrinter.Draw
    ' Common rendering logic…
  End Sub
End Class
