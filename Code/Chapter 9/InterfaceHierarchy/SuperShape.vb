Public Class SuperShape
  Implements IRenderToMemory
  Public Sub Draw() Implements IDrawable.Draw
    Console.WriteLine("Drawing...")
  End Sub

  Public Sub Print() Implements IPrintable.Print
    Console.WriteLine("Printing...")
  End Sub

  Public Sub Render() Implements IRenderToMemory.Render
    Console.WriteLine("Rendering...")
  End Sub
End Class
