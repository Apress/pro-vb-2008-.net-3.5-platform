Module Program
  Sub Main()

    Dim interiorColor As String = "White"
    Dim exteriorColor As String = "Blue"

    ' Note the 'inlined' code blocks.
    Dim car1 As XElement = _
  <Automobile>
    <petname><%= GetPetName() %></petname>
    <color type="interior"><%= interiorColor %></color>
    <color type="exterior"><%= exteriorColor %></color>
  </Automobile>

    Console.WriteLine(car1)
  End Sub

  Function GetPetName() As String
    Return "Sidd"
  End Function
End Module
