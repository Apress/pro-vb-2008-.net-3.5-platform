' This example illustrates how to leverage the Implements 
' keyword to resolve name clashes as well as a way to define
' a common shared implemention for interface members.

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Interface Name Clashes *****")
    Dim o As New Octagon

    ' Call IDrawToMemory.Draw()
    Dim iMem As IDrawToMemory
    iMem = CType(o, IDrawToMemory)
    iMem.Draw()

    ' Call IDrawToPrinter.Draw()
    Dim iPrint As IDrawToPrinter
    iPrint = CType(o, IDrawToPrinter)
    iPrint.Draw()

    ' Call IDrawToForm.Draw()
    Dim iForm As IDrawToForm
    iForm = CType(o, IDrawToForm)
    iForm.Draw()

    ' BlackAndWhiteBitmap's interface methods
    ' are private!
    Dim bmp As New BlackAndWhiteBitmap
    Dim i As IDrawToForm
    i = CType(bmp, IDrawToForm)
    i.Draw()

    Console.ReadLine()
  End Sub
End Module
