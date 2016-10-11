' This example illustrates how to define and work with .NET interface
' types.

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Interfaces *****")
    ' Make an array of Shape-compatible types.
    Dim myShapes() As Shape = {New Hexagon("Fred"), New Circle("Angie"), _
      New ThreeDCircle(), New Triangle("Adam")}

    ' Now figure out which ones support IPointy.
    Dim itfPointy As IPointy
    For Each s As Shape In myShapes
      If TypeOf s Is IPointy Then
        itfPointy = CType(s, IPointy)
        Console.WriteLine("{0} has {1} points.", s.PetName, itfPointy.Points)
      Else
        Console.WriteLine("{0} does not implement IPointy!", s)
      End If
      ' Is this item IDraw3D aware?
      If TypeOf s Is IDraw3D Then
        DrawIn3D(CType(s, IDraw3D))
      End If
    Next

    ' Can we extract IPointy from an Array of Integers?
    Dim myInts() As Integer = {10, 20, 30}
    Dim i As IPointy = ExtractPointyness(myInts)

    ' Nope!
    If i Is Nothing Then
      Console.WriteLine("Sorry, this object was not IPointy compatible")
    End If

    ' This array can only contain types that
    ' implement the IPointy interface.
    Dim pointyThings() As IPointy = {New Hexagon(), New Knife(), _
      New Triangle(), New Fork(), New PitchFork()}
    Console.WriteLine("Here are some more pointy things:")
    For Each p As IPointy In pointyThings
      Console.WriteLine("Object has {0} points.", p.Points)
    Next

    Console.ReadLine()
  End Sub

#Region "Helper methods"
  ' This method can receive anything implementing IDraw3D.
  Sub DrawIn3D(ByVal itf3d As IDraw3D)
    Console.WriteLine("-> Drawing IDraw3D compatible type")
    itf3d.Draw3D()
  End Sub

  ' This method tests for IPointy-compatibility and,
  ' if able, returns an interface reference.
  Function ExtractPointyness(ByVal o As Object) As IPointy
    If TypeOf o Is IPointy Then
      Return CType(o, IPointy)
    Else
      Return Nothing
    End If
  End Function
#End Region

End Module
