
#Region "Car class for testing purposes"
Public Class Car
  Public PetName As String = String.Empty
  Public Color As String = String.Empty
  Public Speed As Integer
  Public Make As String = String.Empty

  Public Overloads Overrides Function ToString() As String
    Return String.Format("Make={0}, Color={1}, Speed={2}, PetName={3}", Make, Color, Speed, PetName)
  End Function
End Class
#End Region

Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Query Expressions *****")

    ' This array will be the basis of our testing...
    Dim myCars As Car() = {New Car With _
      {.PetName = "Henry", .Color = "Silver", _
       .Speed = 100, .Make = "BMW"}, _
    New Car With {.PetName = "Daisy", .Color = "Tan", .Speed = 90, .Make = "BMW"}, _
    New Car With {.PetName = "Mary", .Color = "Black", .Speed = 55, .Make = "VW"}, _
    New Car With {.PetName = "Clunker", _
                  .Color = "Rust", .Speed = 5, .Make = "Yugo"}, _
    New Car With {.PetName = "Hank", .Color = "Tan", .Speed = 0, .Make = "Ford"}, _
    New Car With {.PetName = "Sven", .Color = "White", .Speed = 90, .Make = "Ford"}, _
    New Car With {.PetName = "Mary", .Color = "Black", .Speed = 55, .Make = "VW"}, _
    New Car With {.PetName = "Zippy", .Color = "Yellow", .Speed = 55, .Make = "VW"}, _
    New Car With {.PetName = "Melvin", .Color = "White", _
                  .Speed = 43, .Make = "Ford"}}

    ' Comment / uncomment to test.
    'BasicSelections(myCars)
    'GetSubsets(myCars)
    'GetProjection(myCars)
    'ReversedSelection(myCars)
    'OrderedResults(myCars)
    GetDiff()

    Console.ReadLine()
  End Sub


#Region "Select everything"
  Sub BasicSelections(ByVal myCars As Car())

    ' Get all cars. Similar to Select * in SQL.
    Console.WriteLine(vbLf + "All Cars:")
    Dim allCars = From c In myCars Select c
    For Each c In allCars
      Console.WriteLine("Car: {0}", c)
    Next
    Console.WriteLine()

    ' Get only the pet names.
    Console.WriteLine(vbLf + "All Pet Names:")
    Dim allNames = From c In myCars Select c.PetName
    For Each n In allNames
      Console.WriteLine("Pet Name: {0}", n)
    Next
    Console.WriteLine()

    ' Now get only distinct makes. 
    Console.WriteLine(vbLf + "All Distinct Makes:")
    Dim makes = From c In myCars Select c.Make Distinct
    For Each m In makes
      Console.WriteLine("Make: {0}", m)
    Next
    Console.WriteLine()

  End Sub
#End Region

#Region "Get subsets"
  Sub GetSubsets(ByVal myCars As Car())
    ' Now get only the BMWs.
    Console.WriteLine("Only BMWs:")
    Dim onlyBMWs = From c In myCars Where c.Make = "BMW" Select c

    For Each n In onlyBMWs
      Console.WriteLine("Name: {0}", n)
    Next

    ' Get BMWs going at least 100 mph.
    Dim onlyFastBMWs = From c In myCars _
                       Where c.Make = "BMW" And c.Speed >= 100 _
                       Select c

    For Each c As Car In onlyFastBMWs
      Console.WriteLine("{0} is going {1} MPH", c.PetName, c.Speed)
    Next
  End Sub
#End Region

#Region "Get count"
  Sub GetCount()
    Dim currentVideoGames() As String = {"Morrowind", "BioShock", _
      "Half Life 2: Episode 1", "The Darkness", _
      "Daxter", "System Shock 2"}

    ' Get count from the query.
    Dim numb As Integer = (From g In currentVideoGames _
                Where g.Length > 6 _
                Order By g _
                Select g).Count()

    ' numb is the value 5.
    Console.WriteLine("{0} items honor the LINQ query.", numb)
  End Sub
#End Region

#Region "Get projection"
  Sub GetProjection(ByVal myCars As Car())
    ' Now get structured data which only accounts for the 
    ' Make and Color of each item.
    Console.WriteLine(vbLf + "Makes and Color:")

    Dim makesColors = From c In myCars Select New With {c.Make, c.Color}

    For Each n In makesColors
      Console.WriteLine("Name: {0}", n)
    Next
  End Sub
#End Region

#Region "Reverse selections"
  Sub ReversedSelection(ByVal myCars As Car())
    ' Get everything in reverse.
    Console.WriteLine("All cars in reverse:")
    Dim subset = (From c In myCars Select c).Reverse()
    For Each c As Car In subset
      Console.WriteLine("{0} is going {1} MPH", c.PetName, c.Speed)
    Next
  End Sub
#End Region

#Region "Ordering results"
  Sub OrderedResults(ByVal myCars As Car())
    ' Order all the cars by PetName.
    Dim subset = From c In myCars Order By c.PetName Select c

    Console.WriteLine("Ordered by PetName:")
    For Each c As Car In subset
      Console.WriteLine("Car {0}", c)
    Next

    ' Now find the cars that are going less than 55 mph,
    ' and order by descending PetName
    subset = From c In myCars _
      Where c.Speed > 55 Order By c.PetName Descending Select c
    Console.WriteLine(vbLf + "Cars going faster than 55, ordered by PetName:")
    For Each c As Car In subset
      Console.WriteLine("Car {0}", c)
    Next
  End Sub
#End Region

#Region "Get differences"
  Sub GetDiff()
    ' Two lists of strings. 
    Dim myCars As String() = {"Yugo", "Aztec", "BMW"}
    Dim yourCars As String() = {"BMW", "Saab", "Aztec"}

    ' Find the differences.
    Dim carDiff = (From c In myCars Select c) _
      .Except(From c2 In yourCars Select c2)

    Console.WriteLine(vbLf + "Here is what you don't have, but I do:")
    For Each s As String In carDiff
      ' Prints Yugo.
      Console.WriteLine(s)
    Next
  End Sub
#End Region

End Module
