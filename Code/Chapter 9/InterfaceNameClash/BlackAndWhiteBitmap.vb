' Notice each class method has been defined as Private
' and has been given very a nondescript name.
Public Class BlackAndWhiteBitmap
  Implements IDrawToForm, IDrawToMemory, IDrawToPrinter

  Private Sub X() Implements IDrawToForm.Draw
    ' Insert interesting code...
  End Sub

  Private Sub Y() Implements IDrawToMemory.Draw
    ' Insert interesting code...
  End Sub

  Private Sub Z() Implements IDrawToPrinter.Draw
    ' Insert interesting code...
  End Sub
End Class
