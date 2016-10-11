' This example illustrates how to construct a polymorphic interface
' in a class heirarchy.

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Polymorphism *****")
    Console.WriteLine()

    ' Make an array of Shape compatible objects.
    Dim myShapes() As Shape = {New Hexagon(), New Circle(), _
      New Hexagon("Mick"), New Circle("Beth"), _
      New Hexagon("Linda")}

    ' Loop over each items and interact with the
    ' polymorphic interface.
    For Each s As Shape In myShapes
      s.Draw()
    Next

    ' Fun with shadowing.
    Dim o As ThreeDCircle = New ThreeDCircle()
    o.Draw()
    CType(o, Circle).Draw()
    Console.ReadLine()
  End Sub
End Module
