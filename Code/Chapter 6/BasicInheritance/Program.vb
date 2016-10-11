' The project illustrates the use of classical inheritance.

Module Program

  Sub Main()
    Console.WriteLine("***** Basic Inheritance *****")
    ' Make a Car type.
    Dim myCar As New Car(80)
    myCar.Speed = 50
    Console.WriteLine("My car is going {0} MPH", _
      myCar.Speed)

    ' Now make a MiniVan
    Dim myVan As New MiniVan()
    myVan.Speed = 10
    Console.WriteLine("My van is going {0} MPH", _
      myVan.Speed)

    ' Error! Cannot access private data of the parent from an object!
    ' myVan.currSpeed = 10
    Console.ReadLine()
  End Sub

End Module