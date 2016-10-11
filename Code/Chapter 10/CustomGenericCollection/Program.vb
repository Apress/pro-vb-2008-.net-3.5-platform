Option Explicit On
Option Strict On

Module Program
  Sub Main()
    Console.WriteLine("***** Custom Generic Collection *****")
    Console.WriteLine()

    ' Make a collection of Cars.
    Dim myCars As New CarCollection(Of Car)
    myCars(0) = New Car("Rusty", 20)
    myCars(1) = New Car("Zippy", 90)

    For Each c As Car In myCars
      Console.WriteLine("PetName: {0} , Speed: {1} ", _
      c.PetName, c.Speed)
    Next

    Console.WriteLine()

    Dim otherCars As New CarCollection(Of Car)
    otherCars(0) = New MiniVan("Mel", 10)
    otherCars(1) = New SportsCar("Suzy", 30)
    For i As Integer = 0 To otherCars.CarCount - 1
      otherCars.PrintPetName(i)
    Next
    Console.ReadLine()
  End Sub
End Module
