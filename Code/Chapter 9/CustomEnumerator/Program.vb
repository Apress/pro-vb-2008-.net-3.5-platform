' This seems reasonable...
Module Program
  Sub Main()
    Console.WriteLine("***** Info about my Cars *****")
    Dim myCars As New Garage
    ' Hand over each car in the collection?
    For Each c As Car In myCars
      Console.WriteLine("{0} is going {1} MPH", _
        c.Name, c.Speed)
    Next

    ' Get IEnumerable directly.
    Dim iEnum As IEnumerator
    iEnum = myCars.GetEnumerator()
    iEnum.Reset()
    iEnum.MoveNext()

    Dim firstCar As Car = CType(iEnum.Current, Car)
    Console.WriteLine("First car in collection is: {0}", firstCar.Name)
    Console.ReadLine()
  End Sub
End Module
