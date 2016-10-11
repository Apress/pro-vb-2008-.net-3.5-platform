' This example illustrates how to implement ICloneable
' to build types that support 'deep copies'

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with ICloneable *****")
    Dim p1 As New Point(50, 50, "Brad")
    Dim p2 As Point = CType(p1.Clone(), Point)

    Console.WriteLine("Before modification:")
    Console.WriteLine("p1: {0} ", p1)
    Console.WriteLine("p2: {0} ", p2)

    p2.desc.petName = "This is my second point"
    p2.xPos = 9
    Console.WriteLine("Changed p2.desc.petName and p2.x")

    Console.WriteLine("After modification:")
    Console.WriteLine("p1: {0} ", p1)
    Console.WriteLine("p2: {0} ", p2)
    Console.ReadLine()
  End Sub
End Module

