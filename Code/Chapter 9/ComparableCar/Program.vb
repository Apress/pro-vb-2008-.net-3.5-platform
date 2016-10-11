' This example illustrates how to build objects
' which can be sorted in various manners.

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with IComparable *****")

    ' Make an array of Car types.
    Dim myAutos(4) As Car
    myAutos(0) = New Car("Rusty", 80, 1)
    myAutos(1) = New Car("Mary", 40, 234)
    myAutos(2) = New Car("Viper", 40, 34)
    myAutos(3) = New Car("Mel", 40, 4)
    myAutos(4) = New Car("Chucky", 40, 5)

    Console.WriteLine("-> Before Sorting:")
    For Each c As Car In myAutos
      Console.WriteLine("Car {0} is named {1}.", c.ID, c.Name)
    Next
    Console.WriteLine()

    ' Sort my cars?
    Array.Sort(myAutos)
    Console.WriteLine("-> After Sorting:")
    For Each c As Car In myAutos
      Console.WriteLine("Car {0} is named {1}.", c.ID, c.Name)
    Next
    Console.WriteLine()

    ' Now sort by pet name.
    Array.Sort(myAutos, Car.SortByPetName)
    Console.WriteLine("-> Ordering by pet name:")
    For Each c As Car In myAutos
      Console.WriteLine("{0} has the ID of {1}.", c.Name, c.ID)
    Next
    Console.ReadLine()
  End Sub
End Module
