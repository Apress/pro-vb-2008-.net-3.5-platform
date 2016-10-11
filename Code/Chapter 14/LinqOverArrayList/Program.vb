Option Strict On

Module Program
  Sub Main()
    Console.WriteLine("***** LINQ over ArrayList *****")

    Dim myCars As New ArrayList()
    myCars.Add(New Car With {.PetName = "Henry", .Color = "Silver", _
                          .Speed = 100, .Make = "BMW"})
    myCars.Add(New Car With {.PetName = "Daisy", .Color = "Tan", _
                              .Speed = 90, .Make = "BMW"})
    myCars.Add(New Car With {.PetName = "Mary", .Color = "Black", _
                              .Speed = 55, .Make = "VW"})
    myCars.Add(New Car With {.PetName = "Clunker", .Color = "Rust", _
                              .Speed = 5, .Make = "Yugo"})
    myCars.Add(New Car With {.PetName = "Melvin", .Color = "White", _
                              .Speed = 43, .Make = "Ford"})

    ' Transform ArrayList into an IEnumerable<T>-compatible type.
    ' Could also use implicit typing here. 
    Dim myCarsEnum As IEnumerable(Of Car) = myCars.OfType(Of Car)()

    ' Create a query expression.
    Dim fastCars = From c In myCarsEnum Where c.Speed > 55 Select c

    For Each car In fastCars
      Console.WriteLine("{0} is going too fast!", car.PetName)
    Next

    ExtractNumericalData()
  End Sub

  Sub ExtractNumericalData()
    ' Extract the ints from the ArrayList.
    Dim myStuff As New ArrayList()
    myStuff.AddRange(New Object() {10, 400, 8, False, New Car(), "string data"})
    Dim myInts As IEnumerable(Of Integer) = myStuff.OfType(Of Integer)()

    ' Prints out 10, 400, and 8.
    For Each i As Integer In myInts
      Console.WriteLine("Int value: {0}", i)
    Next
  End Sub
End Module
