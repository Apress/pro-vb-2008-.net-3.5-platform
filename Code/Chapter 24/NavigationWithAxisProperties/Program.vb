Module Program

  Sub Main()
    Console.WriteLine("***** Fun with XML Axis Properties *****")

    ' Load the Inventory.xml document into memory.
    Dim doc As XElement = XElement.Load("Inventory.xml")

    ' We will author each of these next...
    PrintAllPetNames(doc)
    Console.WriteLine()
    GetAllFords(doc)

    Console.WriteLine()
    GetAllIds(doc)

    Console.WriteLine()
    PrintAllColors(doc)

    Console.ReadLine()
  End Sub

#Region "Helper methods"
  Sub PrintAllPetNames(ByVal doc As XElement)
    ' Use XML descendant axis property to 
    ' navigate to <PetName> sub-element. 
    Dim petNames = From pn In doc...<PetName> _
                   Select pn.Value

    For Each name In petNames
      Console.WriteLine("Name: {0}", name)
    Next
  End Sub

  Sub GetAllFords(ByVal doc As XElement)
    Dim fords = From c In doc...<Make> _
                Where c.Value = "Ford" _
                Select c

    For Each f In fords
      Console.WriteLine("Make: {0}", f)
    Next
  End Sub

  Sub GetAllIds(ByVal doc As XElement)
    ' Navigate to <Car> element and 
    ' get carID attribute.
    Dim ids = From c In doc.<Car> _
                 Select c.@carID

    For Each id In ids
      Console.WriteLine(id)
    Next
  End Sub

  Sub PrintAllColors(ByVal doc As XElement)
    ' Get value of each color using indexer. 
    For i As Integer = 0 To doc.Nodes.Count - 1
      Console.WriteLine(doc.<Car>(i).<Color>.Value)
    Next
  End Sub


#End Region

End Module
