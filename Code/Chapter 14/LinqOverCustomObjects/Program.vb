Module Program

  Sub Main()
    Console.WriteLine("***** More fun with LINQ Expressions *****")

    ' Make a List of Car objects.
    Dim myCars As New List(Of Car)()
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

    GetFastCars(myCars)
    Console.WriteLine()

    GetFastBMWs(myCars)
  End Sub

  Sub GetFastCars(ByVal myCars As List(Of Car))
    ' Create a query expression.
    Dim fastCars = From c In myCars Where c.Speed > 55 Select c

    For Each car In fastCars
      Console.WriteLine("{0} is going too fast!", car.PetName)
    Next

  End Sub

  Sub GetFastBMWs(ByVal myCars As List(Of Car))
    ' Create a query expression.
    Dim fastCars = From c In myCars Where _
      c.Speed > 90 And c.Make = "BMW" Select c
    For Each car In fastCars
      Console.WriteLine("{0} is going too fast!", car.PetName)
    Next
  End Sub

End Module
