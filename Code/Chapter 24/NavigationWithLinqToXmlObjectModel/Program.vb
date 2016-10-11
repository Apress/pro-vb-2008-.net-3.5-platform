Module Program

  Sub Main()
    Console.WriteLine("***** Fun with LINQ to XML *****")

    ' Load the Inventory.xml document into memory.
    Dim doc As XElement = XElement.Load("Inventory.xml")

    ' We will author each of these next...
    PrintAllPetNames(doc)
    Console.WriteLine()
    GetAllFords(doc)

    Console.WriteLine()
    AddNewElements(doc)

    Console.ReadLine()
  End Sub

#Region "Helper methods"
  Sub PrintAllPetNames(ByVal doc As XElement)
    Dim petNames = From pn In doc.Descendants("PetName") _
                   Select pn.Value

    For Each name In petNames
      Console.WriteLine("Name: {0}", name)
    Next
  End Sub

  Sub GetAllFords(ByVal doc As XElement)
    Dim fords = From c In doc.Descendants("Make") _
                Where c.Value = "Ford" _
                Select c

    For Each f In fords
      Console.WriteLine(f)
    Next
  End Sub

  Sub AddNewElements(ByVal doc As XElement)
    For i As Integer = 0 To 4
      ' Add 5 new green Fords to the incoming document.
      ' Create a new XElement
      Dim newCar As New XElement("Car", _
        New XAttribute("ID", i + 1000), _
          New XElement("Color", "Green"), _
          New XElement("Make", "Ford"), _
          New XElement("PetName", ""))
      ' Add to doc.
      doc.Add(newCar)
    Next
    ' Show the updates.
    Console.WriteLine(doc)
  End Sub
#End Region

End Module
