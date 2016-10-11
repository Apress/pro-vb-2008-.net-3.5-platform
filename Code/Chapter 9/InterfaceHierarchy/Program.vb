' This example illustrates building heirarchies
' of interfaces.

Module Program
  Sub Main()
    Console.WriteLine("***** The SuperShape *****")

    ' Call from object level.
    Dim myShape As New SuperShape
    myShape.Draw()

    ' Get IPrintable explicitly.
    ' (and IDrawable implicitly!)
    Dim iPrint As IPrintable
    iPrint = CType(myShape, IPrintable)
    iPrint.Draw()
    iPrint.Print()
  End Sub
End Module
