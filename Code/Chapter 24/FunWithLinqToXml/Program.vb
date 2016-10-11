' Simple helper class to populate
' a List(Of T). 
Class Car
  Public PetName As String
  Public ID As Integer
End Class

' Comment / uncomment method calls to test. 
Module Program
  Sub Main()
    Console.WriteLine("*****Fun with LINQ to XML*****")
    'Console.WriteLine()
    'CreateXmlElementWithObjectModel()

    'Console.WriteLine()
    'CreateXmlElementWithXmlLiteral()

    'Console.WriteLine()
    'CreateFunctionalXmlDoc()

    'Console.WriteLine()
    CreateFunctionalXmlDocWithLiteral()

    CreateXmlDocFromArray()
    Console.WriteLine()

    LoadExistingXml()
    Console.ReadLine()
  End Sub

#Region "Create a single XML element"
  Sub CreateXmlElementWithXmlLiteral()
    Dim inventory As XElement = _
    <Inventory>
      <Car ID="1">
        <Color>Green</Color>
        <Make>BMW</Make>
        <PetName>Stan</PetName>
      </Car>
    </Inventory>

    ' Call ToString() on our XElement.
    Console.WriteLine(inventory)
  End Sub

  Sub CreateXmlElementWithObjectModel()
    ' A "functional" approach to build an
    ' XML element in memory.
    Dim inventory As XElement = _
      New XElement("Inventory", _
        New XElement("Car", New XAttribute("ID", "1"), _
          New XElement("Color", "Green"), _
          New XElement("Make", "BMW"), _
          New XElement("PetName", "Stan") _
        ) _
      )
    ' Call ToString() on our XElement.
    Console.WriteLine(inventory)
  End Sub
#End Region

#Region "Create XML doc"
  Sub CreateFunctionalXmlDoc()
    ' Create an in-memory XML document.
    Dim inventoryDoc As XDocument = _
      New XDocument( _
        New XDeclaration("1.0", "utf-8", "yes"), _
        New XComment("Current Inventory of AutoLot"), _
          New XElement("Inventory", _
            New XElement("Car", New XAttribute("ID", "1"), _
              New XElement("Color", "Green"), _
              New XElement("Make", "BMW"), _
              New XElement("PetName", "Stan") _
            ), _
            New XElement("Car", New XAttribute("ID", "2"), _
              New XElement("Color", "Pink"), _
              New XElement("Make", "Yugo"), _
              New XElement("PetName", "Melvin") _
            ) _
          ) _
        )
    ' Display the document and save to disk.
    Console.WriteLine(inventoryDoc)
    inventoryDoc.Save("SimpleInventory.xml")
  End Sub

  Sub CreateFunctionalXmlDocWithLiteral()
    ' Create an in-memory XML document.
    Dim inventoryDoc As XDocument = _
  <?xml version="1.0" encoding="utf-8" standalone="yes"?>
  <!--Current Inventory of AutoLot-->
  <Inventory>
    <Car ID="1">
      <Color>Green</Color>
      <Make>BMW</Make>
      <PetName>Stan</PetName>
    </Car>
    <Car ID="2">
      <Color>Pink</Color>
      <Make>Yugo</Make>
      <PetName>Melvin</PetName>
    </Car>
  </Inventory>

    ' Display the document and save to disk.
    Console.WriteLine(inventoryDoc)
    inventoryDoc.Save("SimpleInventory.xml")
  End Sub
#End Region

#Region "Create XML doc from array"
  Sub CreateXmlDocFromArray()
    ' Create an List of Car types. 
    Dim data As New List(Of Car)
    data.Add(New Car With {.PetName = "Melvin", .ID = 10})
    data.Add(New Car With {.PetName = "Pat", .ID = 11})
    data.Add(New Car With {.PetName = "Danny", .ID = 12})
    data.Add(New Car With {.PetName = "Clunker", .ID = 13})

    ' Now enumerate over the array to build
    ' an XElement.
    Dim vehicles As XElement = _
      New XElement("Inventory", _
      From c In data _
        Select New XElement("Car", _
         New XAttribute("ID", c.ID), _
         New XElement("PetName", c.PetName) _
        ) _
      )
    Console.WriteLine(vehicles)
  End Sub

  Sub CreateXmlDocFromArrayUsingLiteral()
    ' Create an List of Car types. 
    Dim data As New List(Of Car)
    data.Add(New Car With {.PetName = "Melvin", .ID = 10})
    data.Add(New Car With {.PetName = "Pat", .ID = 11})
    data.Add(New Car With {.PetName = "Danny", .ID = 12})
    data.Add(New Car With {.PetName = "Clunker", .ID = 13})

    Dim vehicles As XElement = _
      <Inventory>
        <%= From c In data _
          Select <Car ID=<%= c.ID %>>
                   <PetName><%= c.PetName %></PetName>
                 </Car> %>
      </Inventory>

    Console.WriteLine(vehicles)
  End Sub

#End Region

#Region "XML from Strings and files"
  Sub LoadExistingXml()

    ' Build an XElement from string.
    Dim myElement As String = _
      "<Car ID='3'>" & _
        "<Color>Yellow</Color>" & _
        "<Make>Yugo</Make>" & _
      "</Car>"

    Dim newElement As XElement = XElement.Parse(myElement)
    Console.WriteLine(newElement)
    Console.WriteLine()

    ' Load the SimpleInventory.xml file.
    Dim myDoc As XDocument = XDocument.Load("SimpleInventory.xml")
    Console.WriteLine(myDoc)
  End Sub

#End Region

End Module
