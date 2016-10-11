Public Class Octagon
  Implements IDrawToForm, IDrawToMemory, IDrawToPrinter

  Public Sub Draw() Implements IDrawToForm.Draw
    Console.WriteLine("Drawing to the screen")
  End Sub

  Public Sub RenderToMemory() Implements IDrawToMemory.Draw
    Console.WriteLine("Drawing to off screen memory")
  End Sub

  Public Sub Print() Implements IDrawToPrinter.Draw
    Console.WriteLine("Printing to printer")
  End Sub
End Class
